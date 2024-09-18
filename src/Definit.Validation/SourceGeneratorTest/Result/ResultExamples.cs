using System.Text;
using Definit.Results.NewApproach;

[assembly: GenerateResult.Object(typeof(StringBuilder))]
[assembly: GenerateResult.Object<StringReader>]
[assembly: GenerateResult.Object(typeof(List<>))]
[assembly: GenerateResult.Object<List<string>>]

namespace Definit.Results.Examples;

[GenerateResult]
public partial struct ResultExample<T> : IResult<T, NotFound>
    where T : notnull;

[GenerateResult]
public partial struct ResultExample2<T> : IResult<Either<T, string>, NotFound>
    where T : notnull;

//[GenerateEither]
//public partial struct EitherExample2<T> : IEither<Either<T, string>, Either<int, string>>
//    where T : notnull;

public readonly record struct NotFound(Either<KeyNotFoundException, Exception> Exception)
    : IError<NotFound, KeyNotFoundException>;

public partial class Examples
{
    private static int Get(string str)
    {
        ErrorHelper.Matches<NotFound>(new Exception());
        return default!;
    }

    private static ResultExample2<string> GetResultExample2()
    {
        return default!;
    }

    private static IsNull<string> GetNull()
    {
        return default!;
    }

    private static Either<string, int> GetEither()
    {
        return default!;
    }

    private static string GetString()
    {
        return default!;
    }

    [GenerateResult.Method.Private]
    private Result<string, NotFound> _PrivateRun(string t)
    {
        var result = GetResultExample2();

        var ((str, strNotNull), (str2, str2NotNull), notFound) = ResultHelper
            .ToReturn<ResultExample2<string>, Either<Either<string, string>, NotFound>>(result);

        if(str is null)
        {

        }

        //var ((str, isNull), error) = Result.Try(GetString);

        //((str, isNull), var i) = GetEither();

        //if(str is null)
        //{
        //    return new NotFound();
        //}

        //(i, error) = Result.Try(() => Get(str));
        //if(i is not null)
        //{
        //    return i.Value.ToString();
        //}

        return t;
    }

    [GenerateResult.Method.Public]
    private static Task<Result<T, NotFound>> _PublicRun<T>(T t)
        where T : IError<T>
    {
        return Task.FromResult<Result<T, NotFound>>(t);
    }
}

public static class Extension
{
    public static void Deconstruct<T0>
    (
        this Either<Either<T0, string>, NotFound> result,
        out IsNull<T0>? t0,
        out IsNull<string>? t1,
        out NotFound? t2
    )
        where T0 : class
    {
        if(result is null)
        {
            t0 = null;
            return;
        }

        var (t_0, t_1, t_2) = result.Value.Value;

        t0 = t_0;
        t1 = t_1;
        t2 = t_2;
    }

    public static void Deconstruct<T0>
    (
        this Either<Either<T0, string>, NotFound> result,
        out T0? t0,
        out IsNull<string>? t1,
        out NotFound? t2
    )
        where T0 : struct
    {
        if(result is null)
        {
            t0 = null;
            return;
        }

        var (t_0, t_1, t_2) = result.Value.Value;

        t0 = t_0;
        t1 = t_1;
        t2 = t_2;
    }
}
