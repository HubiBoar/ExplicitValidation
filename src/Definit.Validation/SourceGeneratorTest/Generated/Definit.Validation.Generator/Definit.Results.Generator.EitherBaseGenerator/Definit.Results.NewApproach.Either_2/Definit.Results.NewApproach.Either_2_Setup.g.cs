
namespace Definit.Results.NewApproach;

public interface IEither<T0, T1> : IEitherBase<(Or<T0>?, Or<T1>?)>
    where T0 : notnull
	where T1 : notnull;

public readonly partial struct Either<T0, T1> : IEither<T0, T1> 
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
}