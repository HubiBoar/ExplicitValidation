using System.Collections.Immutable;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Results.Generator;

[Generator]
public class EitherGenerator : IIncrementalGenerator
{
    const string EitherName = "Definit.Results.IEitherBase<";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            "Definit.Results.GenerateEitherAttribute",
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
        SourceHelper.Run(context, () => typeList
            .Select<INamedTypeSymbol, Func<(string, string)>>(x => () => GetType(x))
            .ToImmutableArray());
}

    private static (string Code, string ClassName) GetType
    (
        INamedTypeSymbol symbol
    )
    {
        var (code, info) = symbol.BuildTypeHierarchy
        (
            name => $"readonly {name}",
            "Definit.Results",
            "System.Diagnostics.CodeAnalysis"
        );

        var interf = symbol.AllInterfaces
            .Single(x => x.AllInterfaces.Any(y => y
                .ToDisplayString()
                .StartsWith(EitherName)))
            .ContainingType;

        var name = info.Name;
        var constructorName = info.ConstructorName;

        var genericArgs = interf.TypeArguments.GetGenericConstraints();

        var (interior, extensions, _) = EitherBaseGenerator.EitherInterior
        (
            genericArgs,
            symbol.TypeArguments.GetGenericConstraints(),
            constructorName, 
            name
        );

        extensions = string.Join("\n\t", extensions.Split('\n'));
        code.AddBlock(interior); 

        var result = $$"""
        {{code.ToString()}}

        public static partial class {{constructorName}}__Auto__Extensions
        {
            {{extensions}}
        }

        """;

        return (result, name);
    }
}

