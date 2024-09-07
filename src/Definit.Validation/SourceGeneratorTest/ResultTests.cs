using System.Diagnostics.CodeAnalysis;
using static Definit.NewApproach.Result;

namespace Definit.NewApproach;

file static partial class Test
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

    private static partial Result<string, NotFound> NewResult(Public _)  
    {
        var (j, not) = NewResult("test");

        if(j is null) return new NotFound(); 

        return j.Value.ToString();
    } 

    private static Result<int, Not> NewResult(Private _, string str)  
    {

        return str;
    } 

    //Auto generated
    public static Either<string, Either<NotFound, Not>> NewResult()  
    {
        try
        {
            return NewResult(new ()).Value;
        }
        catch(Exception ex)
        {
            return NotFound.Create(ex); 
        }
    } 
    //
    //Auto generated
    public static Either<int, Not> NewResult(string str)  
    {
        try
        {
            return NewResult(new (), str).Value;
        }
        catch(Exception ex)
        {
            return Not.Create(ex); 
        }
    } 
}

public interface IError<TSelf>
    where TSelf : IError<TSelf>
{
    public abstract static TSelf Create(Exception exception); 
}

public readonly struct NotFound() : IError<NotFound>
{
    public static NotFound Create(Exception exception) => new NotFound();
}


public readonly struct Not() : IError<Not>
{
    public static Not Create(Exception exception) => new Not();
}

public readonly record struct Error<T0, T1>(Either<T0, T1> Value) : IError<Error<T0, T1>>
    where T0 : IError<T0>
    where T1 : IError<T1>
{
    public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1) => (t0, t1) = Value;

    public static Error<T0, T1> Create(Exception exception)
    {
        return new (T0.Create(exception));
    }

    public static implicit operator Error<T0, T1>([DisallowNull] T0 value) => new (value);
    public static implicit operator Error<T0, T1>([DisallowNull] T1 value) => new (value);
    public static implicit operator Error<T0, T1>([DisallowNull] Null<T0> value) => new (value);
    public static implicit operator Error<T0, T1>([DisallowNull] Null<T1> value) => new (value);
    public static implicit operator Error<T0, T1>([DisallowNull] Null<T0>? value) => new (value!.Value);
    public static implicit operator Error<T0, T1>([DisallowNull] Null<T1>? value) => new (value!.Value);
}

public static class Result
{
    public readonly struct Public;
    public readonly struct Private;

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
}

public static class Extensions
{
    public static void Deconstruct<T0, T1>(this Null<Either<T0, T1>> value, out Null<T0>? t0, out Null<T1>? t1)
    {
        (t0, t1) = value.Value;
    }
}

public record struct Null<T>(T Value)
{
    public static implicit operator T(Null<T> value) => value.Value;
    public static implicit operator Null<T>(T value) => new (value);
}

public readonly struct Result<T0, T1>
    where T1 : IError<T1>
{
    internal Either<T0, T1> Value { get; }

    internal Result(Either<T0, T1> value)
    {
        Value = value;
    }

    public static implicit operator Result<T0, T1>([DisallowNull] Result.NullError value) => new (value);
    public static implicit operator Result<T0, T1>([DisallowNull] T0 value) => new (value);
    public static implicit operator Result<T0, T1>([DisallowNull] T1 value) => new (value);
    public static implicit operator Result<T0, T1>([DisallowNull] Null<T0> value) => new (value);
    public static implicit operator Result<T0, T1>([DisallowNull] Null<T1> value) => new (value);
    public static implicit operator Result<T0, T1>([DisallowNull] Null<T0>? value) => new (value!.Value);
    public static implicit operator Result<T0, T1>([DisallowNull] Null<T1>? value) => new (value!.Value);
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
