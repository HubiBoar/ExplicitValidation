using System.Collections.Immutable;
using Definit.Results;
using Definit.Utils;

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
public sealed class IsValidAttribute<TValue> : Attribute
    where TValue : notnull
{
}

public interface IIsValid
{
    U<ValidationError> Validate(string? propertyName = null);
}

public interface IIsValid<TValue> : IIsValid
{
    abstract static void Rule(Rule<TValue> rule);
}

public interface IIsValid<TValue, TValid> : IIsValid
    where TValue: notnull
    where TValid: IValid<TValue>
{
    U<TValid, ValidationError> IsValid(string? propertyName = null);

    public abstract static U<TValid, ValidationError> Create(TValue value, string? propertyName = null);

    public abstract static TValue Parse(string json);
}

public interface IValid<TValue>
    where TValue: notnull
{
    public TValue Value { get; }
}

public interface IValidationError
{
    public ValidationError ToValidationError();
}

public readonly struct ValidationError : IError<ValidationError>
{
    public readonly record struct Property
    (
        string Name,
        ImmutableArray<string> Messages
    )
    : IError<ValidationError.Property>
    {
        public ErrorPayload Payload { get; init; }

        public override string ToString() => Formatting.ValidationError(this);
    };

    public ErrorPayload Payload { get; init; }

    public ImmutableArray<ValidationError.Property> Errors { get; }

    public ValidationError(string propertyName, string error)
    {
        var property = new Property(propertyName, [error]);
        Errors = [ property ]; 
    }

    public ValidationError(ImmutableArray<ValidationError.Property> errors)
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

    public static ValidationError Exception(Exception exception)
    {
        return new ValidationError($"Exception: {exception.GetType()}", exception.Message); 
    }

    public static ValidationError Null<T>(string propertyName)
    {
        return new ValidationError($"{DefinitType.GetTypeVerboseName<T>()}::{propertyName}", "Value is Null"); 
    }

    private static ImmutableArray<ValidationError.Property> Create
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

        var props = new ValidationError.Property[errorsCount];
        for(int i = 0; i < errors.Length; i++)
        {
            var error = errors[i];
            for(int a = 0; a < error.Errors.Length; a++)
            {
                var property = error.Errors[a];
                props[i + a] = new ValidationError.Property($"{propertyName}{property.Name}", property.Messages);
            }
        }

        return ImmutableArray.Create(props);
    }

    public override string ToString() => Formatting.ValidationError(this);
}

public static class RuleExtensions0
{
    public static U<ValidationError> ToResult<T>(this U<T, ValidationError> result)
        where T : struct
    {
        var (_, error) = result;

        if (error is not null)
        {
            return error.Value;
        }

        return U.Success;
    }
}

public static class RuleExtensions1
{
    public static U<ValidationError> ToResult<T>(this U<T, ValidationError> result)
        where T : class
    {
        var (_, error) = result;

        if (error is not null)
        {
            return error.Value;
        }

        return U.Success;
    }
}

public static class Exx
{
    public record Class(Value Value1, Value Value2)
    {
        public U<ValidationError> Validate(string? propertyName = null)
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

            return U.Success;
        }
    }

    public record Value(string Val)
    {
        public U<ValidationError> Validate(string? propertyName = null)
        {
            return new Rule<string>().Validate(Val, propertyName ?? "Value");
        }
    }
}
