using System.Collections.Immutable;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Validation.Generator;

[Generator]
public class ValueGenerator : IIncrementalGenerator
{
    private const string Attribute = "Definit.Validation.IsValidAttribute`1";
    private const string AttributeName = "Definit.Validation.IsValidAttribute<";
    private const string IsValidName = "Definit.Validation.IIsValid";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            Attribute,
            predicate: (c, _) =>
                c is TypeDeclarationSyntax type
                && type.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)),

            transform: (n, _) => (n.TargetSymbol as INamedTypeSymbol, n
                .Attributes
                .Single(x =>
                    x.AttributeClass is not null 
                    && x.AttributeClass
                    .ToDisplayString()
                    .StartsWith(AttributeName))
                .AttributeClass!
                .TypeArguments.Single() as INamedTypeSymbol)
        );

        var compilation = context.CompilationProvider.Combine(provider.Collect());
        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right!)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<(INamedTypeSymbol Type, INamedTypeSymbol GenericType)> typeList
    )
    {
        SourceHelper.Run
        (
            context,
            () => typeList
                .Select<(INamedTypeSymbol Type, INamedTypeSymbol GenericType), Func<(string, string)>>
                (
                    x => () => GetType(x.Type, x.GenericType)
                )
                .ToImmutableArray()
        );
    }

    private static (string Code, string ClassName) GetType
    (
        INamedTypeSymbol type,
        INamedTypeSymbol genericTypeSymbol
    )
    {
        var (code, info) = type.BuildTypeHierarchy
        (
            name => $"readonly {name}: {IsValidName}<{genericTypeSymbol.ToDisplayString()}>",
            "Definit.Results",
            "Definit.Validation"
        );

        var constructorName = info.ConstructorName;
        var name = info.Name;
        var minimalName = info.MinimalName;
        var valueType = genericTypeSymbol.ToDisplayString();

        code.AddBlock($$"""
        private readonly static Rule<{{valueType}}> _rule;

        static {{constructorName}}()
        {
            _rule = new();
            Rule(_rule);
        }

        public {{valueType}} Value { get; }

        public {{constructorName}}({{valueType}} value)
        {
            Value = value;
        }

        public static implicit operator {{name}}({{valueType}} value) => new (value);

        public static implicit operator {{valueType}}({{name}} value) => value.Value;

        public ValidationError? Validate(string? propertyName = null) => _rule.Validate(Value, propertyName);

        public Either<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this, propertyName);

        public readonly struct Valid
        {
            public {{name}} Value { get; }

            private Valid({{name}} value)
            {
                Value = value;
            }

            public static Either<Valid, ValidationError> Create({{name}} value, string? propertyName = null)
            {
                var error = value.Validate(propertyName);
                if(error is not null)
                {
                    return error;
                }

                return new Valid(value);
            }
        }
        """);

        return (code.ToString(), name);
    }
}

