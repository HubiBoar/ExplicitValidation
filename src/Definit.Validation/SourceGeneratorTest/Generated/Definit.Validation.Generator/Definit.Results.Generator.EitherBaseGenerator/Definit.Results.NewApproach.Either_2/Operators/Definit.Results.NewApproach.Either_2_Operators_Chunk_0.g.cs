namespace Definit.Results.NewApproach;

public readonly partial struct Either<T0, T1> 
{
    public static implicit operator Either<T0, T1>(T0 value) => new (value);
	public static implicit operator Either<T0, T1>(T1 value) => new (value);
	public static implicit operator Either<T0, T1>(Either<T1, T0> value) => new (value);
}