using System.Diagnostics.CodeAnalysis;
using System.Text;
using Definit.Results.NewApproach;

[module: GenerateObject(typeof(StringBuilder))]
[module: GenerateObject<StringReader>]
[module: GenerateObject(typeof(List<>))]
[module: GenerateObject<List<string>>]

namespace Definit.Results.NewApproach;

public partial class Test
{
    public readonly record struct NotFound(Either<KeyNotFoundException, Exception> Exception)
        : IError<NotFound, KeyNotFoundException>;

    private static int Get(string str)
    {
        return default!;
    }

    private static string GetString()
    {
        return default!;
    }

    [GenerateMethod.Private]
    private Result<string, NotFound> _PrivateRun(string t)
    {
        var ((str, isNull), error) = Result.Try(GetString);

        if(str is null)
        {
            return new NotFound();
        }

        (var i, error) = Result.Try(() => Get(str));
        if(i is not null)
        {
            return i.Value.ToString();
        }

        return t;
    }

    [GenerateMethod.Public]
    private static Task<Result<T, NotFound>> _PublicRun<T>(T t)
        where T : IError<T>
    {
        return Task.FromResult<Result<T, NotFound>>(t);
    }
}

[System.AttributeUsage(System.AttributeTargets.Module, AllowMultiple = true)]
public sealed class GenerateObjectAttribute : Attribute
{
    public bool AllowUnsafe { get; set; }

    public Type Type { get; }

    public GenerateObjectAttribute(Type type)
    {
        Type = type;
    }
}

[System.AttributeUsage(System.AttributeTargets.Module, AllowMultiple = true)]
public sealed class GenerateObjectAttribute<T> : Attribute
{
    public bool AllowUnsafe { get; set; }
};

[System.AttributeUsage(System.AttributeTargets.Interface, AllowMultiple = false)]
internal sealed class GenerateEitherBaseAttribute : Attribute;

[System.AttributeUsage(System.AttributeTargets.Interface, AllowMultiple = false)]
internal sealed class GenerateResultBaseAttribute : Attribute;

[System.AttributeUsage(System.AttributeTargets.Struct, AllowMultiple = false)]
public sealed class GenerateEitherAttribute : Attribute;

[System.AttributeUsage(System.AttributeTargets.Struct, AllowMultiple = false)]
public sealed class GenerateResultAttribute : Attribute;

