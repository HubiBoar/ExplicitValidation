using Definit.Results;
using Error = Definit.Results.Error;

namespace Definit.Validation;

public sealed class IsValid<T>
{
    public Result<Valid<T>> Result { get; }

    public IsValid(T value, Func<T, Result> validationMethod)
    {
        if(validationMethod(value).Is(out Error error))
        {
            Result = error;
        }
        else
        {
            Result = new Valid<T>(value);
        }
    }

    private IsValid(Error error)
    {
        Result = error;
    }

    public static implicit operator IsValid<T>(Error error) => new IsValid<T>(error);
}

public sealed class Valid<T>
{
    public T Value { get; }

    internal Valid(T value)
    {
        Value = value;
    }
}

