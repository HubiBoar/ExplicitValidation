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
    ValidationError? Validate(string? propertyName = null);
}

public interface IIsValid<TValue> : IIsValid
{
    public TValue Value { get; }

    abstract static void Rule(Rule<TValue> rule);
}

public readonly struct ValidationError : IError<ValidationError. ArgumentException>
{
    public readonly record struct Property
    (
        ImmutableArray<string> Messages
    )
    : IError
    {
        public override string ToString() => Formatting.ValidationError(this);
    };

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

public static class Rule
{
    public static Rule<TValue> Get<TValue>()
    {
        return new Rule<TValue>();
    }
}

public static class Exx
{
    public record Class(Value Value1, Value Value2)
    {
        public ValidationError? Validate(string? propertyName = null)
        {
            var name = propertyName is null ? "Class" : propertyName; 

            if(Value1.Validate("Value1").IsError(out var error0))
            {
                if(Value2.Validate("Value2").IsError(out var error1))
                {
                    return new ValidationError(name, [error0.Value, error1.Value]);
                }
                
                return new ValidationError(name, [error0.Value]);
            }

            return null;
        }
    }

    public record Value(string Val)
    {
        public ValidationError? Validate(string? propertyName = null)
        {
            return new Rule<string>().Validate(Val, propertyName ?? "Value");
        }
    }
}
