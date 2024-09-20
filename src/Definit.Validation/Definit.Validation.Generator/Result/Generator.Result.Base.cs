using System.Collections.Immutable;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

[Generator]
public class ResultBaseGenerator : IIncrementalGenerator
{
    private const string SuccessType = "Definit.Results.NewApproach.Success";
    private const string ErrorType = "Definit.Results.NewApproach.Error";

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
        var constructorArgs = context
            .Attributes
            .Single(x => x
                .AttributeClass!
                .ToDisplayString() == "Definit.Results.NewApproach.GenerateResult.BaseAttribute")
            .ConstructorArguments;

        var resultCount = int.Parse(constructorArgs.First().Value!.ToString());
        var errorCount = int.Parse(constructorArgs.Last().Value!.ToString());
    
        return Enumerable.Range(0, resultCount + 1).Select(length =>
        {
            var resultGenerics = length == 0 ? ["Success"] : Enumerable.Range(0, length).Select(x => $"T{x}").ToArray();
            var genericArgs = string.Join(", ", resultGenerics);

            var resultName = length == 0 ? "Result" : $"Result<{genericArgs}>";

            var (interiorRaw, either) = ResultInterior(resultGenerics.Concat(["Err"]).ToArray(), "Result", resultName); 

            var interior = string.Join("\n\t", interiorRaw.Split('\n'));

            var errors = string.Join("\n\n\n\t", Enumerable.Range(1, errorCount).Select(y =>
            {
                var errorGenerics = Enumerable.Range(0, y).Select(x => $"TE{x}").ToArray();
                return string.Join("\n\t", GenerateErrorType(resultGenerics, errorGenerics).Split('\n'));
            })
            .ToArray());

            var fromException = string.Join("\n\t\t", GenerateFromException(["Err"], either).Split('\n')); 

            var code = $$"""
            using Err = {{ErrorType}};
            using Success = {{SuccessType}};
            using System.Diagnostics.CodeAnalysis;

            namespace Definit.Results.NewApproach;

            public readonly partial struct {{resultName}} : {{resultName}}.Base
            {
                public interface Base : IResultBase<{{either}}>
                {
                    {{fromException}}
                }
                
                {{interior}}


                {{errors}}
            }
            """;

            return (code, $"Definit.Results.NewApproach.Result_{length}");
        })
        .ToImmutableArray();
    }

    private static string GenerateFromException(string[] errorGenerics, string either)
    {
        var errorHandling = string.Join("\n\n", errorGenerics.Select((x, i) => 
        {
            if(i == errorGenerics.Length -1)
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

        return $$"""
        static {{either}} IResultBase<{{either}}>.FromException(Exception exception)
        {
        {{errorHandling}}
        }
        """;
    }

    private static string GenerateErrorType
    (
        string[] parentGenerics,
        string[] errorGenerics
    )
    {
        var genericConstraints = string.Join("\n\t",
            errorGenerics.Select(x => $"where {x} : struct, IError<{x}>"));
       
        var errorGenericArgs = string.Join(", ", errorGenerics);
        var genericName = $"Error<{errorGenericArgs}>";

        var genericArgs = parentGenerics.Concat(errorGenerics).ToArray();
        var (interior, either) = ResultInterior
        (
            genericArgs,
            "Error",
            genericName
        ); 

        interior = string.Join("\n\t", interior.Split('\n'));

        var fromException = string.Join("\n\t\t", GenerateFromException(errorGenerics, either).Split('\n')); 

        return $$"""
        public readonly struct {{genericName}} : {{genericName}}.Base 
            {{genericConstraints}}
        {
            public interface Base : IResultBase<{{either}}>
            {
                {{fromException}}
            }

            {{interior}}
        }
        """;
    }

    public static (string Interior, string Either) ResultInterior
    (
        string[] eitherGenerics,
        string constructorName,
        string typeName
    )
    {
        var genericArgs = string.Join(", ", eitherGenerics);

        var either = $"Either<{genericArgs}>";

        var operators = string.Join("\n", eitherGenerics
            .Select(x => $"public static implicit operator {typeName}({x} value) => new (value);"));

        var code = $$"""
        private {{either}} Either { get; }

        [Obsolete(DefaultConstructorException.Attribute, true)]
        public {{constructorName}}() => throw new DefaultConstructorException();

        public {{constructorName}}({{either}} value) => Either = value;

        {{either}} IResultBase<{{either}}>.Value => Either;

        public static implicit operator {{typeName}}([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<{{genericArgs}}>>();
        {{operators}}
        """;

        return (code, either);
    }
}

