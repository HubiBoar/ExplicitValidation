using System.Collections.Immutable;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

[Generator]
public class ObjectGenericGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            "Definit.Results.GenerateResult+ObjectAttribute`1",
            predicate: (c, _) => true,

            transform: (n, _) => n
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
        SourceHelper.Run(context, () => 
            typeList
            .SelectMany(x => x.Attributes
                .Where(y => y.AttributeClass is not null && y.AttributeClass!
                    .ToDisplayString()
                    .StartsWith("Definit.Results.GenerateResult.ObjectAttribute<")) 
                .Select<AttributeData, Func<(string, string)>>(x => () => GetType(context, x)))
                .ToImmutableArray());
    }

    private static (string Code, string ClassName) GetType
    (
        SourceProductionContext context,
        AttributeData attribute
    )
    {
        var type = attribute.AttributeClass!.TypeArguments.Single() as INamedTypeSymbol;
        var value = attribute.NamedArguments.SingleOrDefault(x => x.Key == "AllowUnsafe").Value.Value;
        bool allowUnsafe = value is null ? false : bool.Parse(value.ToString());
        
        return ObjectGenerator.Generate(context, type!, allowUnsafe);
    }
}

