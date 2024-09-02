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

public readonly record struct Rule<TValue>(TValue Value)
{
    public bool IsSuccess { get; init; }
    public string ErrorMessage { get; init; }
}

public static class RuleExtensions
{
    public static Rule<TValue> NotNull<TValue>(this Rule<TValue> rule)
    {
        return rule;
    }

    public static Rule<string> Min(this Rule<string> rule)
    {
        return rule;
    }
}

public interface IIsValid<TValue> : IIsValid
{
    public TValue Value { get; }

    protected void Rule(Rule<TValue> rule);

    protected static Result DefaultValidate(IIsValid<TValue> valid)
    {
        var rule = new Rule<TValue>(valid.Value);

        valid.Rule(rule);

        if(rule.IsSuccess)
        {
            return Result.Success;
        }

        return new Error(rule.ErrorMessage);
    }
}



//Example



//Auto generated
//partial struct Email
//{
//    public string Value { get; }
//
//    public Email(string value)
//    {
//        Value = value;
//    }
//
//    public static implicit operator Email(string value) => new (value);
//    
//    public static implicit operator string(Email value) => value.Value;
//}
