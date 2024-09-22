using System.Collections.Immutable;
using Definit.Utils.SourceGenerator;
using Microsoft.CodeAnalysis;

namespace Definit.Results.Generator;

[Generator]
public class ResultBaseGenerator : IIncrementalGenerator
{
    private const string SuccessType = "Definit.Results.Success";
    private const string ErrorType = "Definit.Results.Error";

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var provider = context.SyntaxProvider.ForAttributeWithMetadataName
        (
            "Definit.Results.GenerateResult+BaseAttribute",
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
        SourceHelper.Run(context, () => typeList
            .SelectMany<GeneratorAttributeSyntaxContext, Func<(string, string)>>(x => GetType(x))
            .ToImmutableArray());
    }

    private static ImmutableArray<Func<(string Code, string ClassName)>> GetType
    (
        GeneratorAttributeSyntaxContext context
    )
    {
        var constructorArgs = context
            .Attributes
            .Single(x => x
                .AttributeClass!
                .ToDisplayString() == "Definit.Results.GenerateResult.BaseAttribute")
            .ConstructorArguments;

        var resultCount = int.Parse(constructorArgs.First().Value!.ToString());
        var errorCount = int.Parse(constructorArgs.Last().Value!.ToString());
  
        return Enumerable.Range(1, resultCount + 1).Select<int, Func<(string, string)>>(length => () =>
        {
            var resultGenerics = Enumerable.Range(0, length).Select(x => $"T{x}").ToArray();
            var genericArgs = string.Join(", ", resultGenerics);
            var resultName = $"Result<{genericArgs}>";

            var errors = string.Join("\n\n\n\t", Enumerable.Range(1, errorCount).Select(y =>
            {
                var errorGenerics = Enumerable.Range(0, y).Select(x => $"TE{x}").ToArray();
                var convertsFrom = resultGenerics.Concat(errorGenerics).ToArray();
                var convertsFromArgs = string.Join(", ", convertsFrom);
                var either = $"Either<{convertsFromArgs}>";
                return string.Join("\n\t", GenerateErrorType(convertsFrom, either, errorGenerics, false).Split('\n'));
            })
            .ToArray());

            var convertsFrom = resultGenerics.Concat(["Err"]).ToArray();
            var convertsFromArgs = string.Join(", ", convertsFrom);
            var either = $"Either<{convertsFromArgs}>";
            var interiorRaw = ResultInterior(convertsFrom, either, "Result", resultName, false); 
            var interior = string.Join("\n\t", interiorRaw.Split('\n'));

            var fromException = string.Join("\n\t\t", GenerateFromException(["Err"], either).Split('\n')); 

            var code = $$"""
            using Err = {{ErrorType}};
            using Success = {{SuccessType}};
            using System.Diagnostics.CodeAnalysis;

            namespace Definit.Results;

            public readonly struct {{resultName}} : {{resultName}}.Base
            {
                public interface Base : IResultBase<{{either}}>
                {
                    {{fromException}}
                }
                
                {{interior}}


                {{errors}}
            }
            """;

            return (code, $"Definit.Results.Result_{length}");
        })
        .Concat([() => GenerateResult0(errorCount)])
        .ToImmutableArray();
    }

    private static (string Code, string ClassName) GenerateResult0(int errorCount)
    {
        var resultName = "Result";

        var errors = string.Join("\n\n\n\t", Enumerable.Range(1, errorCount).Select(y =>
        {
            var first = y == 1;
            var errorGenerics = Enumerable.Range(0, y).Select(x => $"TE{x}").ToArray();
            var convertsFromArgs = string.Join(", ", errorGenerics);
            var either = first ? $"TE0?" : $"Either<Success, {convertsFromArgs}>";
            return string.Join("\n\t", GenerateErrorType(errorGenerics, either, errorGenerics, first).Split('\n'));
        })
        .ToArray());

        var either = "Err?";
        var interiorRaw = ResultInterior(["Err"], either, "Result", resultName, true); 
        var interior = string.Join("\n\t", interiorRaw.Split('\n'));

        var fromException = string.Join("\n\t\t", GenerateFromException(["Err"], either).Split('\n')); 

        var code = $$"""
        using Err = {{ErrorType}};
        using Success = {{SuccessType}};
        using System.Diagnostics.CodeAnalysis;

        namespace Definit.Results;

        public readonly struct Success;

        public readonly struct {{resultName}} : {{resultName}}.Base
        {
            public interface Base : IResultBase<{{either}}>
            {
                {{fromException}}
            }
            
            {{interior}}


            {{errors}}



            public static readonly Success Success = new ();
            public static readonly EitherMatchError MatchError = new (); 
            
            public static Error? Try(Action func) 
            {
                try
                {
                    func();
                    return ResultHelper.ToReturn<Definit.Results.Result, Error?>(Success);
                }
                catch (Exception exception)
                {
                    return ResultHelper.ToReturn<Definit.Results.Result, Error?>(exception);
                }
            }

            public static Either<T, Error> Try<T>(Func<T> func)
            {
                try
                {
                    return ResultHelper.ToReturn<Definit.Results.Result<T>, Either<T, Error>>(func());
                }
                catch (Exception exception)
                {
                    return ResultHelper.ToReturn<Definit.Results.Result<T>, Either<T, Error>>(exception);
                }
            }
        }
        """;

        return (code, $"Definit.Results.Result_0");
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
        string[] convertFrom,
        string either,
        string[] errorGenerics,
        bool convertFromSuccess
    )
    {
        var genericConstraints = string.Join("\n\t",
            errorGenerics.Select(x => $"where {x} : struct, IError<{x}>"));
       
        var errorGenericArgs = string.Join(", ", errorGenerics);
        var genericName = $"Error<{errorGenericArgs}>";

        var interior = ResultInterior
        (
            convertFrom,
            either,
            "Error",
            genericName,
            convertFromSuccess
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

    public static string ResultInterior
    (
        string[] convertFrom,
        string either,
        string constructorName,
        string typeName,
        bool convertFromSuccess
    )
    {
        var operators = string.Join("\n", convertFrom
            .Select(x => $"public static implicit operator {typeName}({x} value) => new (value);"));

        var successOperator = convertFromSuccess
        ?
        $"public static implicit operator {typeName}(Success value) => new (null!);"
        :
        string.Empty;

        var code = $$"""
        private {{either}} Either { get; }

        [Obsolete(DefaultConstructorException.Attribute, true)]
        public {{constructorName}}() => throw new DefaultConstructorException();

        public {{constructorName}}({{either}} value) => Either = value;

        {{either}} IResultBase<{{either}}>.Value => Either;

        public static implicit operator {{typeName}}([DisallowNull] EitherMatchError _) => throw new EitherMatchException<{{either}}>();
        {{successOperator}}
        {{operators}}
        """;

        return code;
    }
}

