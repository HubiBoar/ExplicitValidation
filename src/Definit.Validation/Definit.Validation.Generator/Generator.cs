using System.Collections.Immutable;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Validation.Generator;

[Generator]
internal sealed class ValidGenerator : IIncrementalGenerator
{
    private const string Attribute = "Definit.Validation.IsValidAttribute";
    private const string IsValidName = "Definit.Validation.IIsValid";
    private const string ValidInterface = "Definit.Validation.Valid";
    private const string IValidInterface = "Definit.Validation.IValid";
    private const string IValidBaseInterface = "Definit.Validation.IValidBase";
    
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
        var valid = type.AllInterfaces.SingleOrDefault(x => x.ToDisplayString().StartsWith(ValidInterface));
        
        if (valid is null)
        {
            return Object.GetType(type);
        }

        var genericArg = valid.TypeArguments.GetGenericArguments().Value.Single();
        return Value.GetType(type, genericArg);
    }

    public static class Object
    {
        public static (string Code, string ClassName) GetType
        (
            INamedTypeSymbol type
        )
        {
            var typeName = type.ToDisplayString();
            var (code, info) = type.BuildTypeHierarchy
            (
                name => $"{name} : {IsValidName}<{typeName}, {typeName}.Valid>",
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

            var constructorParams = properties.Length == 0 ? string.Empty : ", " + string.Join(", ", properties.Select(x => $"{x.Type}.Valid {x.Name}"));
            var constructorAssignment = string.Join("\n\t\t", properties.Select(x => $"this.{x.Name} = {x.Name};"));

            var validation = CreateValidation(properties.Select(x => x.Name).ToImmutableArray());

            var validCreation = string.Join(", ", properties.Select(x => $"valid_{x.Name}!.Value")).TrimEnd(',');

            code.AddBlock($$"""
            private const string _NAME = "{{constructorName}}";


            // Validate

            public U<ValidationError> Validate(string? propertyName = null) => IsValid(propertyName ?? _NAME).ToResult();

            public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this, propertyName);


            // Factory
            
            public static U<Valid, ValidationError> Create({{name}} value, string? propertyName = null) => Valid.Create(value, propertyName); 


            // JSON

            public static {{name}} Deserialize(string json) => JsonSerializer.Deserialize<{{name}}>(json)!;  

            public static string Serialize({{name}} value) => JsonSerializer.Serialize(value); 


            // Valid

            public readonly struct Valid : {{IValidInterface}}<{{name}}>, {{IValidBaseInterface}}<{{name}}.Valid> 
            {
                public {{name}} _Parent { get; } 

                {{name}} {{IValidInterface}}<{{name}}>.Value => this._Parent;
        
                {{propertiesDeclarations}}

                private Valid({{name}} _parent{{constructorParams}})
                {
                    this._Parent = _parent;
                    {{constructorAssignment}}
                }

                public static implicit operator {{name}}(Valid value) => value._Parent;

                // Factory

                public static U<Valid, ValidationError> Create({{name}} value, string? propertyName = null)
                {
                    var name = propertyName is null ? {{name}}._NAME : propertyName; 

            {{validation}}

                    return new Valid(value, {{validCreation}});
                }


                // JSON
                
                public static U<Valid, ValidationError> Deserialize(string json) => Create({{name}}.Deserialize(json));

                public static string Serialize(Valid valid) => {{name}}.Serialize(valid._Parent);
            }
            """);

            return (code.ToString(), $"Object_{name}");
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

    public static class Value
    {
        public static (string Code, string ClassName) GetType
        (
            INamedTypeSymbol type,
            Generic.Element generic
        )
        {
            var valueType = generic.Name;
            var (code, info) = type.BuildTypeHierarchy
            (
                name => $"{name} : {IsValidName}<{valueType}>, {IsValidName}<{type.Name}, {type.Name}.Valid>",
                "Definit.Results",
                "Definit.Validation",
                "System.Text.Json"
            );

            var constructorName = info.ConstructorName;
            var name = info.Name;
            var minimalName = info.MinimalName;

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
            
            public readonly struct Valid : {{IValidInterface}}<{{name}}>, {{IValidBaseInterface}}<{{name}}.Valid>
            {
                {{name}} {{IValidInterface}}<{{name}}>.Value => this._Parent;

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

            return (code.ToString(), $"Value_{name}");
        }

    }
}

