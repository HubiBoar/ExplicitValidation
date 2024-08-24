using Definit.Results;
using Error = Definit.Results.Error;

namespace Definit.Validation;

public sealed class IsValid<T>
    where T : IValidate
{
    public Result<Valid<T>> Result { get; }

    public IsValid(T validate)
    {
        if(validate.Validate().Is(out Error error))
        {
            Result = error;
        }
        else
        {
            Result = new Valid<T>(validate);
        }
    }

    private IsValid(Error error)
    {
        Result = error;
    }

    public static implicit operator IsValid<T>(Error error) => new IsValid<T>(error);
    public static implicit operator IsValid<T>(T validate)  => new IsValid<T>(validate);
}

public sealed class Valid<T>
    where T : IValidate
{
    public T Value { get; }

    internal Valid(T value)
    {
        Value = value;
    }
}

