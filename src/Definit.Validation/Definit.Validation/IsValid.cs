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
    Result Validate();
}

public interface IIsValid<TValue> : IIsValid
{
    public TValue Value { get; }

    abstract static void Rule(Rule<TValue> rule);
}
