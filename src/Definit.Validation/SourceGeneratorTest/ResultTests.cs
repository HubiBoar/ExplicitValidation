using System.Diagnostics.CodeAnalysis;
using static Definit.NewApproach.Result;

namespace Definit.NewApproach;

file static class Test
{
    private static int Run()
    {
        var (str, error) = Try(NewResult);

        if(error is not null)
        {
            var (e, ex) = error.Value;
            return 0;
        }

        (var i, str, error) = Try(() => NewResult2(str!));

        if(error is not null)
        {
            return 0;
        }

        if(i is not null)
        {
            return i.Value;
        }

        var s = str!;

        return 1;
    }

    private static Result<string, int> NewResult() 
    {
        return new Exception(""); 
    }

    private static Result<int, string> NewResult2(string str) 
    {
        return 5;
    }
}

file static class Result
{
    public static (Null<T0>?, Enum<T1, Exception>?) Try<T0, T1>(Func<Result<T0, T1>> match)
    {
        try
        {
            var (t0, t1) = match().Value;

            return new Enum<T0, Enum<T1, Exception>>((t0, new Enum<T1, Exception>((t1, null)))).Value;
        }
        catch(Exception ex)
        {
            return (null, ex);
        }
    }

    public static (Null<T0>?, Enum<T1, T2, Exception>?) Try<T0, T1, T2>(Func<Result<T0, T1, T2>> match)
    {
        try
        {
            var (t0, t1) = match().Value;

            return (t0, t1);
        }
        catch(Exception ex)
        {
            return (null, ex);
        }
    }
}

public record struct Null<T>(T Value)
{
    public static implicit operator T(Null<T> value) => value.Value;
    public static implicit operator Null<T>(T value) => new (value);
}

public record struct Result<T0, T1>
{
    internal (Null<T0>?, Null<T1>?) Value { get; }
    
    private Result(T0 value)
    {
        Value = (value, null);
    }

    private Result(T1 value)
    {
        Value = (null, value);
    }

    public static implicit operator Result<T0, T1>([DisallowNull] T0 value) => new (value);
    public static implicit operator Result<T0, T1>([DisallowNull] T1 value) => new (value);
}

public record struct Result<T0, T1, T2>
{
    internal (Null<T0>?, Enum<T1, T2>?) Value { get; }
    
    private Result(T0 value)
    {
        Value = (value, null);
    }

    private Result([DisallowNull] T1 value)
    {
        Value = (null, value);
    }

    private Result([DisallowNull] T2 value)
    {
        Value = (null, value);
    }

    public static implicit operator Result<T0, T1, T2>([DisallowNull] T0 value) => new (value);
    public static implicit operator Result<T0, T1, T2>([DisallowNull] T1 value) => new (value);
    public static implicit operator Result<T0, T1, T2>([DisallowNull] T2 value) => new (value);
}

public record struct Enum<T0, T1>
{
    public (Null<T0>?, Null<T1>?) Value { get; }
    
    public Enum(T0 value)
    {
        Value = (value, null);
    }

    public Enum(T1 value)
    {
        Value = (null, value);
    }

    internal Enum((Null<T0>?, Null<T1>?) value)
    {
        Value = value;
    }

    public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1) => (t0, t1) = Value;

    public static implicit operator Enum<T0, T1>([DisallowNull] T0 value) => new (value);
    public static implicit operator Enum<T0, T1>([DisallowNull] T1 value) => new (value);
}

public record struct Enum<T0, T1, T2>
{
    public (Null<T0>?, Null<T1>?, Null<T2>?) Value { get; }
    
    public Enum(T0 value)
    {
        Value = (value, null, null);
    }

    public Enum(T1 value)
    {
        Value = (null, value, null);
    }

    public Enum(T2 value)
    {
        Value = (null, null, value);
    }

    internal Enum((Null<T0>?, Null<T1>?, Null<T2>?) value)
    {
        Value = value;
    }

    public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1, out Null<T2>? t2) => (t0, t1, t2) = Value;

    public static implicit operator Enum<T0, T1, T2>([DisallowNull] Enum<T0, T1> value) => new ((value.Value.Item1, value.Value.Item2, null));
    public static implicit operator Enum<T0, T1, T2>([DisallowNull] Enum<T1, T0> value) => new ((value.Value.Item2, value.Value.Item1, null));
    public static implicit operator Enum<T0, T1, T2>([DisallowNull] T0 value) => new (value);
    public static implicit operator Enum<T0, T1, T2>([DisallowNull] T1 value) => new (value);
    public static implicit operator Enum<T0, T1, T2>([DisallowNull] T2 value) => new (value);
}
