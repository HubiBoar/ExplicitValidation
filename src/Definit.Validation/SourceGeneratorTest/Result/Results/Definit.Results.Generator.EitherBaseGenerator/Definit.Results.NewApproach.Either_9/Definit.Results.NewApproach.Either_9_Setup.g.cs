﻿using System.Diagnostics.CodeAnalysis;

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

    public Either([DisallowNull] T0 value) => Value = (value, null, null, null, null, null, null, null, null);
	public Either([DisallowNull] T1 value) => Value = (null, value, null, null, null, null, null, null, null);
	public Either([DisallowNull] T2 value) => Value = (null, null, value, null, null, null, null, null, null);
	public Either([DisallowNull] T3 value) => Value = (null, null, null, value, null, null, null, null, null);
	public Either([DisallowNull] T4 value) => Value = (null, null, null, null, value, null, null, null, null);
	public Either([DisallowNull] T5 value) => Value = (null, null, null, null, null, value, null, null, null);
	public Either([DisallowNull] T6 value) => Value = (null, null, null, null, null, null, value, null, null);
	public Either([DisallowNull] T7 value) => Value = (null, null, null, null, null, null, null, value, null);
	public Either([DisallowNull] T8 value) => Value = (null, null, null, null, null, null, null, null, value);

    public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>>();
    public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>([DisallowNull] T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>([DisallowNull] T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>([DisallowNull] T2 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>([DisallowNull] T3 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>([DisallowNull] T4 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>([DisallowNull] T5 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>([DisallowNull] T6 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>([DisallowNull] T7 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>([DisallowNull] T8 value) => new (value);
}