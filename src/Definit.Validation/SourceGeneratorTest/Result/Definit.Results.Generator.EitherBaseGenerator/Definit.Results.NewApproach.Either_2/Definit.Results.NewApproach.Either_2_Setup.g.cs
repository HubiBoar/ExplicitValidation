using System.Diagnostics.CodeAnalysis;

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

    public Either([DisallowNull] T0 value) => Value = (value, null);
	public Either([DisallowNull] T1 value) => Value = (null, value);

    public static implicit operator Either<T0, T1>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1>>();
    public static implicit operator Either<T0, T1>([DisallowNull] T0 value) => new (value);
	public static implicit operator Either<T0, T1>([DisallowNull] T1 value) => new (value);
}