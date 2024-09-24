#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> : Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Base
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
    public interface Base : IEitherBase<(Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?, Or<T6>?, Or<T7>?, Or<T8>?)>;

    public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?, Or<T6>?, Or<T7>?, Or<T8>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public Either() => throw new DefaultConstructorException();
	
	public Either(T0 value) => Value = (value!, null, null, null, null, null, null, null, null);
	public Either(T1 value) => Value = (null, value!, null, null, null, null, null, null, null);
	public Either(T2 value) => Value = (null, null, value!, null, null, null, null, null, null);
	public Either(T3 value) => Value = (null, null, null, value!, null, null, null, null, null);
	public Either(T4 value) => Value = (null, null, null, null, value!, null, null, null, null);
	public Either(T5 value) => Value = (null, null, null, null, null, value!, null, null, null);
	public Either(T6 value) => Value = (null, null, null, null, null, null, value!, null, null);
	public Either(T7 value) => Value = (null, null, null, null, null, null, null, value!, null);
	public Either(T8 value) => Value = (null, null, null, null, null, null, null, null, value!);
	
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>>();
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T2 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T3 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T4 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T5 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T6 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T7 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T8 value) => new (value);
}

public static class EitherExtensions_9 
{
    
}