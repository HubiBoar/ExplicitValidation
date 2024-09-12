using System.Diagnostics.CodeAnalysis;
using static Definit.Results.NewApproach.Result;
using static Definit.Results.NewApproach.Result.Normal;

namespace Definit.Results.NewApproach;

public partial class Test
{
    public readonly struct NotFound() : IError<NotFound>
    {
        public static bool Matches(Exception exception, out NotFound notFound)
        {
            notFound = new NotFound();
            return exception is FileNotFoundException; 
        }
    }

    public readonly struct Error<T>() : IError<Error<T>>
        where T : Exception
    {
        public required Exception Exception { get; init; }

        public static bool Matches(Exception exception, out Error<T> error)
        {
            error = new Error<T>() { Exception = exception };
            return exception is T; 
        }
    }

    private static int GetInt()
    {
        return default!;
    }

    private static string GetString()
    {
        return null!;
    }

    private static void Run(string s)
    {

    }

    private Result<int, NotFound> PrivateRun(int t) 
    {
        return 5;
    }

    private Result<string, NotFound> PrivateRun(string t)
    {
        var (i, error) = TryCatch(GetInt);
        (var str, var isNull, error) = TryCatch(GetString);

        (str, isNull, var notFound) = Result.Try(() => PrivateRun("run"));
        (i, var notFound2) = Result.Try(() => PrivateRun(1));

        if(str is not null)
        {
            Run(str);        
        }

        return t;
    }

    public static Task<Result<T, NotFound>> PublicRun<T>(T t)
        where T : notnull
    {
        return Task.FromResult<Result<T, NotFound>>(t);
    }
}

[System.AttributeUsage(System.AttributeTargets.Struct, AllowMultiple = false)]
public sealed class GenerateEitherAttribute : Attribute;

[System.AttributeUsage(System.AttributeTargets.Struct, AllowMultiple = false)]
public sealed class GenerateResultAttribute : Attribute;

[System.AttributeUsage(System.AttributeTargets.Struct, AllowMultiple = false)]
internal sealed class GenerateBaseEitherAttribute : Attribute;

[System.AttributeUsage(System.AttributeTargets.Struct, AllowMultiple = false)]
internal sealed class GenerateBaseResultAttribute : Attribute;

public readonly struct Success;
public readonly struct ResultMatchError;
public readonly struct Null
{
    public static Either<T, Null> IsNull<T>([MaybeNull] T? t)
        where T : class
    {
        if(t is null)
        {
            return Result.Null;
        }
        
        return t;
    }
}

public sealed class ResultMatchException<T>() : Exception;

public static class Result
{
    public static readonly Success Success = new ();
    public static readonly Null Null = new (); 
    public static readonly ResultMatchError MatchError = new (); 

    public static void Deconstruct<T0, T1>
    (
        this Try<Result<T0, T1>> ret,
        out Out<T0>? t0, 
        out Out<Null>? tNull, 
        out Out<T1>? t1
    )
        where T0: class
        where T1: struct, IError<T1>
    {
        t0 = null;
        tNull = null;
        t1 = null;
        var (result, exception) = ret.Result;
        
        if(exception is not null)
        {
            T1.Matches(exception, out var error);
            t1 = error;
            return;
        }
        
        var (t_0, t_1) = result!.Value.Value.Either.Value;
        if(t_0 is not null)
        {
            (t0, tNull) = Null.IsNull(t_0.Value.Value).Value;
        }
    }

    public static void Deconstruct<T0, T1>
    (
        this Try<Result<T0, T1>> ret,
        out Out<T0>? t0,
        out Out<T1>? t1
    )
        where T0: struct
        where T1: struct, IError<T1>
    {
        t0 = null;
        t1 = null;
        var (result, exception) = ret.Result;
        
        if(exception is not null)
        {
            T1.Matches(exception, out var error);
            t1 = error;
            return;
        }
        
        (t0, t1) = result!.Value.Value.Either.Value;
    }

    public static void Deconstruct<T>
    (
        this Either<T, Exception> ret,
        out Out<T>? t0,
        out Out<Null>? tNull, 
        out Out<Exception>? t1
    )
        where T: class
    {
        t0 = null;
        tNull = null;
        t1 = null;
        (var result, t1) = ret.Value;

        if(result is not null)
        {
            (t0, tNull) = Null.IsNull(result.Value.Value).Value;
        }
    }

    public static void Deconstruct<T>
    (
        this Either<T, Exception> ret,
        out Out<T>? t0,
        out Out<Exception>? t1
    )
        where T: struct
    {
        (t0, t1) = ret.Value;
    }

    public static Try<T> Try<T>(Func<T> func)
        where T : IResult
    {
        try
        {
            return new Try<T>() { Result = func() };
        }
        catch (Exception exception)
        {
            return new Try<T>() { Result = exception };
        }
    }
    
    public static Either<Success, Exception> TryCatch(Action func) 
    {
        try
        {
            func();
            return Success;
        }
        catch (Exception exception)
        {
            return exception;
        }
    }

