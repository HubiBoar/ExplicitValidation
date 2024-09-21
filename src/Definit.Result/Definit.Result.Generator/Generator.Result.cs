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
            "System.Diagnostics.CodeAnalysis"
        );
        var interf = symbol.AllInterfaces
            .Single(x => x
                .ToDisplayString()
                .StartsWith(ResultName));

        var eitherType = interf.TypeArguments.Single() as INamedTypeSymbol; 

        var genericArgs = eitherType!.TypeArguments.Select(x => x.ToDisplayString()).ToArray();

        var name = typeInfo.Name;
        var fullName = typeInfo.FullName;
        var constructorName = symbol.Name;

        var (interior, _) = ResultBaseGenerator.ResultInterior(genericArgs, constructorName, name);

        code.AddBlock(interior);

        return (code.ToString(), fullName);
    }
}

