using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Definit.Validation.Generator;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public sealed class ValidAttribute : Attribute
{

}

[Generator]
public class ValidGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            typeof(ValidAttribute).FullName,

            predicate: static (c, _) =>
                c is TypeDeclarationSyntax type
                && type.Modifiers.Any(m => m.IsKind(SyntaxKind.PartialKeyword)),

            transform: static (n, _) => n
        );

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left, source.Right)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation,
        ImmutableArray<GeneratorAttributeSyntaxContext> typeList
    )
    {
//        if (!Debugger.IsAttached) Debugger.Launch();

        var types = typeList.Select(x =>
        {
            return compilation
                .GetSemanticModel(x.TargetNode.SyntaxTree)
                .GetDeclaredSymbol(x.TargetNode) as INamedTypeSymbol;
        })
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