    public static Either<T, Exception> TryCatch<T>(Func<T> func)
        where T : notnull
    {
        try
        {
            return func();
        }
        catch (Exception exception)
        {
            return exception;
        }
    }
}

public readonly struct Out<T>
    where T : notnull
{
    public required T Value { get; init; }

    public static implicit operator T(Out<T> value) => value.Value;
    public static implicit operator Out<T>(T value) => new() { Value = value };
}

public interface IError<TSelf>
    where TSelf : struct, IError<TSelf>
{
    public abstract static bool Matches(Exception exception, out TSelf self); 
}

[GenerateBaseEither]
public partial struct Either<T0, T1>;

[GenerateBaseEither]
public partial struct Either<T0, T1, T2>; 

[GenerateBaseEither]
public partial struct Either<T0, T1, T2, T3>; 


[GenerateBaseResult]
public partial struct Result<TError>;

[GenerateBaseResult]
public partial struct Result<T0, TError>;

[GenerateBaseResult]
public partial struct Result<T0, TError0, TError1>; 

//AutoGenerated
readonly partial struct Either<T0, T1>
    where T0 : notnull
    where T1 : notnull
{
    public (Out<T0>?, Out<T1>?) Value { get; }

    [Obsolete("Dont use parameterless constructor", true)]
    public Either() {}

    public Either(T0 value) => Value = (value, null);
    public Either(T1 value) => Value = (null, value);

    public static implicit operator Either<T0, T1>(T0 value) => new (value);
    public static implicit operator Either<T0, T1>(T1 value) => new (value); 
}

//AutoGenerated
readonly partial struct Either<T0, T1, T2>
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull
{
    public (Out<T0>?, Out<T1>?, Out<T2>?) Value { get; }

    [Obsolete("Dont use parameterless constructor", true)]
    public Either() {}

    public Either(T0 value) => Value = (value, null, null);
    public Either(T1 value) => Value = (null, value, null);
    public Either(T2 value) => Value = (null, null, value);

    public Either(Either<T0, T1> value) => Value = (value.Value.Item1, value.Value.Item2, null);
    public Either(Either<T0, T2> value) => Value = (value.Value.Item1, null, value.Value.Item2);
    public Either(Either<T1, T0> value) => Value = (value.Value.Item2, value.Value.Item1, null);
    public Either(Either<T1, T2> value) => Value = (null, value.Value.Item1, value.Value.Item2);
    public Either(Either<T2, T0> value) => Value = (value.Value.Item2, null, value.Value.Item1);
    public Either(Either<T2, T1> value) => Value = (null, value.Value.Item2, value.Value.Item1);

    public Either(Either<T0, T2, T1> value) => Value = (value.Value.Item1, value.Value.Item3, value.Value.Item2);
    public Either(Either<T1, T2, T0> value) => Value = (value.Value.Item3, value.Value.Item1, value.Value.Item2);
    public Either(Either<T1, T0, T2> value) => Value = (value.Value.Item2, value.Value.Item1, value.Value.Item3);
    public Either(Either<T2, T0, T1> value) => Value = (value.Value.Item2, value.Value.Item3, value.Value.Item1);
    public Either(Either<T2, T1, T0> value) => Value = (value.Value.Item3, value.Value.Item2, value.Value.Item1);

    public static implicit operator Either<T0, T1, T2>([DisallowNull] T0 value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Out<T0> value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Out<T0>? value) => new (value!.Value);

    public static implicit operator Either<T0, T1, T2>([DisallowNull] T1 value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Out<T1> value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Out<T1>? value) => new (value!.Value);

    public static implicit operator Either<T0, T1, T2>([DisallowNull] T2 value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Out<T2> value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Out<T2>? value) => new (value!.Value);

    public static implicit operator Either<T0, T1, T2>([DisallowNull] Either<T0, T1> value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Either<T0, T2> value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Either<T1, T0> value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Either<T1, T2> value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Either<T2, T0> value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Either<T2, T1> value) => new (value);
    
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Either<T0, T2, T1> value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Either<T1, T2, T0> value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Either<T1, T0, T2> value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Either<T2, T0, T1> value) => new (value);
    public static implicit operator Either<T0, T1, T2>([DisallowNull] Either<T2, T1, T0> value) => new (value);
}

public interface IResult;

public readonly partial struct Try<T> 
    where T : IResult
{
    public required Either<T, Exception> Result { get; init; }
}

//AutoGenerated
readonly partial struct Result<T0, TError> : IResult 
    where T0 : notnull
    where TError : struct, IError<TError>
{
    public required Either<T0, TError> Either { get; init; }

    public static implicit operator Result<T0, TError>(T0 value) => new () { Either = value };
    public static implicit operator Result<T0, TError>(TError value) => new () { Either = value };
}

readonly partial struct Result<T0, TError0, TError1> : IResult 
    where T0 : notnull
    where TError0 : struct, IError<TError0>
    where TError1 : struct, IError<TError1>
{
    public required Either<T0, TError0, TError1> Value { internal get; init; }

    public static implicit operator Result<T0, TError0, TError1>(T0 value) => new () { Value = value };
}
