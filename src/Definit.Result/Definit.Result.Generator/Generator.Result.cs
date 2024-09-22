using System.Collections.Immutable;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Results.Generator;

[Generator]
public class ResultGenerator : IIncrementalGenerator
{
    const string ResultName = "Definit.Results.IResultBase<";
    const string EitherName = "Definit.Results.IEither<";
    const string ErrorName = "Definit.Results.IError<";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            "Definit.Results.GenerateResultAttribute",
            predicate: (c, _) =>
                c is TypeDeclarationSyntax type
                && type.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)),

            transform: (n, _) =>((n.TargetSymbol as INamedTypeSymbol)!)
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
        SourceHelper.Run(context, () => typeList
            .Select<INamedTypeSymbol, Func<(string, string)>>(x => () => GetType(x))
            .ToImmutableArray());
    }

    private static (string Code, string ClassName) GetType
    (
        INamedTypeSymbol type
    )
    {
        var (code, info) = type.BuildTypeHierarchy
        (
            name => $"readonly {name}",
            "Definit.Results",
            "System.Diagnostics.CodeAnalysis"
        );

        var interf = type.AllInterfaces
            .Single(x => x
                .ToDisplayString()
                .StartsWith(ResultName));

        var eitherType = interf.TypeArguments.Single() as INamedTypeSymbol; 

        var genericArgs = eitherType!.TypeArguments.Select(x => x.ToDisplayString()).ToArray();

        var name = info.Name;
        var constructorName = info.ConstructorName;

        var interior = ResultBaseGenerator.ResultInterior
        (
            genericArgs,
            eitherType.ToDisplayString(),
            constructorName, 
            name,
            false
        );

        code.AddBlock(interior);

        return (code.ToString(), name);
    }
}

