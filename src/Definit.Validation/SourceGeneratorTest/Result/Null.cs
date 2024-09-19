using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.NewApproach;

public static class NullExtensions
{
    public static void Deconstruct<T>(this IsNull<T>? isNull, out T? t, out Null? nul)
        where T : class
    {
        t = null;
        nul = null;

        if(isNull is not null)
        {
            (t, nul) = isNull.Value;
        }
    }

    public static IsNull<T>? IsNull<T>(this Or<T>? value)
        where T : class
    {
        if(value is null)
        {
            return null;
        }

        return NewApproach.IsNull<T>.Create(value.Value.Value);
    }

    public static IsNull<T> IsNull<T>([MaybeNull] this T? t)
        where T : class
    {
        return NewApproach.IsNull<T>.Create(t);
    }
}

public readonly struct NotNull<T>
    where T : class
{
    public T Value { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public NotNull() => throw new DefaultConstructorException();

    private NotNull(T value) => Value = value;

    public static implicit operator T(NotNull<T> value) => value.Value;

    public static IsNull<T> IsNull([MaybeNull] T? value) =>
        value is null
        ? 
        new IsNull<T>(Result.Null)
        : 
        new IsNull<T>(new NotNull<T>(value));
}

public readonly struct IsNull<T>
    where T : class
{
    public Either<NotNull<T>, Null> Value { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public IsNull() => throw new DefaultConstructorException();

    public IsNull(Either<NotNull<T>, Null> value) => Value = value;

    public void Deconstruct(out T? t, out Null? nul)
    {
        (var t_0, nul) = Value.Value;
        t = t_0?.Value;
    }

    public static IsNull<T> Create([MaybeNull] T? value) => NotNull<T>.IsNull(value); 
}
