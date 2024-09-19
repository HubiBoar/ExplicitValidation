
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.NewApproach;

public static class NullExtensions
{
    public struct Either1<T0, T1>;

    public static void Deconstruct<T0, T1>(this Either1<T0, T1> either, out T0? t0, out T1? t1)
        where T0: struct
        where T1: struct
    {
        t0 = null; t1 = null;
    }

    public static void Deconstruct<T0, T1>(this Either1<T0?, T1?> either, out IsNull<T0>? t0, out IsNull<T1>? t1)
        where T0: struct
        where T1: struct
    {
        t0 = null; t1 = null;
    }

    public static void Deconstruct<T0, T1>(this Either1<T0, T1> either, out IsNull<T0>? t0, out IsNull<T1>? t1)
        where T0 : class
        where T1 : class
    {
        t0 = null; t1 = null;
    }

    public static class Test
    {
        private static Either1<string, string> StringTest() => throw new Exception();
        private static Either1<string?, string?> StringNullableTest() => throw new Exception();
        private static Either1<int?, int?> IntNullableTest() => throw new Exception();
        private static Either1<int, int> IntTest() => throw new Exception();

        private static void Run()
        {
            var ((str1, str1Null), (str2, str2Null)) = StringTest();
            var ((str3, str3Null), (str4, str4Null)) = StringNullableTest();
            var (int1, int2) = IntTest();
            var ((int3, int3Null), (int4, int4Null)) = IntNullableTest();
        }
    }

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

        int? str = 5;
        str.IsNull();
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

    public static IsNull<T> IsNull<T>(this T? t)
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
