namespace Definit.Results;

public interface IError<TSelf, TException> : IError<TSelf>
    where TSelf : struct, IError<TSelf, TException>
    where TException : notnull, Exception
{
    public Either<TException, Exception> Exception { get; init; }

    static (bool Matches, TSelf Error) IError<TSelf>.Matches(Exception exception)
    {
        var (matches, error) = exception.Matches<TException>();
        return (matches, new TSelf() { Exception = error }); 
    }
}

public interface IError<TSelf>
    where TSelf : notnull, IError<TSelf>
{
    public abstract static (bool Matches, TSelf Error) Matches(Exception exception); 
}

public readonly record struct Error<T>(Either<T, Exception> Exception) : IError<Error<T>, T>
    where T : Exception;

public readonly record struct Error(Exception Exception) : IError<Error>
{
    public static (bool Matches, Error Error) Matches(Exception exception) => (true, new Error(exception)); 
}

public static class ErrorExtensions
{
    public static (bool Matches, Either<T, Exception> Either) Matches<T>(this Exception exception)
        where T : Exception
    {
        if(exception is T match)
        {
            return (true, match);
        }
        
        return (false, exception);
    }
}

public static class ErrorHelper
{
    public static (bool Matches, T Error) Matches<T>(Exception exception)
        where T : notnull, IError<T>
    {
        return T.Matches(exception);
    }
}
