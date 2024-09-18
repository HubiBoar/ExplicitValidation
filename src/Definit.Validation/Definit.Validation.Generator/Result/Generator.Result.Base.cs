using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

[Generator]
public class ResultBaseGenerator : IIncrementalGenerator
{
    private const string ResultType = "Definit.Results.NewApproach.IResult";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            "Definit.Results.NewApproach.GenerateResult+BaseAttribute",
            predicate: (c, _) => true,

            transform: (n, _) => (n)
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
        foreach(var type in typeList.SelectMany(x => GetType(x)))
        {
            var name = type.ClassName.Replace("<", "_").Replace(">", "").Replace(", ", "_").Replace(" ", "_").Replace(",", "_");
            context.AddSource($"{name}.g.cs", type.Code);
        }
    }

    private static ImmutableArray<(string Code, string ClassName)> GetType
    (
        GeneratorAttributeSyntaxContext context
    )
    {
        int count = int.Parse(context
            .Attributes
            .Single(x => x
                .AttributeClass!
                .ToDisplayString() == "Definit.Results.NewApproach.GenerateResult.BaseAttribute")
            .ConstructorArguments
            .Single()
            .Value!
            .ToString());

        if(count <= 2)
        {
            return ImmutableArray<(string Code, string ClassName)>.Empty;
        }

        return Enumerable.Range(2, count - 1).Select(i =>
        {
            var generic = Enumerable.Range(0, i).Select(x => $"T{x}").ToArray();

            var genericConstraints = string.Join("\n\t",
                generic.Select((x, i) => i == 0 ? $"where {x} : notnull" : $"where {x} : struct, IError<{x}>"));
           
            var genericArgs = string.Join(", ", generic);
            var result = $"Result<{genericArgs}>";
            var (interior, either) = ResultInterior(generic, "Result", result); 

            interior = string.Join("\n\t", interior.Split('\n'));
            var code = $$"""
            using System.Diagnostics.CodeAnalysis;

            namespace Definit.Results.NewApproach;

            public interface I{{result}} : IResultBase<{{either}}>
                {{genericConstraints}};

            public readonly struct {{result}} : I{{result}} 
                {{genericConstraints}}
            {
                {{interior}}
            }
            """;

            return (code, $"Definit.Results.NewApproach.Result_{i}");
        })
        .ToImmutableArray();
    }

    public static (string Interior, string Either) ResultInterior(string[] generic, string constructorName, string typeName)
    {
        var genericArgs = string.Join(", ", generic);

        var either = $"Either<{genericArgs}>";

        var operators = string.Join("\n", generic
            .Select(x => $"public static implicit operator {typeName}([DisallowNull] {x} value) => new (value);"));

        var errorHandling = string.Join("\n\n", generic.Skip(1).Select((x, i) => 
        {
            var index = i+1;
            if(index == generic.Length -1)
            {
                return $"   return ErrorHelper.Matches<{x}>(exception).Error;";
            }

            return $$"""
                var {{x}}_match = ErrorHelper.Matches<{{x}}>(exception);

                if({{x}}_match.Matches)
                {
                    return {{x}}_match.Error;
                }
            """;
        }));

        var code = $$"""
        private {{either}} Either { get; }

        [Obsolete(DefaultConstructorException.Attribute, true)]
        public {{constructorName}}() => throw new DefaultConstructorException();

        public {{constructorName}}({{either}} value) => Either = value;

        {{either}} IResultBase<{{either}}>.Value => Either;

        static {{either}} IResultBase<{{either}}>.FromException(Exception exception)
        {
        {{errorHandling}}
        }

        public static implicit operator {{typeName}}([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<{{genericArgs}}>>();
        {{operators}}
        """;

        return (code, either);
    }
}

