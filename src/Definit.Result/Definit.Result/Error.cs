using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public interface IError<TSelf, TException> : IError<TSelf>
    where TSelf : struct, IError<TSelf, TException>
    where TException : notnull, Exception
{
    public new Error Error { get; init; }

    static (bool Matches, TSelf Error) IError<TSelf>.Matches(Exception exception)
    {
        var (matches, error) = exception.Matches<TException>();

        return (matches, new TSelf()
        {
            Error = exception
        }); 
    }
}

public interface IError
{
}

public interface IError<TSelf> : IError
    where TSelf : struct, IError<TSelf>
{
    public Error Error { get; }
    public string Context { get; init; }

    public abstract static (bool Matches, TSelf Error) Matches(Exception exception); 
}

public readonly record struct Err<T>(string Context, Error Error) : IError<Err<T>, T>
    where T : Exception;

public readonly record struct Error(string Message, string StackTrace) : IError<Error>, IEitherBase
{
    public Error(Exception exception) : this(exception.Message, exception.StackTrace ?? Environment.StackTrace) {} 
    public Error(string message) : this(message, Environment.StackTrace) {} 
    public Error(string prefix, Error error) : this($"{prefix} :: {error.Message}", error.StackTrace) {}

    Error IError<Error>.Error => this;
    public string Context { get; init; } = string.Empty;

    public static Error FromError(Error error) => error;

    public static (bool Matches, Error Error) Matches(Exception exception) => (true, exception);

    public static implicit operator Error(Exception ex) => new Error(ex);
}

public static class ErrorExtensions
{
    public static bool IsError<T>(this T? value, [NotNullWhen(true)] out T? val)
        where T : struct, IError
    {
        val = value;
        return value is not null;
    }

    public static (bool Matches, Either<T, Exception> Either) Matches<T>(this Exception exception)
        where T : Exception
    {
        if(exception is T match)
        {
            return (true, match);
        }

        return (false, exception);
    }

    public static Error GetError<TError>(this TError error)
        where TError : struct, IError<TError>
    {
        return error.Error; 
    }

    public static TError WithContext<TError>(this TError error, string context)
        where TError : struct, IError<TError>
    {
        var previousContext = error.Context;
        return error with { Context = $"{context} :: {previousContext}" };
    }
}

public static class ErrorHelper
{
    public static (bool Matches, T Error) Matches<T>(Exception exception)
        where T : struct, IError<T>
    {
        return T.Matches(exception);
    }
}
