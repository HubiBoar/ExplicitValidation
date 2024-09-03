using System.Collections.Immutable;
using System.Text;
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

        var validateProperties = string.Join("\n\t", properties.Select(x => $$"""("{{x.Name}}", {{x.Name}}.Validate()),"""));
        var extensionMethods = string.Join("\n\n", properties.Select(x => $$"""
            public static Valid<{{x.Type}}> {{x.Name}}(this Valid<{{name}}> valid) => new (valid.Value.{{x.Name}});
        """));

        code.AddBlock($$"""
        private (string PropertyName, Result Result)[] ValidateProperties() => 
        [
            {{validateProperties}}
        ];

        public Result Validate()
        {
            var errors =
                ValidateProperties()
                .Where(x => x.Result.Is(out Error _))
                .Select(x => 
                {
                    x.Result.Is(out Error error);
                    return (PropertyName: x.PropertyName, Error: error);
                })
                .ToArray();
        
            if(errors.Length > 0)
            {
                return new Error(string.Join(", ", errors.Select(x => $"{x.PropertyName} :: {x.Error.Message}")));
            }

            return Result.Success;
        }
        """);

        var extensionCode = new SourceBuilder([], typeInfo.NameSpace);

        extensionCode.AddBlock($$"""
        public static class {{string.Join("_", typeInfo.FullName.Split('.'))}}
        {
        {{extensionMethods}}
        }
        """);
        
        var builder = new StringBuilder(code.ToString())
            .AppendLine()
            .Append(extensionCode.ToString());


        return (builder.ToString(), typeInfo.FullName);
    }
}

