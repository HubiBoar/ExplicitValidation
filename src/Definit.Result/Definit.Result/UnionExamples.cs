using System.Text;
using Definit.Results;

[assembly: GenerateUnion.Try(typeof(StringBuilder))]
[assembly: GenerateUnion.Try<StringReader>]
[assembly: GenerateUnion.Try(typeof(List<>))]
[assembly: GenerateUnion.Try<Task<string>>]

namespace Definit.Resultss.Examples;

[GenerateUnion]
public partial struct ResultExample<T> : U<T, NotFound>.Base
    where T : notnull;

[GenerateUnion]
public partial struct ResultExample2<T> : U<T, string, NotFound>.Base
    where T : notnull;

[GenerateUnion]
public partial struct EitherExample2<T> : U<T, string, int>.Base
    where T : notnull;

public readonly record struct NotFound(ErrorPayload Payload) : IError<NotFound>;

[GenerateUnion.Try.This]
public partial class Examples
{
    public ResultExample2<int> PublicRun(int i, StringReader reader)
    {
        //var (str, notFound, u, exception) = this.Try().PublicRun(i, reader);
        return string.Empty;
    }

    public ResultExample2<int> PrivateRun(int i)
    {
        return string.Empty;
    }

    public void PrivateRun2(string t)
    {
        return;
    }

    public U<string, Exception, NotFound> PrivateRun(string t)
    {
        //var (str, notFound, exception) = this.Try().PrivateRun(t);
        return t;
    }

    public Task<U<T, NotFound>> PublicRun<T>(T t)
        where T : struct, IError<T>
    {
        return Task.FromResult<U<T, NotFound>>(t);
    }
}
