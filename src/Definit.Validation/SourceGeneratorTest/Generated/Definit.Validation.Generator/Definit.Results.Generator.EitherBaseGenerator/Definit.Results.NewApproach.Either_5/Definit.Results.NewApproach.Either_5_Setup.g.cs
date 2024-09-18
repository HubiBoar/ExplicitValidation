
namespace Definit.Results.NewApproach;

public interface IEither<T0, T1, T2, T3, T4> : IEitherBase<(Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?)>
    where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull;

public readonly partial struct Either<T0, T1, T2, T3, T4> : IEither<T0, T1, T2, T3, T4> 
    where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull
{
    public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?) Value { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Either() => throw new DefaultConstructorException();

    public Either(T0 value) => Value = (value, null, null, null, null);
	public Either(T1 value) => Value = (null, value, null, null, null);
	public Either(T2 value) => Value = (null, null, value, null, null);
	public Either(T3 value) => Value = (null, null, null, value, null);
	public Either(T4 value) => Value = (null, null, null, null, value);

    public static implicit operator Either<T0, T1, T2, T3, T4>(T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(T2 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(T3 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(T4 value) => new (value);
}