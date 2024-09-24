using System.Text;
using Definit.Results;

//[assembly: GenerateEither.Base(10)]
//[assembly: GenerateResult.Base(5, 5)]
[assembly: GenerateResult.Object(typeof(StringBuilder))]
[assembly: GenerateResult.Object<StringReader>]
[assembly: GenerateResult.Object(typeof(List<>))]
[assembly: GenerateResult.Object<Task<string>>]

namespace Definit.Resultss.Examples;

[GenerateResult]
public partial struct ResultExample<T> : Result<T>.Error<NotFound>.Base
    where T : notnull;

[GenerateResult]
public partial struct ResultExample2<T> : Result<T, string>.Error<NotFound>.Base
    where T : notnull;

[GenerateEither]
public partial struct EitherExample2<T> : Either<T, string, int>.Base
    where T : notnull;

public readonly record struct NotFound() : IError<NotFound, KeyNotFoundException>;

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

    private static Either<string, int> GetEither()
    {
        return default!;
    }

    private static string GetString()
    {
        return default!;
    }

    [GenerateResult.Method.Private]
    private ResultExample2<int> _PrivateRun(int i)
    {
        return "";
    }

    [GenerateResult.Method.Private]
    private Result _PrivateRun2(string t)
    {
        return Result.Success;
    }

    [GenerateResult.Method.Private]
    private Result<string>.Error<NotFound> _PrivateRun(string t)
    {
        var result = GetResultExample2();

        var ((str, isNull), error) = Result.Try(GetString);

        ((str, isNull), var i) = GetEither();

        if(str is null)
        {
            return new NotFound();
        }

        (i, error) = Result.Try(() => Get(str));

        if(i is not null)
        {
            return i.Value.Out.ToString();
        }

        return t;
    }

    [GenerateResult.Method.Public]
    private static Task<Result<T>.Error<NotFound>> _PublicRun<T>(T t)
        where T : struct, IError<T>, IError
    {
        return Task.FromResult<Result<T>.Error<NotFound>>(t);
    }
}
