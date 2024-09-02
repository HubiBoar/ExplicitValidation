using Definit.Results;

namespace NewApproach;

public interface IIsValid
{
    Result Validate();
}

public readonly struct Valid<T>
    where T : IIsValid
{
    public T Value { get; }

    internal Valid(T value)
    {
        Value = value;
    }

    public static Result<Valid<T>> IsValid(T value)
    {
        if(value.Validate().Is(out Error error))
        {
            return error;
        }

        return new Valid<T>(value);
    }

    public static implicit operator T(Valid<T> value) => value.Value;
}

public static class ValidExtensions
{
    public static Result<Valid<T>> IsValid<T>(this T value)
        where T : IIsValid
    { 
        return Valid<T>.IsValid(value);
    }
}

public sealed record Validator(Result Result)
{
    public Validator NotNull => this;

    public Validator Min(int size) => this;
}    

public abstract record IsValid<TValue>(Validator Validator)
    : IIsValid
{
    public required TValue Value { get; init; }

    public Result Validate()
    {
        return Validator.Result;
    }

    protected static Validator Rule => new Validator(Result.Success);
}



//Example

public partial record ValueTest() : IsValid<string>(Rule.NotNull);



//Auto generated
sealed partial record ValueTest
{
    public static implicit operator ValueTest(string value) => new ValueTest
    {
        Value = value,
    };
    
    public static implicit operator string(ValueTest value) => value.Value;
}

