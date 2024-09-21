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

            transform: (n, _) => ((n.TargetNode as TypeDeclarationSyntax)!, (n.TargetSymbol as INamedTypeSymbol)!)
        );

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<(TypeDeclarationSyntax Syntax, INamedTypeSymbol Symbol)> typeList
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
        INamedTypeSymbol symbol
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
            .Single(x => x.AllInterfaces.Any(y => y
                .ToDisplayString()
                .StartsWith(EitherName)))
            .ContainingType;

        var name = typeInfo.Name;
        var fullName = typeInfo.FullName;
        var constructorName = symbol.Name;

        var genericArgs = interf.TypeArguments.Select(x => x.ToDisplayString()).ToArray();

        var (interior, extensions, _) = EitherBaseGenerator.EitherInterior
        (
            genericArgs,
            symbol.TypeArguments.Select(x => x.ToDisplayString()).ToArray(),
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

        return (result, fullName);
    }
}

