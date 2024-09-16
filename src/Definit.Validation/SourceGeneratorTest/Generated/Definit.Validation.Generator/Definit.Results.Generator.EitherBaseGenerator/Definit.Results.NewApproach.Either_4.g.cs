namespace Definit.Results.NewApproach;

public interface IEither<T0, T1, T2, T3> : IEitherBase<(Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?)>
    where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull;

public readonly struct Either<T0, T1, T2, T3> : IEither<T0, T1, T2, T3> 
    where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
{
    public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?) Value { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Either() => throw new DefaultConstructorException();

    public Either(T0 value) => Value = (value, null, null, null);
	public Either(T1 value) => Value = (null, value, null, null);
	public Either(T2 value) => Value = (null, null, value, null);
	public Either(T3 value) => Value = (null, null, null, value);

    public static implicit operator Either<T0, T1, T2, T3>(T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3>(T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3>(T2 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3>(T3 value) => new (value);

    // public static implicit operator Either<T0, T1, T2, T3>(Either<T1, T0> value) => new (value);
}

public static partial class EitherExtensions
{

    public static void Deconstruct<T0, T1, T2, T3>
    (
        this Either<T0, T1, T2, T3> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
    {
        var (t_0, t_1, t_2, t_3) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
    }

    public static void Deconstruct<T0, T1, T2, T3>
    (
        this Either<T0, T1, T2, T3> result,
        out IsNull<T0>? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3
    )
        where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
    {
        var (t_0, t_1, t_2, t_3) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
    }

    public static void Deconstruct<T0, T1, T2, T3>
    (
        this Either<T0, T1, T2, T3> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out T2? t2,
		out T3? t3
    )
        where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
    {
        var (t_0, t_1, t_2, t_3) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2;
		t3 = t_3;
    }

    public static void Deconstruct<T0, T1, T2, T3>
    (
        this Either<T0, T1, T2, T3> result,
        out T0? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out T3? t3
    )
        where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
    {
        var (t_0, t_1, t_2, t_3) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3;
    }

    public static void Deconstruct<T0, T1, T2, T3>
    (
        this Either<T0, T1, T2, T3> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out IsNull<T3>? t3
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
    {
        var (t_0, t_1, t_2, t_3) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3>
    (
        this Either<T0, T1, T2, T3> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out T2? t2,
		out T3? t3
    )
        where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
    {
        var (t_0, t_1, t_2, t_3) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2;
		t3 = t_3;
    }

    public static void Deconstruct<T0, T1, T2, T3>
    (
        this Either<T0, T1, T2, T3> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out T3? t3
    )
        where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
    {
        var (t_0, t_1, t_2, t_3) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3;
    }

    public static void Deconstruct<T0, T1, T2, T3>
    (
        this Either<T0, T1, T2, T3> result,
        out T0? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3
    )
        where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
    {
        var (t_0, t_1, t_2, t_3) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3>
    (
        this Either<T0, T1, T2, T3> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out T3? t3
    )
        where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
    {
        var (t_0, t_1, t_2, t_3) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3;
    }

    public static void Deconstruct<T0, T1, T2, T3>
    (
        this Either<T0, T1, T2, T3> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3
    )
        where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
    {
        var (t_0, t_1, t_2, t_3) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
    }
 
}