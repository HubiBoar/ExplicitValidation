using System.Collections.Immutable;
using Definit.Results;

namespace Definit.Validation;

[System.AttributeUsage
(
    System.AttributeTargets.Class |
    System.AttributeTargets.Struct,
    AllowMultiple = false
)]
public sealed class IsValidAttribute : Attribute
{
}

[System.AttributeUsage
(
    System.AttributeTargets.Struct,
    AllowMultiple = false
)]
public sealed class IsValidAttribute<T> : Attribute
{
}

public interface IIsValid
{
    R<ValidationError> Validate(string? propertyName = null);
}

public interface IIsValid<TValue, TValid> : IIsValid
    where TValid: notnull
{
    public TValue Value { get; }

    abstract static void Rule(Rule<TValue> rule);

    U<TValid, ValidationError> IsValid(string? propertyName = null);
}

public readonly struct ValidationError : IError<ValidationError>
{
    public readonly record struct Property
    (
        ImmutableArray<string> Messages
    )
    : IError<ValidationError.Property>
    {
        public ErrorPayload Payload { get; init; }

        public override string ToString() => Formatting.ValidationError(this);
    };

    public ErrorPayload Payload { get; init; }

    public ImmutableArray<(string Property, ValidationError.Property Value)> Errors { get; }

    public ValidationError(ImmutableArray<(string Property, ValidationError.Property Value)> errors)
    {
        Errors = errors;
    }

    public ValidationError(string propertyName, ImmutableArray<ValidationError> errors)
    {
        Errors = Create($"{propertyName}.", errors);
    }

    public ValidationError(ImmutableArray<ValidationError> errors)
    {
        Errors = Create(string.Empty, errors);
    }

    private static ImmutableArray<(string Property, ValidationError.Property Value)> Create
    (
        string propertyName, 
        ImmutableArray<ValidationError> errors
    )
    {
        int errorsCount = errors.Length;
        for(int i = 0; i < errors.Length; i++)
        {
            errorsCount += errors[i].Errors.Length;
        }

        var props = new (string, ValidationError.Property)[errorsCount];
        for(int i = 0; i < errors.Length; i++)
        {
            var error = errors[i];
            for(int a = 0; a < error.Errors.Length; a++)
            {
                var property = error.Errors[a];
                props[i + a] = ($"{propertyName}{property.Property}", property.Value);
            }
        }

        return ImmutableArray.Create(props);
    }

    public override string ToString() => Formatting.ValidationError(this);
}

public static class RuleExtensions0
{
    public static R<ValidationError> ToResult<T>(this U<T, ValidationError> result)
        where T : struct
    {
        var (_, error) = result;

        if (error is not null)
        {
            return error.Value;
        }

        return R.Success;
    }
}

public static class RuleExtensions1
{
    public static R<ValidationError> ToResult<T>(this U<T, ValidationError> result)
        where T : class
    {
        var (_, error) = result;

        if (error is not null)
        {
            return error.Value;
        }

        return R.Success;
    }
}

public static class Exx
{
    public record Class(Value Value1, Value Value2)
    {
        public R<ValidationError> Validate(string? propertyName = null)
        {
            var name = propertyName is null ? "Class" : propertyName; 

            var (_, error0) = Value1.Validate("Value1");

            if(error0 is not null)
            {
                var (_, error1) = Value1.Validate("Value1");

                if(error1 is not null)
                {
                    return new ValidationError(name, [error0.Value, error1.Value]);
                }
                
                return new ValidationError(name, [error0.Value]);
            }

            return R.Success;
        }
    }

    public record Value(string Val)
    {
        public R<ValidationError> Validate(string? propertyName = null)
        {
            return new Rule<string>().Validate(Val, propertyName ?? "Value");
        }
    }
}
