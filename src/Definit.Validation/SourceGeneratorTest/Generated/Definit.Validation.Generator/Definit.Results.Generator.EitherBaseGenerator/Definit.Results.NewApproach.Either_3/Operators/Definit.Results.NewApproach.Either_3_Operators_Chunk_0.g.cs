namespace Definit.Results.NewApproach;

public readonly partial struct Either<T0, T1, T2> 
{
    public static implicit operator Either<T0, T1, T2>(T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2>(T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2>(T2 value) => new (value);
	public static implicit operator Either<T0, T1, T2>(Either<T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2>(Either<T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2>(Either<T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2>(Either<T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2>(Either<T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2>(Either<T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2>(Either<T0, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2>(Either<T1, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2>(Either<T1, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2>(Either<T2, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2>(Either<T2, T0, T1> value) => new (value);
}