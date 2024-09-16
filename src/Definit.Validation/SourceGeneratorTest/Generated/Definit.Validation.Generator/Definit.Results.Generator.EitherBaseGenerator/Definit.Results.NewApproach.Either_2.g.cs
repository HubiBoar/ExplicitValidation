namespace Definit.Results.NewApproach;

public interface IEither<T0, T1> : IEitherBase<(Or<T0>?, Or<T1>?)>
    where T0 : notnull
	where T1 : notnull;

public readonly struct Either<T0, T1> : IEither<T0, T1> 
    where T0 : notnull
	where T1 : notnull
{
    public (Or<T0>?, Or<T1>?) Value { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Either() => throw new DefaultConstructorException();

    public Either(T0 value) => Value = (value, null);
	public Either(T1 value) => Value = (null, value);

    public static implicit operator Either<T0, T1>(T0 value) => new (value);
	public static implicit operator Either<T0, T1>(T1 value) => new (value);

    // public static implicit operator Either<T0, T1>(Either<T1, T0> value) => new (value);
}

public static partial class EitherExtensions
{

    public static void Deconstruct<T0, T1>
    (
        this Either<T0, T1> result,
        out T0? t0,
		out T1? t1
    )
        where T0 : struct
		where T1 : struct
    {
        var (t_0, t_1) = result.Value;

        t0 = t_0;
		t1 = t_1;
    }

    public static void Deconstruct<T0, T1>
    (
        this Either<T0, T1> result,
        out IsNull<T0>? t0,
		out T1? t1
    )
        where T0 : class
		where T1 : struct
    {
        var (t_0, t_1) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1;
    }

    public static void Deconstruct<T0, T1>
    (
        this Either<T0, T1> result,
        out T0? t0,
		out IsNull<T1>? t1
    )
        where T0 : struct
		where T1 : class
    {
        var (t_0, t_1) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
    }

    public static void Deconstruct<T0, T1>
    (
        this Either<T0, T1> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1
    )
        where T0 : class
		where T1 : class
    {
        var (t_0, t_1) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
    }
 
}