using System.Text;
using Definit.Results;

//[assembly: GenerateUnion.Object(typeof(StringBuilder))]
//[assembly: GenerateUnion.Object<StringReader>]
//[assembly: GenerateUnion.Object(typeof(List<>))]
//[assembly: GenerateUnion.Object<Task<string>>]
//[assembly: GenerateUnion.Object<Definit.Resultss.Examples.Examples>]

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

//[GenerateUnion.This]
public partial class Examples
{
    public ResultExample2<int> PublicRun(int i, StringReader reader)
    {
        //var (str, notFound, u, exception) = this.Try().PublicRun(i, reader);
        return string.Empty;
    }

    private ResultExample2<int> PrivateRun(int i)
    {
        return string.Empty;
    }

    private R PrivateRun2(string t)
    {
        return R.Success;
    }

    private R<string, NotFound> PrivateRun(string t)
    {
        //var (str, notFound, exception) = this.Try().PrivateRun(t);
        return t;
    }

    private static Task<U<T, NotFound>> PublicRun<T>(T t)
        where T : struct, IError<T>
    {
        return Task.FromResult<U<T, NotFound>>(t);
    }
}
