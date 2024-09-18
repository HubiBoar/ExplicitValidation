namespace Definit.Results.NewApproach2;

public interface IError<TSelf>
    where TSelf : struct, IError<TSelf>
{
    public abstract static (bool Matches, TSelf Error) TryMatch(Exception exception);
}

public readonly struct Error<T0, T1> : IError<Error<T0, T1>>
    where T0 : struct, IError<T0>
    where T1 : struct, IError<T1>
{
    public static (bool Matches, Error<T0, T1> Error) TryMatch(Exception exception)
    {
        throw new NotImplementedException();
    }
}
public readonly struct Error<T0, T1, T2> : IError<Error<T0, T1, T2>>
    where T0 : struct, IError<T0>
    where T1 : struct, IError<T1>
    where T2 : struct, IError<T2>
{
    public static (bool Matches, Error<T0, T1, T2> Error) TryMatch(Exception exception)
    {
        throw new NotImplementedException();
    }
}

public interface IResult<TValue, TError>
    where TValue : notnull
    where TError : struct, IError<TError>
{
}

public readonly struct Result<TValue, TError> : IResult<TValue, TError>
    where TValue : notnull
    where TError : struct, IError<TError>
{

}

public readonly struct Either<T0, T1>
    where T0 : notnull
    where T1 : notnull
{
}

public readonly struct Either<T0, T1, T2>
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull
{
}

public readonly struct Null;

public readonly struct IsNull<T>
    where T : class
{
    public void Deconstruct(out T? value, out Null? nul)
    {
        value = null; nul = null;
    }
}

public static class Extensions
{
    public static void Deconstruct<T0, T1>(this Error<T0, T1>? error, out T0? t0, out T1? t1)
        where T0 : struct, IError<T0>
        where T1 : struct, IError<T1>
    {
        t0 = null; t1 = null;
    }

    public static void Deconstruct<T0, T1>(this Either<T0, T1>? error, out IsNull<T0>? t0, out IsNull<T1>? t1)
        where T0 : class
        where T1 : class
    {
        t0 = null; t1 = null;
    }

    public static void Deconstruct<T0, T1>(this Either<T0, T1> error, out T0? t0, out T1? t1)
        where T0 : struct
        where T1 : struct
    {
        t0 = null; t1 = null;
    }

    public static void Deconstruct<T>(this IsNull<T>? isNull, out T? value, out Null? nul)
        where T : class
    {
        value = null; nul = null;
    }
}


//User Specified
public partial struct NotFound : IError<NotFound>;

public partial struct ValidationError : IError<ValidationError>;

public partial struct ResultExample<T> : IResult<Either<T, string>, Error<NotFound, ValidationError>>
    where T : notnull;

public static partial class Test
{
    private static ResultExample<Stream> _Run()
    {
        return new NotFound();
    }

    public static void Running()
    {
        var ((stream, nullStream), (str, nullStr), notFound, validationError) = Run();
        ((stream, nullStream), (str, nullStr), (notFound, validationError)) = Run();
        (((stream, nullStream), (str, nullStr)), (notFound, validationError)) = Run();
    }
}



//Auto generated
readonly partial struct NotFound
{
    public static (bool Matches, NotFound Error) TryMatch(Exception exception)
    {
        throw new NotImplementedException();
    }
}

readonly partial struct ValidationError
{
    public static (bool Matches, ValidationError Error) TryMatch(Exception exception)
    {
        throw new NotImplementedException();
    }
}

public partial struct ResultExample<T>
{
    internal Either<Either<T, string>, Error<NotFound, ValidationError>> Either => throw new NotImplementedException();

    public static implicit operator ResultExample<T>(Either<T, string> value) => throw new NotImplementedException();
    public static implicit operator ResultExample<T>(Error<NotFound, ValidationError> value) => throw new NotImplementedException();
    public static implicit operator ResultExample<T>(T value) => throw new NotImplementedException();
    public static implicit operator ResultExample<T>(string value) => throw new NotImplementedException();
    public static implicit operator ResultExample<T>(NotFound value) => throw new NotImplementedException();
    public static implicit operator ResultExample<T>(ValidationError value) => throw new NotImplementedException();
}

public static partial class Test
{
    public static Either<Either<Stream, string>, Error<NotFound, ValidationError>> Run()
    {
        return _Run().Either;
    }
}
public static class EitherExtensions
{
    public static void Deconstruct<T>
    (
        this Either<Either<T, string>, Error<NotFound, ValidationError>> value,
        out IsNull<T>? t0,
        out IsNull<string>? t1,
        out Error<NotFound, ValidationError>? t2
    )
        where T : class
    {
        t0 = null; t1 = null; t2 = null;
    }

    public static void Deconstruct<T>
    (
        this Either<Either<T, string>, Error<NotFound, ValidationError>> value,
        out IsNull<T>? t0,
        out IsNull<string>? t1,
        out NotFound? t2,
        out ValidationError? t3
    )
        where T : class
    {
        t0 = null; t1 = null; t2 = null; t3 = null;
    }

    public static void Deconstruct<T>
    (
        this Either<Either<T, string>, Error<NotFound, ValidationError>> value,
        out T? t0,
        out IsNull<string>? t1,
        out Error<NotFound, ValidationError>? t2
    )
        where T : struct
    {
        t0 = null; t1 = null; t2 = null;
    }

    public static void Deconstruct<T>
    (
        this Either<Either<T, string>, Error<NotFound, ValidationError>> value,
        out T? t0,
        out IsNull<string>? t1,
        out NotFound? t2,
        out ValidationError? t3
    )
        where T : struct
    {
        t0 = null; t1 = null; t2 = null; t3 = null;
    }
}
