namespace Definit.Results.NewApproach3;

public interface IEither;

public interface IEither<T0, T1> : IEither
    where T0 : notnull
    where T1 : notnull;

public interface IEither<T0, T1, T2> : IEither
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull;

public interface IEither<T0, T1, T2, T3> : IEither
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull;

public interface IError<TSelf>
    where TSelf : struct, IError<TSelf>
{
    public abstract static (bool Matches, TSelf Error) TryMatch(Exception exception);
}

public readonly struct Success;
public readonly record struct Error(Exception Exception) : IError<Error>
{
    public static (bool Matches, Error Error) TryMatch(Exception exception)
    {
        return (true, new Error(exception));
    }
}

public interface IResult<TEither>
    where TEither : struct, IEither
{
    internal TEither Either { get; }

    internal static abstract TEither FromException(Exception exception);
}

public readonly struct Result : IResult<Either<Success, Error>>
{
    Either<Success, Error> IResult<Either<Success, Error>>.Either => throw new NotImplementedException();

    static Either<Success, Error> IResult<Either<Success, Error>>.FromException(Exception exception)
    {
        throw new NotImplementedException();
    }



    public readonly struct Or<TError> : IResult<Either<Success, TError>>
        where TError : struct, IError<TError>
    {
        Either<Success, TError> IResult<Either<Success, TError>>.Either => throw new NotImplementedException();

        static Either<Success, TError> IResult<Either<Success, TError>>.FromException(Exception exception)
        {
            throw new NotImplementedException();
        }
    }



    public readonly struct Or<TError0, TError1> : IResult<Either<Success, TError0>>
        where TError0 : struct, IError<TError0>
        where TError1 : struct, IError<TError1>
    {
        Either<Success, TError0> IResult<Either<Success, TError0>>.Either => throw new NotImplementedException();

        static Either<Success, TError0> IResult<Either<Success, TError0>>.FromException(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}

public readonly struct Result<T> : IResult<Either<T, Error>>
    where T : notnull
{
    Either<T, Error> IResult<Either<T, Error>>.Either => throw new NotImplementedException();

    static Either<T, Error> IResult<Either<T, Error>>.FromException(Exception exception)
    {
        throw new NotImplementedException();
    }


    public readonly struct Error<TError> : IResult<Either<T, TError>>
        where TError : struct, IError<TError>
    {
        Either<T, TError> IResult<Either<T, TError>>.Either => throw new NotImplementedException();

        static Either<T, TError> IResult<Either<T, TError>>.FromException(Exception exception)
        {
            throw new NotImplementedException();
        }
    }



    public readonly struct Error<TError0, TError1> : IResult<Either<T, TError0, TError1>>
        where TError0 : struct, IError<TError0>
        where TError1 : struct, IError<TError1>
    {
        Either<T, TError0, TError1> IResult<Either<T, TError0, TError1>>.Either => throw new NotImplementedException();

        static Either<T, TError0, TError1> IResult<Either<T, TError0, TError1>>.FromException(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}

public readonly struct Result<T0, T1> : IResult<Either<T0, T1, Error>>
    where T0 : notnull
    where T1 : notnull
{
    Either<T0, T1, Error> IResult<Either<T0, T1, Error>>.Either => throw new NotImplementedException();

    static Either<T0, T1, Error> IResult<Either<T0, T1, Error>>.FromException(Exception exception)
    {
        throw new NotImplementedException();
    }


    public readonly struct Error<TError> : IResult<Either<T0, T1, TError>>
        where TError : struct, IError<TError>
    {
        Either<T0, T1, TError> IResult<Either<T0, T1, TError>>.Either => throw new NotImplementedException();

        static Either<T0, T1, TError> IResult<Either<T0, T1, TError>>.FromException(Exception exception)
        {
            throw new NotImplementedException();
        }
    }


    public readonly struct Error<TError0, TError1> : IResult<Either<T0, T1, TError0, TError1>>
        where TError0 : struct, IError<TError0>
        where TError1 : struct, IError<TError1>
    {
        Either<T0, T1, TError0, TError1> IResult<Either<T0, T1, TError0, TError1>>.Either => throw new NotImplementedException();

        static Either<T0, T1, TError0, TError1> IResult<Either<T0, T1, TError0, TError1>>.FromException(Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}

public readonly struct Either<T0, T1> : IEither<T0, T1>
    where T0 : notnull
    where T1 : notnull
{
}

public readonly struct Either<T0, T1, T2> : IEither<T0, T1, T2>
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull
{
}

public readonly struct Either<T0, T1, T2, T3> : IEither<T0, T1, T2, T3>
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
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
    public static void Deconstruct<T0, T1, T2, T3>
    (
        this Either<T0, T1, T2, T3> error,
        out IsNull<T0>? t0,
        out IsNull<T1>? t1,
        out T2? t2,
        out T3? t3
    )
        where T0 : class
        where T1 : class
        where T2 : struct
        where T3 : struct
    {
        t0 = null; t1 = null; t2 = null; t3 = null;
    }

    public static void Deconstruct<T>(this IsNull<T>? isNull, out T? value, out Null? nul)
        where T : class
    {
        value = null; nul = null;
    }

    public static TEither GetEither<TResult, TEither>(this TResult result)
        where TResult : struct, IResult<TEither>
        where TEither : struct, IEither
    {
        return result.Either;
    }

    public static TEither FromException<TResult, TEither>(Exception exception)
        where TResult : struct, IResult<TEither>
        where TEither : struct, IEither
    {
        return TResult.FromException(exception);
    }
}


//User Specified
public partial struct NotFound : IError<NotFound>;

public partial struct ValidationError : IError<ValidationError>;

public static partial class Test
{
    private static Result<Stream, string>.Error<NotFound, ValidationError> _Run()
    {
        throw new NotImplementedException(); 
    }

    public static void Running()
    {
        var ((stream, nullStream), (str, nullStr), notFound, validationError) = Run();
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

public static partial class Test
{
    public static Either<Stream, string, NotFound, ValidationError> Run()
    {
        try
        {
            return _Run().GetEither<Result<Stream, string>.Error<NotFound, ValidationError>, Either<Stream, string, NotFound, ValidationError>>(); 
        }
        catch(Exception ex)
        {
            return Extensions.FromException<Result<Stream, string>.Error<NotFound,ValidationError>, Either<Stream, string, NotFound, ValidationError>>(ex); 
        }
    }
}
