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
    private const string ValidInterface = "Definit.Validation.IValid";
    private const string ValidBaseInterface = "Definit.Validation.IValidBase";

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
            name => $"{name} : {IsValidName}<{genericTypeSymbol.ToDisplayString()}>, {IsValidName}<{type.Name}, {type.Name}.Valid>",
            "Definit.Results",
            "Definit.Validation",
            "System.Text.Json"
        );

        var constructorName = info.ConstructorName;
        var name = info.Name;
        var minimalName = info.MinimalName;
        var valueType = genericTypeSymbol.ToDisplayString();

        code.AddBlock($$"""
        private readonly static Rule<{{valueType}}> _rule;

        private const string _NAME = "{{constructorName}}";

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


        // Validate

        public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this.Value, propertyName);

        public U<ValidationError> Validate(string? propertyName = null) => _rule.Validate(this.Value, propertyName ?? _NAME); 


        // Factory
        
        public static U<Valid, ValidationError> Create({{name}} value, string? propertyName = null) => Valid.Create(value, propertyName); 


        // JSON
        
        public static {{name}} Deserialize(string json) => new {{name}}(JsonSerializer.Deserialize<{{valueType}}>(json)!);  

        public static string Serialize({{name}} value) => JsonSerializer.Serialize(value.Value); 


        // Valid
        
        public readonly struct Valid : {{ValidInterface}}<{{name}}>, {{ValidBaseInterface}}<{{name}}.Valid>
        {
            {{name}} {{ValidInterface}}<{{name}}>.Value => this._Parent;

            public {{valueType}} Value => _Parent.Value;

            public {{name}} _Parent { get; }

            private Valid({{name}} parent)
            {
                this._Parent = parent;
            }

            public static implicit operator {{name}}(Valid value) => value.Value;


            // Factory

            public static U<Valid, ValidationError> Create({{name}} value, string? propertyName = null)
            {
                var (_, error) = value.Validate(propertyName ?? {{name}}._NAME);
                if(error is not null)
                {
                    return error.Value;
                }

                return new Valid(value);
            }


            // JSON
            
            public static U<Valid, ValidationError> Deserialize(string json) => Create({{name}}.Deserialize(json));

            public static string Serialize(Valid valid) => {{name}}.Serialize(valid._Parent);
        }
        """);

        return (code.ToString(), name);
    }
}

