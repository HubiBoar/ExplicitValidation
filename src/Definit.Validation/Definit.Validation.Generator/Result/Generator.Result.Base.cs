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
            .ToString());

        return Enumerable.Range(0, count).Select(i =>
        {
            var generic = Enumerable.Range(0, i).Select(x => $"T{x}").ToArray();
            var genericArgs = string.Join(", ", generic);;

            var genericConstraints = string.Join("\n\t", generic.Select((x, i) => i == 0 ? $"where {x} : notnull" : $"where {x} : struct, IError<{x}>"));

            var code = new StringBuilder($$"""
            namespace Definit.Results.NewApproach;

            public interface IResult<{{genericArgs}}> : IResultBase<Either<{{genericArgs}}>>
                {{genericConstraints}};

            public readonly struct Result<{{genericArgs}}> : IResult<{{genericArgs}}> 
                {{genericConstraints}}
            {
                private Either<{{genericArgs}}> Either { get; }

                [Obsolete(DefaultConstructorException.Attribute, true)]
                public Result() => throw new DefaultConstructorException();

                public Result(Either<{{genericArgs}}> value) => Either = value;

                Either<{{genericArgs}}> IResultBase<Either<{{genericArgs}}>>.Value => Either;

                static Either<{{genericArgs}}> IResultBase<Either<{{genericArgs}}>>.FromException(Exception exception)
                {
                    //TODO error handling
                    return T1.Matches(exception).Error;
                }

                public static implicit operator Result<{{genericArgs}}>(T0 value) => new (value); 
                public static implicit operator Result<{{genericArgs}}>(T1 value) => new (value);

                public static implicit operator Result<{{genericArgs}}>(Either<{{genericArgs}}> value) => new (value);
                // TODO Either Mapping
                // public static implicit operator Result<{{genericArgs}}>(Either<T1, T0> value) => new (value);
            }
            """);

            return (code.ToString(), $"Definit.Results.NewApproach.Result_{i}");
        })
        .ToImmutableArray();
    }
}

