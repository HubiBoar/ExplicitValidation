using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Or<T>
    where T : notnull
{
    public T Out { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Or() => throw new DefaultConstructorException();

    public Or(T value) => Out = value;

    public static implicit operator T(Or<T> value) => value.Out;
    public static implicit operator Or<T>([DisallowNull] T value) => new(value);
    public static implicit operator T([DisallowNull] Or<T>? value) => value.Value.Out;   
}
