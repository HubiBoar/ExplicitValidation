using System.Text;
using Definit.Results;

[assembly: Union.Try(typeof(StringBuilder))]
[assembly: Union.Try<StringReader>]
[assembly: Union.Try(typeof(List<>))]
[assembly: Union.Try<Task<string>>]
[assembly: Union.Try(typeof(Definit.Resultss.Examples.Examples<,>))]

namespace Definit.Resultss.Examples;

[Union]
public partial struct ResultExample<T> : U<T, NotFound>.Base
    where T : notnull;

[Union]
public partial struct ResultExample2<T> : U<T, string, NotFound>.Base
    where T : notnull;

[Union]
public partial struct EitherExample2<T> : U<T, string, int>.Base
    where T : notnull;

public readonly record struct NotFound(ErrorPayload Payload) : IError<NotFound>;

[Union.Try.This]
public partial class Examples
{
    public static ResultExample2<int> PublicRun(int i, StringReader reader)
    {
        //var (str, notFound, u, exception) = this.Try().PublicRun(i, reader);
        return string.Empty;
    }

    public ResultExample2<int> PrivateRun(int i)
    {
        return string.Empty;
    }

    public static void PrivateRun2(string t)
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

public static class Test<T0>
    where T0 : notnull
{
    public static ResultExample2<int> PublicRun(int i, StringReader reader)
    {
        //var (str, notFound, u, exception) = this.Try().PublicRun(i, reader);
        return Examples<T0>.PublicRun(i, reader);
    }
}

[Union.Try.This]
public partial class Examples<T0>
    where T0 : notnull
{
    public static ResultExample2<int> PublicRun(int i, StringReader reader)
    {
        //var (str, notFound, u, exception) = this.Try().PublicRun(i, reader);
        return string.Empty;
    }

    public ResultExample2<int> PrivateRun(int i)
    {
        return string.Empty;
    }

    public static void PrivateRun2<T1>(string t)
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

public partial class Examples<T0, T1>
    where T0 : notnull
{
    public async Task<ResultExample2<int>> PublicRun(int i, StringReader reader)
    {
        return await (await this.Try().PublicRun(i, reader)).Match<ResultExample2<int>>
        (
            async (_, i) => await GetInt(i),
            str => str,
            async (_, notFound) => await GetInt(50),
            ex => new NotFound(),
            ex => new NotFound()
        );

        static Task<int> GetInt(int i)
        {
            return Task.FromResult<int>(i);
        }
    }

    public ResultExample2<int> PrivateRun(int i)
    {
        return string.Empty;
    }

    public static void PrivateRun2<T2>(string t)
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
