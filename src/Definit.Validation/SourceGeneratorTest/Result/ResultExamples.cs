using System.Text;
using Definit.Results.NewApproach;

//[assembly: GenerateResult.Base(4)]
//[assembly: GenerateEither.Base(8)]
[assembly: GenerateResult.Object(typeof(StringBuilder))]
[assembly: GenerateResult.Object<StringReader>]
[assembly: GenerateResult.Object(typeof(List<>))]
[assembly: GenerateResult.Object<List<string>>]

namespace Definit.Resultss.Examples;

[GenerateResult]
public partial struct ResultExample<T> : Result<T>.Error<NotFound>.Base
    where T : notnull;

[GenerateResult]
public partial struct ResultExample2<T> : Result<T, string>.Error<NotFound>.Base
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
    private Result<string>.Error<NotFound> _PrivateRun(string t)
    {
        var result = GetResultExample2();

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
    private static Task<Result<T>.Error<NotFound>> _PublicRun<T>(T t)
        where T : IError<T>
    {
        return Task.FromResult<Result<T>.Error<NotFound>>(t);
    }
}
