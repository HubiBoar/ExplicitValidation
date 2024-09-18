using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.NewApproach;

public interface IEither<T0, T1, T2> : IEitherBase<(Or<T0>?, Or<T1>?, Or<T2>?)>
    where T0 : notnull
	where T1 : notnull
	where T2 : notnull;

public readonly struct Either<T0, T1, T2> : IEither<T0, T1, T2> 
    where T0 : notnull
	where T1 : notnull
	where T2 : notnull
{
    public (Or<T0>?, Or<T1>?, Or<T2>?) Value { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Either() => throw new DefaultConstructorException();

    public Either([DisallowNull] T0 value) => Value = (value, null, null);
	public Either([DisallowNull] T1 value) => Value = (null, value, null);
	public Either([DisallowNull] T2 value) => Value = (null, null, value);

    public static implicit operator Either<T0, T1, T2>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2>>();
    public static implicit operator Either<T0, T1, T2>([DisallowNull] T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2>([DisallowNull] T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2>([DisallowNull] T2 value) => new (value);
}