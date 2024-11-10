using System.Collections.Immutable;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Results.Generator;

[Generator]
public class UnionGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            Helper.Attributes.GenerateUnion,
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
            Helper.Namespace,
            "System.Diagnostics.CodeAnalysis"
        );

        var name = info.Name;
        var constructorName = info.ConstructorName;

        var union = Helper.IsResult(symbol);
        if(union is null)
        {
            throw new Exception($"Cannot find Union.Base Interface Generic Args type from type :: {info.FullName}, have you added the Base interface?");
        }

        var (interior, extensions, _) = UnionBaseGenerator.GetInterior
        (
            union.TypeArguments.GetGenericArguments(),
            symbol.TypeArguments.GetGenericArguments(),
            constructorName, 
            name
        );

        extensions = string.Join("\n\t", extensions.Split('\n'));
        code.AddBlock(interior); 

        var result = $$"""
        {{code.ToString()}}

        public static partial class {{Helper.ExtensionsTypeName(constructorName)}}
        {
            {{extensions}}
        }
        """;

        return (result, name);
    }
}

