using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Validation.Generator;

[Generator]
public class ValidGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.CreateSyntaxProvider
        (
            predicate: (c, _) => c is ClassDeclarationSyntax,
            transform: (n, _) => (ClassDeclarationSyntax)n.Node
        )
        .Where(m => m is not null);

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<ClassDeclarationSyntax> typeList
    )
    {
//        if (!Debugger.IsAttached) Debugger.Launch();


        var types = typeList.Select
        (
            x => compilation
                .GetSemanticModel(x.SyntaxTree)
                .GetDeclaredSymbol(x) as INamedTypeSymbol
        )
        .Where(x => x is not null)
        .Select(x => x!.ToDisplayString());

        var output = string.Join(", ", types);

        var code = $$"""
        namespace SampleSourceGenerator;

        public static class ClassNames
        {
            public static string Output = "{{output}}";
        }
        """;

        context.AddSource("ClassNames.g.cs", code);
    }
}
