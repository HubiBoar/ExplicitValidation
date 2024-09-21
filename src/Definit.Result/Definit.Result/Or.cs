using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Or<T>
{
    public T Out { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Or() => throw new DefaultConstructorException();

    public Or(T value) => Out = value;

    public static implicit operator T(Or<T> value) => value.Out;
    public static implicit operator Or<T>([DisallowNull] T value) => new(value);
    public static implicit operator T([DisallowNull] Or<T>? value) => value.Value.Out;   
}


public static class OrExtensions
{
    public static T? GetValue<T>(this Or<T?> o)
        where T : struct
    {
        return o.Out;
    }

    public static T? GetValue<T>(this Or<T?>? o)
        where T : struct
    {
        return o is null ? null : o.Value.Out;
    }

    public static T? GetValue<T>(this Or<T>? o)
        where T : struct
    {
        return o is null ? null : o.Value.Out;
    }

    public static void Deconstruct<T>(this Or<T?>? o, out Or<T>? t, out bool isNull)
        where T : struct
    {
        if(o is null)
        {
            t = null; isNull = true;
            return;
        }

        t = o.Value.Out is null ? null : o.Value.Out.Value;
        isNull = t is null;

    }

    public static void Deconstruct<T>(this Or<T?> o, out Or<T>? t, out bool isNull)
        where T : struct
    {
        t = o.Out is null ? null : o.Out.Value;
        isNull = t is null;
    }

    public static void Deconstruct<T>(this Or<T>? o, out T? t, out bool isNull)
        where T : class?
    {
        if(o is null)
        {
            t = null; isNull = true;
            return;
        }

        t = o.Value.Out is null ? null : o.Value.Out;
        isNull = t is null;
    }

    public static void Deconstruct<T>(this Or<T> o, out T? t, out bool isNull)
        where T : class?
    {
        t = o.Out is null ? null : o.Out;
        isNull = t is null;
    }
}

public static class OrExtensions2
{
    public static T? GetValue<T>(this Or<T>? o)
        where T : class?
    {
        return o is null ? null : o.Value.Out;
    }
}
