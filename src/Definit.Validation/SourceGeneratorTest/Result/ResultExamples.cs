using System.Text;
using Definit.Results.NewApproach;

[module: GenerateResult.Object(typeof(StringBuilder))]
[module: GenerateResult.Object<StringReader>]
[module: GenerateResult.Object(typeof(List<>))]
[module: GenerateResult.Object<List<string>>]

namespace Definit.Results.NewApproach;

public partial class Examples
{
    public readonly record struct NotFound(Either<KeyNotFoundException, Exception> Exception)
        : IError<NotFound, KeyNotFoundException>;

    private static int Get(string str)
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