public static class GenerateMethod
{
    public static class Public
    {
        [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
        public sealed class OverrideAttribute : Attribute;

        [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
        public sealed class VirtualAttribute : Attribute;
    }

    [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
    public sealed class PublicAttribute : Attribute;
    
    public static class Private
    {
        [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
        public sealed class OverrideAttribute : Attribute;

        [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
        public sealed class VirtualAttribute : Attribute;
    }

    [System.AttributeUsage(System.AttributeTargets.Method, AllowMultiple = false)]
    public sealed class PrivateAttribute : Attribute;
}

public readonly struct Success;
public readonly struct ResultMatchError;
public readonly struct Null;

public sealed class ResultMatchException<T>() : Exception;

public static class Result
{
    public static readonly Success Success = new ();
    public static readonly Null Null = new (); 
    public static readonly ResultMatchError MatchError = new (); 

    public static (bool Matches, Either<T, Exception> Either) Matches<T>(this Exception exception)
        where T : Exception
    {
        if(exception is T match)
        {
            return (true, match);
        }
        
        return (false, exception);
    }

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

    public static T ToReturn<TResult, T>(TResult result)
        where T : struct, IEitherBase 
        where TResult : IResultBase<T>
    {
        return result.Value;
    }

    public static T ToReturn<TResult, T>(Exception exception)
        where T : struct, IEitherBase 
        where TResult : IResultBase<T>
    {
        return TResult.FromException(exception);
    }

    public static Either<Success, Error> Try(Action func) 
    {
        try
        {
            func();
            return ToReturn<Result<Success, Error>, Either<Success, Error>>(Success);
        }
        catch (Exception exception)
        {
            return ToReturn<Result<Success, Error>, Either<Success, Error>>(exception);
        }
    }

    public static Either<T, Error> Try<T>(Func<T> func)
        where T : notnull
    {
        try
        {
            return ToReturn<Result<T, Error>, Either<T, Error>>(func());
        }
        catch (Exception exception)
        {
            return ToReturn<Result<T, Error>, Either<T, Error>>(exception);
        }
    }
}

public readonly record struct Error<T>(Either<T, Exception> Exception) : IError<Error<T>, T>
    where T : Exception;

public readonly record struct Error(Exception Exception) : IError<Error>
{
    public static (bool Matches, Error Error) Matches(Exception exception) => (true, new Error(exception)); 
}

public readonly struct Or<T>
    where T : notnull
{
    public required T Value { get; init; }

    public static implicit operator T(Or<T> value) => value.Value;
    public static implicit operator Or<T>(T value) => new() { Value = value };
}

public interface IError<TSelf, TException> : IError<TSelf>
    where TSelf : struct, IError<TSelf, TException>
    where TException : notnull, Exception
{
    public Either<TException, Exception> Exception { get; init; }

    static (bool Matches, TSelf Error) IError<TSelf>.Matches(Exception exception)
    {
        var (matches, error) = exception.Matches<TException>();
        return (matches, new TSelf() { Exception = error }); 
    }
}

public interface IError<TSelf>
    where TSelf : notnull, IError<TSelf>
{
    public abstract static (bool Matches, TSelf Error) Matches(Exception exception); 
}

public interface IEitherBase;

public interface IEitherBase<TValue> : IEitherBase
    where TValue : struct
{
    public TValue Value { get; }
}

public interface IResultBase<TValue>
    where TValue : struct, IEitherBase
{
    internal TValue Value { get; }

    internal static abstract TValue FromException(Exception exception);
}

[GenerateEitherBase]
public partial interface IEither<T0, T1>;

[GenerateResultBase]
public partial interface IResult<T0, T1>;

//AutoGenerated
public partial interface IEither<T0, T1> : IEitherBase<(Or<T0>?, Or<T1>?)>
    where T0 : notnull
    where T1 : notnull;

public readonly struct Either<T0, T1> : IEither<T0, T1>
    where T0 : notnull
    where T1 : notnull
{
    public (Or<T0>?, Or<T1>?) Value { get; }

    [Obsolete("Dont use parameterless constructor", true)]
    public Either() {}

    public Either(T0 value) => Value = (value, null);
    public Either(T1 value) => Value = (null, value);
    public Either(Either<T1, T0> value) => Value = (value.Value.Item2, value.Value.Item1);

    public static implicit operator Either<T0, T1>(T0 value) => new (value);
    public static implicit operator Either<T0, T1>(T1 value) => new (value);
    public static implicit operator Either<T0, T1>(Either<T1, T0> value) => new (value);
}

public readonly record struct NotNull<T>
    where T : class
{
    public T Value { get; }

    [Obsolete("Dont use parameterless constructor", true)]
    public NotNull()
    {
        throw new NullReferenceException();
    }

    private NotNull(T value)
    {
        Value = value;
    }

    public static implicit operator T(NotNull<T> value) => value.Value;

    public static IsNull<T> IsNull([MaybeNull] T? value)
    {
        return value is null ? new IsNull<T>() { Value = Result.Null } : new IsNull<T>() { Value = new NotNull<T>(value) };
    }
}
public readonly record struct IsNull<T>
    where T : class
{
    public required Either<NotNull<T>, Null> Value { get; init; }

    public void Deconstruct(out T? t, out Null? nul)
    {
        (var t_0, nul) = Value.Value;
        t = t_0?.Value;
    }

    public static IsNull<T> Create([MaybeNull] T? value)
    {
        return NotNull<T>.IsNull(value); 
    }
}

public static partial class EitherExtensions
{
    public static void Deconstruct<T0, T1>(this Either<T0, T1> result, out T0? t0, out T1? t1)
        where T0 : struct
        where T1 : struct 
    {
        (t0, t1) = result.Value;
    }
    
    public static void Deconstruct<T0, T1>(this Either<T0, T1> result, out IsNull<T0>? t0, out IsNull<T1>? t1)
        where T0 : class
        where T1 : class 
    {
        var (t_0, t_1) = result.Value;
         
        t0 = t_0.IsNull(); 
        t1 = t_1.IsNull(); 
    }

    public static void Deconstruct<T0, T1>(this Either<T0, T1> result, out T0? t0, out IsNull<T1>? t1)
        where T0 : struct
        where T1 : class 
    {
        (t0, var t_1) = result.Value;
        t1 = t_1.IsNull(); 
    }

    public static void Deconstruct<T0, T1>(this Either<T0, T1> result, out IsNull<T0>? t0, out T1? t1)
        where T0 : class
        where T1 : struct
    {
        (var t_0, t1) = result.Value;
        t0 = t_0.IsNull(); 
    }
}

//AutoGenerated
public partial interface IResult<T0, T1>  : IResultBase<Either<T0, T1>>
    where T0 : notnull
    where T1 : notnull;

public readonly struct Result<T0, T1> : IResult<T0, T1> 
    where T0 : notnull
    where T1 : struct, IError<T1>
{
    public required Either<T0, T1> Either { private get; init; }

    Either<T0, T1> IResultBase<Either<T0, T1>>.Value => Either;

    static Either<T0, T1> IResultBase<Either<T0, T1>>.FromException(Exception exception)
    {
        return T1.Matches(exception).Error;
    }

    public static implicit operator Result<T0, T1>(T0 value) => new () { Either = value };
    public static implicit operator Result<T0, T1>(T1 value) => new () { Either = value };

    public static implicit operator Result<T0, T1>(Either<T0, T1> value) => new () { Either = value };
    public static implicit operator Result<T0, T1>(Either<T1, T0> value) => new () { Either = value };
}
