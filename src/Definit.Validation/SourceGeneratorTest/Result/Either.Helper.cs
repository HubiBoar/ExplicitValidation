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
