using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Validation.Generator;

[Generator]
public class ObjectGenerator : IIncrementalGenerator
{
    private const string interfaceName = "NewApproach.IIsValid";
    private const string valueInterfaceName = "NewApproach.IIsValid<";

    private static bool IsValid(ITypeSymbol typeSymbol)
    {
        return typeSymbol.AllInterfaces.Any(x => x.ToDisplayString() == interfaceName);
    }

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.CreateSyntaxProvider
        (
            predicate: static (c, _) =>
                c is TypeDeclarationSyntax type
                && type.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)),

            transform: static (n, _) => (n.Node as TypeDeclarationSyntax)!
        )
        .Where(x => x is not null);

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<TypeDeclarationSyntax> typeList
    )
    {
        var typesList = typeList.Select(x =>
        {
            var symbol = compilation.GetSemanticModel(x.SyntaxTree).GetDeclaredSymbol(x) as ITypeSymbol;
            return (Symbol: symbol!, Record: x);
        })
        .DistinctBy(x => x.Symbol.ToDisplayString())
        .Where(x =>
            x.Symbol.AllInterfaces.All(y => y.ToDisplayString().StartsWith(valueInterfaceName) == false)
            && x.Symbol.AllInterfaces.SingleOrDefault(y => y.ToDisplayString() == interfaceName) is not null)
        .Select(x => 
        {

            return GetType(x.Record, x.Symbol);
        });

        foreach(var type in typesList)
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
        var (code, typeInfo) = type.BuildTypeHierarchy("Definit.Results");

        var name = typeInfo.Name;

        var properties = typeSymbol
            .GetMembers()
            .OfType<IPropertySymbol>()
            .Where(x => IsValid(x.Type))
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

