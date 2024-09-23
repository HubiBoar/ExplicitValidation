using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

[System.AttributeUsage(System.AttributeTargets.Struct, AllowMultiple = false)]
public sealed class GenerateEitherAttribute : Attribute;

public static class GenerateEither
{
    [System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = false)]
    internal sealed class BaseAttribute : Attribute
    {
        public int MaxCount { get; }

        public BaseAttribute(int maxCount)
        {
            MaxCount = maxCount;
        }
    }
}

public interface IEitherBase;

public interface IEitherBase<TValue> : IEitherBase
    where TValue : struct
{
    public TValue Value { get; }
}

public static class EitherErrorExtensions
{
    public static bool IsSuccess<T0, T1>
    (
        this Either<T0, T1> value,
        [NotNullWhen(true)] out Or<T0>? t0
    )
        where T1 : struct, IError
    {
        (t0, _) = value;

        return t0 is not null;
    }

    public static bool IsSuccess<T0, T1>
    (
        this Either<T0, T1> value,
        [NotNullWhen(true)] out Or<T0>? t0,
        [NotNullWhen(false)] out T1? t1
    )
        where T1 : struct, IError
    {
        (t0, var t_1) = value;
        t1 = t_1.GetValue();

        return t1 is null;
    }

    public static bool IsError<T0, T1>
    (
        this Either<T0, T1> value,
        [NotNullWhen(true)] out T1? t1
    )
        where T1 : struct, IError
    {
        (_, var t_1) = value;
        t1 = t_1.GetValue();

        return t1 is not null;
    }

    public static bool IsError<T0, T1>
    (
        this Either<T0, T1> value,
        [NotNullWhen(true)] out T1? t1,
        [NotNullWhen(false)] out Or<T0>? t0
    )
        where T1 : struct, IError
    {
        (t0, var t_1) = value;
        t1 = t_1.GetValue();

        return t1 is not null;
    }

    public static bool IsFirst<T0, T1>
    (
        this Either<T0, T1> value,
        [NotNullWhen(true)] out Or<T0>? t0
    )
    {
        (t0, _) = value;

        return t0 is not null;
    }

    public static bool IsFirst<T0, T1>
    (
        this Either<T0, T1> value,
        [NotNullWhen(true)] out Or<T0>? t0,
        [NotNullWhen(false)] out Or<T1>? t1
    )
    {
        (t0, t1) = value;

        return t0 is not null;
    }

    public static bool IsSecond<T0, T1>
    (
        this Either<T0, T1> value,
        [NotNullWhen(true)] out Or<T1>? t1
    )
    {
        (_, t1) = value;

        return t1 is not null;
    }

    public static bool IsSecond<T0, T1>
    (
        this Either<T0, T1> value,
        [NotNullWhen(true)] out Or<T1>? t1,
        [NotNullWhen(false)] out Or<T0>? t0
    )
    {
        (t0, t1) = value;

        return t1 is not null;
    }
}
