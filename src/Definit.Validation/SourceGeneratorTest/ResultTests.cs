using System.Diagnostics.CodeAnalysis;
using static Definit.NewApproach.Result;

namespace Definit.NewApproach;

file static class Test
{
    private static int Run()
    {
        var (str, error) = NewResult();

        var (notFound, ex) = error.Value; 
        if(error is not null)
        {
            (notFound, ex) = error.Value;
            return 0;
        }

        (var i, var not, ex) = NewResult(str!);

        if(error is not null)
        {
            return 0;
        }

        if(str is not null)
        {
            return 5;
        }

        var str2 = NewResult().Match(i => "", ex => "");

        return 1;
    }

    public static Result<string, NotFound> NewResult() => Try<string, NotFound>(c =>  
    {
        var (j, not) = NewResult("test");

        if(j is null) return new NotFound(); 

        return j.ToString();
    },
    ex => new NotFound());

    public static Result<int, Not> NewResult(string value) => Try<int, Not>(c =>  
    {
        var i = NewResult().Match(c, notFound => new Not());
        return 0;
    },
    ex => new Not());
}

public interface IError<TSelf>
    where TSelf : IError<TSelf>
{
    public TSelf Create(Exception exception); 
}

public readonly struct NotFound();
public readonly struct Not();

public static class Result
{
    public sealed record NullError();

    public static readonly NullError Null = new (); 

    public sealed class ForwardException<T> : Exception
    {
        [NotNull]
        public T Value { get; }

        internal ForwardException([DisallowNull] T value)
        {
            Value = value;
        }
    }

    private static ForwardException<T> ForwardEx<T>([DisallowNull] T value) => new (value); 

    public static Result<T0, T1> Try<T0, T1>
    (
        Func<Context<T0, T1>, Either<T0, T1>> func,
        Func<Exception, Either<T0, T1>> onException
    )
    {
        try
        {
            return new (func(Context<T0,T1>.Instance));
        }
        catch (ForwardException<T0> forwardT0)
        {
            return new (forwardT0.Value);
        }
        catch (ForwardException<T1> forwardT1)
        {
            return new (forwardT1.Value);
        }
        catch (Exception ex)
        {
            return new (onException(ex));
        }
    }

    public sealed class Context<TC0, TC1>
    { 
        internal static readonly Context<TC0, TC1> Instance = new ();

        private Context()
        {
        }

        internal T0 Match<T0, T1>(Result<T0, T1> result, Func<T1, TC0> func)
        {
            return result.Match(t0 => throw ForwardEx(func(t0)!));  
        }

        internal T0 Match<T0, T1>(Result<T0, T1> result, Func<T1, TC1> func)
        {
            return result.Match(t0 => throw ForwardEx(func(t0)!));  
        }
    }
}

public static class Extensions
{
    public static void Deconstruct<T0, T1>(this Null<Either<T0, T1>> value, out Null<T0>? t0, out Null<T1>? t1)
    {
        (t0, t1) = value.Value;
    }

    public static T0 Forward<T0, T1>(this Result<T0, T1> value, Result.Context<T1,T0> context)  
    {
        return context.Match(value, v => v, e => e);
    }

    public static T0 Forward<T0, T1>(this Result<T0, T1> value, Result.Context<T0,T1> context)  
    {
        return context.Match(value, v => v, e => e);
    }

    public static T0 Forward<T0, T1, TC0, TC1>(this Result<T0, T1> value, Result.Context<TC0,TC1> context, Func<T1, TC0> func)  
    {
        return context.Match(value, func, e => e);
    }

    public static T0 Match<T0, T1, TC0, TC1>(this Result<T0, T1> value, Result.Context<TC0,TC1> context, Func<T1, TC1> func)  
    {
        return context.Match(value, func, e => e);
    }
}

public sealed record Null<T>(T Value)
{
    public static implicit operator T(Null<T> value) => value.Value;
    public static implicit operator Null<T>(T value) => new (value);
}

public sealed class Result<T0, T1>
    where T1 : IError<T1>
{
    public Either<T0, T1> Value { get; }

    internal Result(Either<T0, T1> value)
    {
        Value = value;
    }

    public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1) => (t0, t1) = Value;

    public T0 Match(Func<T1, T0> func1)
    {
    }

    public TResult Match<TResult>(Func<T0, TResult> func0, Func<T1, TResult> func)
    {
    }
}

public record struct Either<T0, T1>
{
    public (Null<T0>?, Null<T1>?) Value { get; }
    
    public Either(T0 value)
    {
        Value = (value, null);
    }

    public Either(T1 value)
    {
        Value = (null, value);
    }

    internal Either((Null<T0>?, Null<T1>?) value)
    {
        Value = value;
    }

    public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1) => (t0, t1) = Value;

    public static implicit operator Either<T0, T1>([DisallowNull] Result.NullError value) => new (value);
    public static implicit operator Either<T0, T1>([DisallowNull] T0 value) => new (value);
    public static implicit operator Either<T0, T1>([DisallowNull] T1 value) => new (value);
    public static implicit operator Either<T0, T1>([DisallowNull] Null<T0> value) => new (value);
    public static implicit operator Either<T0, T1>([DisallowNull] Null<T1> value) => new (value);
    public static implicit operator Either<T0, T1>([DisallowNull] Null<T0>? value) => new (value!.Value);
    public static implicit operator Either<T0, T1>([DisallowNull] Null<T1>? value) => new (value!.Value);
}
