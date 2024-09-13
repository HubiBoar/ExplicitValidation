using System.Text;
using Definit.Results.NewApproach;

[module: GenerateObject(typeof(StringBuilder))]
[module: GenerateObject<StringReader>]
[module: GenerateObject(typeof(List<>))]
[module: GenerateObject<List<string>>]

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

    [GenerateMethod.Private]
    private Result<string, NotFound> _PrivateRun(string t)
    {
        var ((str, isNull), error) = Result.Try(GetString);

        ((str, isNull), var i) = GetEither();

        if(str is null)
        {
            return new NotFound();
        }

        (i, error) = Result.Try(() => Get(str));
        if(i is not null)
        {
            return i.Value.ToString();
        }

        return t;
    }

    [GenerateMethod.Public]
    private static Task<Result<T, NotFound>> _PublicRun<T>(T t)
        where T : IError<T>
    {
        return Task.FromResult<Result<T, NotFound>>(t);
    }
}
