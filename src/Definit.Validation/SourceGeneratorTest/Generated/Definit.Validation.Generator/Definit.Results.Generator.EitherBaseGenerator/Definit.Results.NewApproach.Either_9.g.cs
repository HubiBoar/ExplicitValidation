namespace Definit.Results.NewApproach;

public interface IEither<T0, T1, T2, T3, T4, T5, T6, T7, T8> : IEitherBase<(Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?, Or<T6>?, Or<T7>?, Or<T8>?)>
    where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull
	where T5 : notnull
	where T6 : notnull
	where T7 : notnull
	where T8 : notnull;

public readonly struct Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> : IEither<T0, T1, T2, T3, T4, T5, T6, T7, T8> 
    where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull
	where T5 : notnull
	where T6 : notnull
	where T7 : notnull
	where T8 : notnull
{
    public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?, Or<T6>?, Or<T7>?, Or<T8>?) Value { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Either() => throw new DefaultConstructorException();

    public Either(T0 value) => Value = (value, null, null, null, null, null, null, null, null);
	public Either(T1 value) => Value = (null, value, null, null, null, null, null, null, null);
	public Either(T2 value) => Value = (null, null, value, null, null, null, null, null, null);
	public Either(T3 value) => Value = (null, null, null, value, null, null, null, null, null);
	public Either(T4 value) => Value = (null, null, null, null, value, null, null, null, null);
	public Either(T5 value) => Value = (null, null, null, null, null, value, null, null, null);
	public Either(T6 value) => Value = (null, null, null, null, null, null, value, null, null);
	public Either(T7 value) => Value = (null, null, null, null, null, null, null, value, null);
	public Either(T8 value) => Value = (null, null, null, null, null, null, null, null, value);

    public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T2 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T3 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T4 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T5 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T6 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T7 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T8 value) => new (value);

    // public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Either<T1, T0> value) => new (value);
}

public static partial class EitherExtensions
{

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out T4? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4;
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out IsNull<T0>? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out T4? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4;
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out T2? t2,
		out T3? t3,
		out T4? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2;
		t3 = t_3;
		t4 = t_4;
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out T3? t3,
		out T4? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3;
		t4 = t_4;
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out IsNull<T3>? t3,
		out T4? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3.IsNull();
		t4 = t_4;
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out T4? t4,
		out IsNull<T5>? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4;
		t5 = t_5.IsNull();
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out T4? t4,
		out T5? t5,
		out IsNull<T6>? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4;
		t5 = t_5;
		t6 = t_6.IsNull();
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out T4? t4,
		out T5? t5,
		out T6? t6,
		out IsNull<T7>? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4;
		t5 = t_5;
		t6 = t_6;
		t7 = t_7.IsNull();
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out T4? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out IsNull<T8>? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4;
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out T2? t2,
		out T3? t3,
		out T4? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2;
		t3 = t_3;
		t4 = t_4;
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out T3? t3,
		out T4? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3;
		t4 = t_4;
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out T4? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4;
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out T4? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4;
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out T4? t4,
		out T5? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4;
		t5 = t_5;
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out T4? t4,
		out T5? t5,
		out T6? t6,
		out IsNull<T7>? t7,
		out IsNull<T8>? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
		where T8 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4;
		t5 = t_5;
		t6 = t_6;
		t7 = t_7.IsNull();
		t8 = t_8.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out T3? t3,
		out T4? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3;
		t4 = t_4;
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out T4? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4;
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out T4? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4;
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out T4? t4,
		out T5? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7,
		out IsNull<T8>? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
		where T8 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4;
		t5 = t_5;
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
		t8 = t_8.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out T4? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4;
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out T4? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7,
		out IsNull<T8>? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
		where T8 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4;
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
		t8 = t_8.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out T5? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5;
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7,
		out IsNull<T8>? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
		where T8 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
		t8 = t_8.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out T6? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6;
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7,
		out IsNull<T8>? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
		where T8 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
		t8 = t_8.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out T7? t7,
		out T8? t8
    )
        where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7;
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7,
		out T8? t8
    )
        where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7,
		out IsNull<T8>? t8
    )
        where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
		where T8 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
		t8 = t_8.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7,
		out T8? t8
    )
        where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
		where T8 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
		t8 = t_8;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7,
		out IsNull<T8>? t8
    )
        where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
		where T8 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
		t8 = t_8.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7,
		out IsNull<T8>? t8
    )
        where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
		where T8 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7, t_8) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
		t8 = t_8.IsNull();
    }
 
}