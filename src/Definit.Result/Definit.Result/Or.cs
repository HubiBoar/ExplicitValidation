using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Or<T>
    where T : notnull
{
    public T Out { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Or() => throw new DefaultConstructorException();

    public Or(T value) => Out = value;

    public static implicit operator Or<T>([DisallowNull] T value) => new(value);
}

public static class Opt
{
    public static Null Null { get; } = new Null();

    public static Opt<T> Create<T>([MaybeNull] T? value) => new Opt<T>(value);
}

public readonly struct Opt<T>
{
    public static Opt<T> Null { get; } = Opt.Null;

    private T? Value { get; } 
    private bool Exists { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Opt() => throw new DefaultConstructorException();

    public Opt([MaybeNull] T? value) { Value = value; Exists = true; }
    public Opt(Null nu) { Value = default!; Exists = false; }

    public static implicit operator Opt<T>([MaybeNull] T? value) => new(value);
    public static implicit operator Opt<T>(Null value) => new(value);
    
    public static void Deconstruct<T0>(Opt<T0> maybe, out T0? value, out Null? nul)
        where T0 : class?
    {
        if(maybe.Exists)
        {
            value = maybe.Value;
            nul = maybe.Value is null ? Opt.Null : null;
            return;
        }

        value = null;
        nul = Opt.Null;
    }

    public static void Deconstruct<T0>(Opt<T0> maybe, out T0? value, out Null? nul)
        where T0 : struct
    {
        if(maybe.Exists)
        {
            value = maybe.Value;
            nul = null;
            return;
        }

        value = null;
        nul = Opt.Null;
    }

    public static void Deconstruct<T0>(Opt<T0?> maybe, out T0? value, out Null? nul)
        where T0 : struct
    {
        if(maybe.Exists)
        {
            value = maybe.Value;
            nul = maybe.Value is null ? Opt.Null : null;
            return;
        }

        value = null;
        nul = Opt.Null;
    }
}

public readonly struct Null
{
    public static implicit operator bool (Null nul) => true;
    public static implicit operator bool (Null? nul) => nul is null;
}

public static class MaybeExtensions
{
    public static void Deconstruct<T>(this Opt<T?> maybe, out T? value, out Null? nul)
        where T : struct
    {
        Opt<T?>.Deconstruct<T>(maybe, out value, out nul); 
    }

    public static void Deconstruct<T>(this Opt<T> maybe, out T? value, out Null? nul)
        where T : struct
    {
        Opt<T>.Deconstruct<T>(maybe, out value, out nul); 
    }

    public static void Deconstruct<T>(this Opt<T> maybe, out T? value, out Null? nul)
        where T : class?
    {
        Opt<T>.Deconstruct<T>(maybe, out value, out nul); 
    }

    public static void Deconstruct<T>(this Opt<T?>? maybe, out T? value, out Null? nul)
        where T : struct
    {
        if(maybe is null)
        {
            value = null;
            nul = null;
            return;
        }

        Opt<T>.Deconstruct<T>(maybe.Value, out value, out nul); 
    }

    public static void Deconstruct<T>(this Opt<T>? maybe, out T? value, out Null? nul)
        where T : struct
    {
        if(maybe is null)
        {
            value = null;
            nul = null;
            return;
        }

        Opt<T>.Deconstruct<T>(maybe.Value, out value, out nul); 
    }

    public static void Deconstruct<T>(this Opt<T>? maybe, out T? value, out Null? nul)
        where T : class?
    {
        if(maybe is null)
        {
            value = null;
            nul = null;
            return;
        }

        Opt<T>.Deconstruct<T>(maybe.Value, out value, out nul); 
    }

    public static void Deconstruct<T>(this Or<Opt<T?>>? or, out T? value, out Null? nul)
        where T : struct
    {
        if(or is null)
        {
            value = null;
            nul = null;
            return;
        }
        Opt<T?>.Deconstruct<T>(or.Value.Out, out value, out nul); 
    }

    public static void Deconstruct<T>(this Or<Opt<T>>? or, out T? value, out Null? nul)
        where T : struct
    {
        if(or is null)
        {
            value = null;
            nul = null;
            return;
        }

        Opt<T>.Deconstruct<T>(or.Value.Out, out value, out nul); 
    }

    public static void Deconstruct<T>(this Or<Opt<T>>? or, out T? value, out Null? nul)
        where T : class?
    {
        if(or is null)
        {
            value = null;
            nul = null;
            return;
        }
        Opt<T>.Deconstruct<T>(or.Value.Out, out value, out nul); 
    }
}
