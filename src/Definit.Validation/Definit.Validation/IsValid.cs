using System.Collections.Immutable;

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
    ValidationErrors? Validate();
}

public interface IIsValid<TValue> : IIsValid
{
    public TValue Value { get; }

    abstract static void Rule(Rule<TValue> rule);
}

public readonly record struct ValidationErrors
(
    ImmutableArray<(string Property, ValidationErrors.Property Errors)> Errors
)
{
    public readonly record struct Property
    (
        ImmutableArray<(string Rule, string Message)> Errors
    ); 
}

public static class Rule
{
    public static Rule<TValue> Get<TValue>()
    {
        return new Rule<TValue>();
    }
}

