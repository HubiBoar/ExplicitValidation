using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.NewApproach;

public readonly struct Or<T>
    where T : notnull
{
    public T Value { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Or() => throw new DefaultConstructorException();

    public Or(T value) => Value = value;

    public static implicit operator T(Or<T> value) => value.Value;
    public static implicit operator Or<T>(T value) => new(value);
}

public sealed class DefaultConstructorException : Exception
{
    public const string Attribute = "Dont use parameterless constructor";
}

public readonly struct EitherMatchError;
public sealed class EitherMatchException<T>() : Exception;

public readonly struct Success;
public readonly struct Null;

public static class Either
{
    public static readonly Success Success = new ();
    public static readonly Null Null = new (); 
    public static readonly EitherMatchError MatchError = new (); 

    public static Either<Success, Error> Try(Action func) 
    {
        try
        {
            func();
            return ResultHelper.ToReturn<Result<Success, Error>, Either<Success, Error>>(Success);
        }
        catch (Exception exception)
        {
            return ResultHelper.ToReturn<Result<Success, Error>, Either<Success, Error>>(exception);
        }
    }

    public static Either<T, Error> Try<T>(Func<T> func)
        where T : notnull
    {
        try
        {
            return ResultHelper.ToReturn<Result<T, Error>, Either<T, Error>>(func());
        }
        catch (Exception exception)
        {
            return ResultHelper.ToReturn<Result<T, Error>, Either<T, Error>>(exception);
        }
    }
}
