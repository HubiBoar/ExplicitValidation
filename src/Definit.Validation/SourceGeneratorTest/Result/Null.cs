
namespace Definit.Results.NewApproach;

public static class NullExtensions
{
    public static void Deconstruct<T>(this IsNull<T>? isNull, out T? t, out Null? nul)
        where T : struct
    {
        if(isNull is null)
        {
            t = null;
            nul = null;
            return;
        }

        (var t_, nul) = isNull.Value.Value;
        t = t_ is null ? null : t_.Value;
    }

    public static void Deconstruct<T>(this IsNull<T> isNull, out T? t, out Null? nul)
        where T : struct
    {
        (var t_, nul) = isNull.Value;
    
        t = t_ is null ? null : t_.Value;
    }

    public static void Deconstruct<T>(this IsNull<T> isNull, out T? t, out Null? nul)
        where T : class
    {
        (var t_, nul) = isNull.Value;
    
        t = t_ is null ? null : t_.Value;
    }

    public static void Deconstruct<T>(this IsNull<T>? isNull, out T? t, out Null? nul)
        where T : class
    {
        if(isNull is null)
        {
            t = null;
            nul = null;
            return;
        }

        (var t_, nul) = isNull.Value.Value;

        t = t_ is null ? null : t_.Value;
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

    public static IsNull<T> IsNull<T>(this T? t)
        where T : struct
    {
        if(t is null)
        {
            return NewApproach.IsNull<T>.Null;
        }

        return NewApproach.IsNull<T>.Create(t.Value);
    }

    public static IsNull<T> IsNull<T>(this T t)
    {
        return NewApproach.IsNull<T>.Create(t);
    }
}

public readonly struct NotNull<T>
{
    public T Value { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public NotNull() => throw new DefaultConstructorException();

    private NotNull(T value) => Value = value;

    public static implicit operator T(NotNull<T> value) => value.Value;

    public static IsNull<T> IsNull(T? value) =>
        value is null
        ? 
        new IsNull<T>(Result.Null)
        : 
        new IsNull<T>(new NotNull<T>(value));
}

public readonly struct IsNull<T>
{
    public Either<NotNull<T>, Null> Value { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public IsNull() => throw new DefaultConstructorException();

    public IsNull(Either<NotNull<T>, Null> value) => Value = value;

    public static IsNull<T> Create(T? value) => NotNull<T>.IsNull(value); 
    public static IsNull<T> Null { get; }= new (Result.Null); 
}
