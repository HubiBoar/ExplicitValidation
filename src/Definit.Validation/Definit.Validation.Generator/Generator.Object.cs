using System.Collections.Immutable;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Validation.Generator;

[Generator]
public class ObjectGenerator : IIncrementalGenerator
{
    private const string Attribute = "Definit.Validation.IsValidAttribute";
    private const string IsValidName = "Definit.Validation.IIsValid";
    
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            Attribute,
            predicate: (c, _) =>
                c is TypeDeclarationSyntax type
                && type.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)),

            transform: (n, _) => (n.TargetSymbol as INamedTypeSymbol)!
        );

        var compilation = context.CompilationProvider.Combine(provider.Collect());
        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<INamedTypeSymbol> typeList
    )
    {
        SourceHelper.Run
        (
            context,
            () => typeList
                .Select<INamedTypeSymbol, Func<(string, string)>>(x => () => GetType(x))
                .ToImmutableArray()
        );
    }

    private static (string Code, string ClassName) GetType
    (
        INamedTypeSymbol type
    )
    {
        var (code, info) = type.BuildTypeHierarchy
        (
            name => $"{name}: {IsValidName}",
            "System.Collections.Immutable",
            "Definit.Results",
            "Definit.Validation"
        );

        var name = info.Name;

        var properties = type
            .GetMembers()
            .OfType<IPropertySymbol>()
            .Where(x => IsValid(x.Type))
            .Select(x => (Name: x.Name, Type: x.Type.ToDisplayString()));

        var propertiesDeclarations = string.Join("\n\t", properties
            .Select(x => $$"""public {{x.Type}}.Valid {{x.Name}} { get; }"""));

        var constructorParams = string.Join(", ", properties.Select(x => $"{x.Type}.Valid {x.Name}"));
        var constructorAssignment = string.Join("\n\t\t", properties.Select(x => $"this.{x.Name} = {x.Name};"));

        var validation = string.Join("\n\n", properties.Select(x => $$"""
                var (valid_{{x.Name}}, error_{{x.Name}}) = value.{{x.Name}}.IsValid({{x.Name}});

                if(error_{{x.Name}} is not null)
                {
                    errors.Add(error_{{x.Name}}.Value);
                }
        """));

        var validCreation = string.Join(", ", properties.Select(x => $"valid_{x.Name}.Value!")).TrimEnd(',');

        code.AddBlock($$"""
        public Result Validate() => IsValid();

        public Result<Valid> IsValid() => Valid.Create(this);

        public readonly struct Valid
        {
            public {{name}} Value { get; } 
    
            {{propertiesDeclarations}}

            private Valid({{name}} Value, {{constructorParams}})
            {
                this.Value = Value;
                {{constructorAssignment}}
            }

            public static Either<Valid, ValidationError> Create({{name}} value, string? propertyName = null)
            {
                var name = propertyName is null ? "{{name}}" : propertyName; 

                var errors = new ImmutableArray<ValidationError>();
                
        {{validation}}

                if(errors.Length > 0)
                {
                    return new ValidationError(name, errors);
                }

                return new Valid(value, {{validCreation}});
            }

            public static implicit operator {{name}}(Valid value) => value.Value;
        }
        """);

        return (code.ToString(), name);
    }

    private static bool IsValid(ITypeSymbol type)
    {
        return type
            .GetAttributes()
            .Any(x =>
            {
                if(x.AttributeClass is null)
                {
                    return false;
                }

                var name = x.AttributeClass.ToDisplayString();
                
                return name.StartsWith(Attribute);
            })
            ||
            type
            .AllInterfaces
            .Any(x => x.ToDisplayString() == IsValidName);
    }
}

