using System.Collections.Immutable;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Validation.Generator;

[Generator]
public class ObjectGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        Helper.RunIsValid(context, (s, c, v) => Execute(s, c, v));
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<Helper.Object> typeList
    )
    {
        foreach(var type in typeList.Select(x => GetType(x.Type, x.Symbol)))
        {
            context.AddSource($"{type.ClassName}.g.cs", type.Code);
        }
    }

    private static (string Code, string ClassName) GetType
    (
        TypeDeclarationSyntax type,
        ITypeSymbol typeSymbol
    )
    {
        var (code, typeInfo) = type.BuildTypeHierarchy
        (
            name => $"{name}: {Helper.IsValidName}",
            "Definit.Results",
            "Definit.Validation"
        );

        var name = typeInfo.Name;

        var properties = typeSymbol
            .GetMembers()
            .OfType<IPropertySymbol>()
            .Where(x => Helper.IsValid(x.Type))
            .Select(x => (Name: x.Name, Type: x.Type.ToDisplayString()));

        var propertiesDeclarations = string.Join("\n\t", properties.Select(x => $$"""public {{x.Type}}.Valid {{x.Name}} { get; }"""));
        var constructorParams = string.Join(", ", properties.Select(x => $"{x.Type}.Valid {x.Name}"));
        var constructorAssignment = string.Join("\n\t\t", properties.Select(x => $"this.{x.Name} = {x.Name};"));
        var validation = string.Join("\n\n", properties.Select(x => $$"""
                if(value.{{x.Name}}.IsValid().Is(out Error error_{{x.Name}}).Else(out var valid_{{x.Name}}))
                {
                    errors.Add((error_{{x.Name}}.Message, "{{x.Name}}"));
                }
        """));

        var validCreation = string.Join(", ", properties.Select(x => $"valid_{x.Name}")).TrimEnd(',');

        code.AddBlock($$"""
        public Result Validate() => IsValid();

        public Result<Valid> IsValid() => Valid.Create(this);

        public readonly struct Valid
        {
            public {{typeInfo.FullName}} Value { get; } 
    
            {{propertiesDeclarations}}

            private Valid({{typeInfo.FullName}} Value, {{constructorParams}})
            {
                this.Value = Value;
                {{constructorAssignment}}
            }

            public static Result<Valid> Create({{typeInfo.FullName}} value)
            {
                List<(string Error, string PropertyName)> errors = [];
                
        {{validation}}

                if(errors.Count > 0)
                {
                    return new Error(string.Join(" :: ", errors.Select(x => $"{x.PropertyName} => {x.Error}")));
                }

                return new Valid(value, {{validCreation}});
            }

            public static implicit operator {{typeInfo.FullName}}(Valid value) => value.Value;
        }
        """);

        return (code.ToString(), typeInfo.FullName);
    }
}

