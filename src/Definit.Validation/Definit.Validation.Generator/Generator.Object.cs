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
    private const string ValidInterface = "Definit.Validation.IValid";
    
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
        var typeName = type.ToDisplayString();
        var (code, info) = type.BuildTypeHierarchy
        (
            name => $"{name}: {IsValidName}<{typeName}, {typeName}.Valid>",
            "System.Collections.Immutable",
            "Definit.Results",
            "Definit.Validation",
            "System.Text.Json"
        );

        var name = info.Name;
        var constructorName = info.ConstructorName;

        var properties = type
            .GetMembers()
            .OfType<IPropertySymbol>()
            .Where(x => IsValid(x.Type))
            .Select(x => (Name: x.Name, Type: x.Type.ToDisplayString()))
            .ToImmutableArray();

        var propertiesDeclarations = string.Join("\n\t", properties
            .Select(x => $$"""public {{x.Type}}.Valid {{x.Name}} { get; }"""));

        var constructorParams = string.Join(", ", properties.Select(x => $"{x.Type}.Valid {x.Name}"));
        var constructorAssignment = string.Join("\n\t\t", properties.Select(x => $"this.{x.Name} = {x.Name};"));

        var validation = CreateValidation(properties.Select(x => x.Name).ToImmutableArray());

        var validCreation = string.Join(", ", properties.Select(x => $"valid_{x.Name}!.Value")).TrimEnd(',');

        code.AddBlock($$"""
        
        private const string _NAME = "{{constructorName}}";

        public U<ValidationError> Validate(string? propertyName = null)
        {
            return IsValid(propertyName ?? _NAME).ToResult();
        }

        public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this, propertyName);

        public static U<Valid, ValidationError> Create({{name}} value, string? propertyName = null) => Valid.Create(value, propertyName); 

        public static {{name}} Deserialize(string json) => JsonSerializer.Deserialize<{{name}}>(json)!;  
        public static string Serialize({{name}} value) => JsonSerializer.Serialize(value); 

        public readonly struct Valid : {{ValidInterface}}<{{name}}> 
        {
            public {{name}} Value { get; } 
    
            {{propertiesDeclarations}}

            private Valid({{name}} Value, {{constructorParams}})
            {
                this.Value = Value;
                {{constructorAssignment}}
            }

            public static U<Valid, ValidationError> Create({{name}} value, string? propertyName = null)
            {
                var name = propertyName is null ? _NAME : propertyName; 

        {{validation}}

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

    private static string CreateValidation(ImmutableArray<string> properties)
    {
        var validation = string.Join("\n", properties.Select(Interior));
        
        return $$"""
                List<ValidationError> errors = [];

        {{validation}} 
                if(errors.Count > 0)
                {
                    return new ValidationError(name, errors.ToImmutableArray());
                }
        """;

        static string Interior(string property)
        {
            return $$"""
                    var (valid_{{property}}, error_{{property}}) = value.{{property}}.IsValid("{{property}}");

                    if(error_{{property}} is not null)
                    {
                        errors.Add(error_{{property}}.Value);
                    }

            """;
        }
    }
}

