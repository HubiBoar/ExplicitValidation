namespace Definit.Results.NewApproach;

public static partial class Test
{
    [GenerateMethod.Private]
    private static string _PrivateRun(string t)
    {
        return t;
    }

    [GenerateMethod.Public]
    private static string _PublicRun(string t)
    {
        return t;
    }
}

[System.AttributeUsage
(
    System.AttributeTargets.Struct,
    AllowMultiple = false
)]
public sealed class GenerateEitherAttribute : Attribute
{
}

[System.AttributeUsage
(
    System.AttributeTargets.Struct,
    AllowMultiple = false
)]
public sealed class GenerateResultAttribute : Attribute
{
}

public static class GenerateMethod
{
    [System.AttributeUsage
    (
        System.AttributeTargets.Method,
        AllowMultiple = false
    )]
    public sealed class PublicAttribute : Attribute {}

    [System.AttributeUsage
    (
        System.AttributeTargets.Method,
        AllowMultiple = false
    )]
    public sealed class PrivateAttribute : Attribute {}
}

public static class Result
{
    public sealed record NullError();

    public static readonly NullError Null = new (); 
}

public readonly struct Null<T>
    where T : notnull
{
    public required T Value { get; init; }

    public static implicit operator T(Null<T> value) => value.Value;
    public static implicit operator Null<T>(T value) => new() { Value = value };
}

public interface IEither<T0, T1>
    where T0: notnull
    where T1: notnull
{
    public (Null<T0>?, Null<T1>?) Value { get; }

    public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1) => (t0, t1) = Value;
}

public interface IResult<T0, T1>
    where T0 : notnull
    where T1 : notnull, IError<T1>
{
}

public interface IError<TSelf>
    where TSelf : notnull, IError<TSelf>
{
    public abstract static TSelf Create(Exception exception); 
}

[GenerateResult]
public readonly partial struct Result<T0, T1> : IResult<T0, T1>
    where T0 : notnull
    where T1 : notnull, IError<T1>
{
}

[GenerateEither]
public partial struct Either<T0> : IEither<T0, string>
    where T0 : notnull
{
}

[GenerateEither]
public partial struct Either<T0, T1> : IEither<T0, T1>
    where T0 : notnull
    where T1 : notnull
{
}
