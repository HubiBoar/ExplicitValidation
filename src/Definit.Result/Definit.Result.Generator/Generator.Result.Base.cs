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
        var provider = context.SyntaxProvider.CreateSyntaxProvider
        (
            predicate: static (_, _) => EitherBaseGenerator.Activated,

            transform: (n, _) => (n)
        );

        var compilation = context.CompilationProvider.Combine(provider.Collect());

        context.RegisterSourceOutput(compilation, (spc, source) => Execute(spc, source.Left)); 
    }

    private static void Execute
    (
        SourceProductionContext context,
        Compilation compilation
    )
    {
        SourceHelper.Run(context, Run);
    }

    private static ImmutableArray<Func<(string Code, string ClassName)>> Run()
    {
        var count = EitherBaseGenerator.Count;

        return Enumerable.Range(1, resultCount + 1).Select<int, Func<(string, string)>>(length => () =>
        {
            var resultGenerics = new Generic.Elements
            (
                Enumerable
                    .Range(0, length)
                    .Select(x => Generic.Argument.Notnull($"T{x}"))
                    .ToImmutableArray()
            );
  
            var genericArgs = resultGenerics.ArgumentNames;
            var resultName = $"Result<{genericArgs}>";

            var errors = string.Join("\n\n\n\t", Enumerable.Range(1, errorCount).Select(errorsLength =>
            {
                var errorGenerics = new Generic.Elements
                (
                    Enumerable
                        .Range(0, errorsLength)
                        .Select(x => Generic.Argument.Struct($"TE{x}", $"IError<TE{x}>"))
                        .ToImmutableArray()
                );

                var convertsFrom = new Generic.Elements
                (
                    resultGenerics,
                    errorGenerics
                );

                var convertsFromArgs = convertsFrom.ArgumentNames;
                var either = $"Either<{convertsFromArgs}>";
                return string.Join("\n\t", GenerateErrorType(convertsFrom, either, errorGenerics, false).Split('\n'));
            })
            .ToArray());

            var convertsFrom = new Generic.Elements
            (
                resultGenerics,
                new Generic.Argument("Err")
            );

            var convertsFromArgs = convertsFrom.ArgumentNames;
            var either = $"Either<{convertsFromArgs}>";
            var interiorRaw = ResultInterior(convertsFrom, either, "Result", resultName, false); 
            var interior = string.Join("\n\t", interiorRaw.Split('\n'));

            var fromException = string.Join("\n\t\t", GenerateFromException
                (
                    new Generic.Elements(new Generic.Argument("Err")),
                    either
                )
                .Split('\n')
            ); 

            var code = $$"""
            using Err = {{ErrorType}};
            using System.Diagnostics.CodeAnalysis;

            namespace Definit.Results;

            public readonly struct {{resultName}} : {{resultName}}.Base{{resultGenerics.ConstraintsString}}
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

        var errors = string.Join("\n\n\n\t", Enumerable.Range(1, errorCount).Select(errorsLength =>
        {
            var first = errorsLength == 1;
            var errorGenerics = new Generic.Elements
            (
                Enumerable
                    .Range(0, errorsLength)
                    .Select(x => Generic.Argument.Struct($"TE{x}", $"IError<TE{x}>"))
                    .ToImmutableArray()
            );

            var convertsFromArgs = errorGenerics.ArgumentNames;
            var either = first ? $"TE0?" : $"Either<Success, {convertsFromArgs}>";
            return string.Join("\n\t", GenerateErrorType(errorGenerics, either, errorGenerics, first).Split('\n'));
        })
        .ToArray());

        var either = "Err?";
        var err = new Generic.Elements(new Generic.Argument("Err"));
        var interiorRaw = ResultInterior
        (
            err,
            either, 
            "Result", 
            resultName, 
            true
        ); 

        var interior = string.Join("\n\t", interiorRaw.Split('\n'));

        var fromException = string.Join("\n\t\t", GenerateFromException(err, either).Split('\n')); 

        var code = $$"""
        using Err = {{ErrorType}};
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

    private static string GenerateFromException(Generic.Elements errorGenerics, string either)
    {
        var errorHandling = string.Join("\n\n", errorGenerics.Value.Select((x, i) => 
        {
            var name = x.Name;
            if(i == errorGenerics.Value.Length -1)
            {
                return $"   return ErrorHelper.Matches<{name}>(exception).Error;";
            }

            return $$"""
                var {{name}}_match = ErrorHelper.Matches<{{name}}>(exception);

                if({{name}}_match.Matches)
                {
                    return {{name}}_match.Error;
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
        Generic.Elements convertFrom,
        string either,
        Generic.Elements errorGenerics,
        bool convertFromSuccess
    )
    {
        var errorGenericArgs = string.Join(", ", errorGenerics.ArgumentNames);
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
        public readonly struct {{genericName}} : {{genericName}}.Base{{errorGenerics.ConstraintsString}}
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
        Generic.Elements convertFrom,
        string either,
        string constructorName,
        string typeName,
        bool convertFromSuccess
    )
    {
        var operators = string.Join("\n", convertFrom.Value
            .Select(x => $"public static implicit operator {typeName}({x.Name} value) => new (value);"));

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

