using System.Text;
using Definit.Results;

[assembly: GenerateUnion.Object(typeof(StringBuilder))]
[assembly: GenerateUnion.Object<StringReader>]
[assembly: GenerateUnion.Object(typeof(List<>))]
[assembly: GenerateUnion.Object<Task<string>>]
[assembly: GenerateUnion.Object<Definit.Resultss.Examples.Examples>]

namespace Definit.Resultss.Examples;

[GenerateUnion]
public partial struct ResultExample<T> : Definit.Results.U<T, NotFound>.Base
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
    public ResultExample2<int> PublicRun(int i)
    {
        return string.Empty;
    }

    private ResultExample2<int> PrivateRun(int i)
    {
        return string.Empty;
    }

    private U PrivateRun2(string t)
    {
        return Union.Success;
    }

    private U<string, NotFound> PrivateRun(string t)
    {
        return t;
    }

    private static Task<U<T, NotFound>> PublicRun<T>(T t)
        where T : struct, IError<T>
    {
        return Task.FromResult<U<T, NotFound>>(t);
    }
}
