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

public static class Maybe
{
    public static Null Null { get; } = new Null();
}

public readonly struct Maybe<T>
{
    private T Value { get; } 
    private bool Exists { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Maybe() => throw new DefaultConstructorException();

    public Maybe(T value) { Value = value; Exists = true; }
    public Maybe(Null nu) { Value = default!; Exists = false; }

    public static implicit operator Maybe<T>(T value) => new(value);
    public static implicit operator Maybe<T>(Null value) => new(value);
    
    public static void Deconstruct<T0>(Maybe<T0> maybe, out T0? value, out Null? nul)
        where T0 : class
    {
        if(maybe.Exists)
        {
            value = maybe.Value;
            nul = null;
            return;
        }

        value = null;
        nul = Maybe.Null;
    }

    public static void Deconstruct<T0>(Maybe<T0> maybe, out T0? value, out Null? nul)
        where T0 : struct
    {
        if(maybe.Exists)
        {
            value = maybe.Value;
            nul = null;
            return;
        }

        value = null;
        nul = Maybe.Null;
    }
}

public readonly struct Null
{
    public static implicit operator bool (Null nul) => true;
    public static implicit operator bool (Null? nul) => nul is null;
}

public static class MaybeExtensions
{
    public static void Deconstruct<T>(this Maybe<T> maybe, out T? value, out Null? nul)
        where T : class
    {
        Maybe<T>.Deconstruct<T>(maybe, out value, out nul); 
    }

    public static void Deconstruct<T>(this Maybe<T> maybe, out T? value, out Null? nul)
        where T : struct
    {
        Maybe<T>.Deconstruct<T>(maybe, out value, out nul); 
    }

    public static void Deconstruct<T>(this Maybe<T>? maybe, out T? value, out Null? nul)
        where T : struct
    {
        if(maybe is null)
        {
            value = null;
            nul = null;
            return;
        }

        Maybe<T>.Deconstruct<T>(maybe.Value, out value, out nul); 
    }

    public static void Deconstruct<T>(this Maybe<T>? maybe, out T? value, out Null? nul)
        where T : class
    {
        if(maybe is null)
        {
            value = null;
            nul = null;
            return;
        }

        Maybe<T>.Deconstruct<T>(maybe.Value, out value, out nul); 
    }
}
