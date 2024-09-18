using System.Collections.Immutable;
using Definit.Validation.Generator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Results.Generator;

[Generator]
public class ResultGenerator : IIncrementalGenerator
{
    const string ResultName = "Definit.Results.NewApproach.IResult<";
    const string EitherName = "Definit.Results.NewApproach.IEither<";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            "Definit.Results.NewApproach.GenerateResultAttribute",
            predicate: (c, _) =>
                c is TypeDeclarationSyntax type
                && type.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)),

            transform: (n, _) => ((n.TargetNode as TypeDeclarationSyntax)!, (n.TargetSymbol as ITypeSymbol)!)
        );

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<(TypeDeclarationSyntax Syntax, ITypeSymbol Symbol)> typeList
    )
    {
        foreach(var type in typeList.Select(x => GetType(x.Syntax, x.Symbol)))
        {
            var name = type.ClassName.Replace("<", "_").Replace(">", "").Replace(", ", "_").Replace(" ", "_").Replace(",", "_");
            context.AddSource($"{name}.g.cs", type.Code);
        }
    }

    private static (string Code, string ClassName) GetType
    (
        TypeDeclarationSyntax syntax,
        ITypeSymbol symbol
    )
    {
        var (code, typeInfo) = syntax.BuildTypeHierarchy
        (
            name => $"readonly {name}",
            "Definit.Results",
            "Definit.Validation",
            "Definit.Results.NewApproach",
            "System.Diagnostics.CodeAnalysis"
        );
        var interf = symbol.AllInterfaces
            .Single(x => x
                .ToDisplayString()
                .StartsWith(ResultName));

        var genericArgs = interf.TypeArguments.Select(x => x.ToDisplayString()).ToArray();

        var name = typeInfo.Name;
        var fullName = typeInfo.FullName;
        var constructorName = symbol.Name;

        var (interior, either) = ResultBaseGenerator.ResultInterior(genericArgs, constructorName, name);

        var genericEitherArgs = interf
            .TypeArguments
            .OfType<INamedTypeSymbol>()
            .Where(x => x
                .AllInterfaces
                .SingleOrDefault(x =>
                {
                    var name = x.ToDisplayString();
                    return name.StartsWith(EitherName);
                }) is not null)
            .SelectMany(x => x!.TypeArguments.Select(y => (Arg: x.ToDisplayString(), Sub: y.ToDisplayString())));

        var constructors = string.Join("\n", genericEitherArgs.Select(
            x => $"public {constructorName}({x.Sub} value) => Either = new {x.Arg}(value);"));

        var operators = string.Join("\n", genericEitherArgs.Select(
            x => $"public static implicit operator {name}({x.Sub} value) => new (value);"));

        code.AddBlock($$"""
        {{interior}}

        {{constructors}}

        {{operators}}
        """);

        return (code.ToString(), typeInfo.FullName);
    }
}

