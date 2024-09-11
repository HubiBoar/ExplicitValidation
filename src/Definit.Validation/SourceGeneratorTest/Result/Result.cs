using System.Text;
using Definit.Results.NewApproach;

[module: GenerateObject(typeof(StringBuilder))]
[module: GenerateObject<StringReader>]

namespace Definit.Results.NewApproach;

public partial class Test
{
    public readonly struct NotFound() : IError<NotFound>
    {
        public static NotFound Create(Exception exception) => new NotFound();
    }

    [GenerateMethod.Private]
    private Result<string, NotFound> _PrivateRun(string t)
    {
        return t;
    }

    [GenerateMethod.Public]
    private static Task<Result<T, NotFound>> _PublicRun<T>(T t)
        where T : IError<T>
    {
        return Task.FromResult<Result<T, NotFound>>(t);
    }
}

[System.AttributeUsage(System.AttributeTargets.Module, AllowMultiple = false)]
public sealed class GenerateObjectAttribute : Attribute
{
    public bool AllowUnsafe { get; set; }

    public Type Type { get; }

    public GenerateObjectAttribute(Type type)
    {
        Type = type;
    }
}

[System.AttributeUsage(System.AttributeTargets.Module, AllowMultiple = false)]
public sealed class GenerateObjectAttribute<T> : Attribute
{
    public bool AllowUnsafe { get; set; }
};

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
}

public readonly struct Null<T>
    where T : notnull
{
    public required T Value { get; init; }

    public static implicit operator T(Null<T> value) => value.Value;
    public static implicit operator Null<T>(T value) => new() { Value = value };
}


public readonly struct Error : IError<Error>
{
    public required Exception Exception { get; init; }

    public static Error Create(Exception exception)
    {
        return new ()
        {
            Exception = exception
        };
    }

    public static implicit operator Error(Exception exception) => new Error() { Exception = exception };
}

public interface IError<TSelf>
    where TSelf : notnull, IError<TSelf>
{
    public abstract static TSelf Create(Exception exception); 
}


public interface IEither<T0, T1>
    where T0: notnull
    where T1: notnull
{
    public (Null<T0>?, Null<T1>?) Value { get; }
}

public interface IEither<T0, T1, T2>
    where T0: notnull
    where T1: notnull
    where T2: notnull
{
    public (Null<T0>?, Null<T1>?, Null<T2>?) Value { get; }
}

public interface IEither<T0, T1, T2, T3>
    where T0: notnull
    where T1: notnull
    where T2: notnull
    where T3: notnull
{
    public (Null<T0>?, Null<T1>?, Null<T2>?, Null<T3>?) Value { get; }
}

public interface IResult<T0, T1>
    where T0 : notnull
    where T1 : notnull, IError<T1>
{
}

public interface IResult<T0, T1, T2>
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull, IError<T2>
{
}

public interface IResult<T0, T1, T2, T3>
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull, IError<T3>
{
}

[GenerateEither]
public partial struct Either<T0> : IEither<T0, string>
    where T0 : notnull;

[GenerateEither]
public partial struct Either<T0, T1> : IEither<T0, T1>
    where T0 : notnull
    where T1 : notnull;

[GenerateEither]
public partial struct Either<T0, T1, T2> : IEither<T0, T1, T2>
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull;

[GenerateEither]
public partial struct Either<T0, T1, T2, T3> : IEither<T0, T1, T2, T3>
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull;


[GenerateResult]
public partial struct Result<T0, T1> : IResult<T0, T1>
    where T0 : notnull
    where T1 : notnull, IError<T1>;

[GenerateResult]
public partial struct Result<T0, T1, T2> : IResult<T0, T1, T2>
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull, IError<T2>;

[GenerateResult]
public partial struct Result<T0, T1, T2, T3> : IResult<T0, T1, T2, T3>
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull, IError<T3>;
