using System.Text;
using Definit.Results;

[assembly: GenerateResult.Object(typeof(StringBuilder))]
[assembly: GenerateResult.Object<StringReader>]
[assembly: GenerateResult.Object(typeof(List<>))]
[assembly: GenerateResult.Object<Task<string>>]
[assembly: GenerateResult.Object<Definit.Resultss.Examples.Examples>]

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
    public ResultExample2<int> PublicRun(int i)
    {
        return string.Empty;
    }

    [GenerateResult.Method.Private]
    private ResultExample2<int> _PrivateRun(int i)
    {
        return string.Empty;
    }

    [GenerateResult.Method.Private]
    private Result _PrivateRun2(string t)
    {
        return Result.Success;
    }

    [GenerateResult.Method.Private]
    private Result<string>.Error<NotFound> _PrivateRun(string t)
    {
        return t;
    }

    [GenerateResult.Method.Public]
    private static Task<Result<T>.Error<NotFound>> _PublicRun<T>(T t)
        where T : struct, IError<T>, IError
    {
        return Task.FromResult<Result<T>.Error<NotFound>>(t);
    }
}
