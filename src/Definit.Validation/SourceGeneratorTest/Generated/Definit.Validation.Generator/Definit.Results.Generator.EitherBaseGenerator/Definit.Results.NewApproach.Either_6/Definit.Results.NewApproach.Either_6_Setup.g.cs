﻿
namespace Definit.Results.NewApproach;

public interface IEither<T0, T1, T2, T3, T4, T5> : IEitherBase<(Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?)>
    where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull
	where T5 : notnull;

public readonly partial struct Either<T0, T1, T2, T3, T4, T5> : IEither<T0, T1, T2, T3, T4, T5> 
    where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull
	where T5 : notnull
{
    public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?) Value { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Either() => throw new DefaultConstructorException();

    public Either(T0 value) => Value = (value, null, null, null, null, null);
	public Either(T1 value) => Value = (null, value, null, null, null, null);
	public Either(T2 value) => Value = (null, null, value, null, null, null);
	public Either(T3 value) => Value = (null, null, null, value, null, null);
	public Either(T4 value) => Value = (null, null, null, null, value, null);
	public Either(T5 value) => Value = (null, null, null, null, null, value);

    public static implicit operator Either<T0, T1, T2, T3, T4, T5>(T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5>(T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5>(T2 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5>(T3 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5>(T4 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5>(T5 value) => new (value);
}