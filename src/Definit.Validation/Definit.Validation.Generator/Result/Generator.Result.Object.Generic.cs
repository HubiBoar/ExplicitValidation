using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

[Generator]
public class ObjectGenericGenerator : IIncrementalGenerator
{
    private const string ResultType = "Definit.Results.NewApproach.IResult";
    private const string TaskType = "System.Threading.Tasks.Task";
    private const string ValueTaskType = "System.Threading.Tasks.ValueTask";
    private const string Success = "Definit.Results.NewApproach.Success";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            "Definit.Results.NewApproach.GenerateObjectAttribute`1",
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
        foreach(var type in typeList.Select(x => GetType(x)))
        {
            var name = type.ClassName.Replace("<", "_").Replace(">", "").Replace(", ", "_").Replace(" ", "_").Replace(",", "_");
            context.AddSource($"{name}.g.cs", type.Code);
        }
    }

    private static (string Code, string ClassName) GetType
    (
        GeneratorAttributeSyntaxContext context
    )
    {
        var type = context.Attributes.Single().AttributeClass!.TypeArguments.Single();
        var value = context.Attributes.Single().NamedArguments.SingleOrDefault(x => x.Key == "AllowUnsafe").Value.Value;
        bool allowUnsafe = value is null ? false : bool.Parse(value.ToString());
        
        return ObjectGenerator.Generate(type, allowUnsafe);
    }
}

