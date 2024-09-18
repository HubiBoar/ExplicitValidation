namespace Definit.Results.NewApproach;

public readonly partial struct Either<T0, T1> 
{
    public Either(T0 value) => Value = (value, null);
	public Either(T1 value) => Value = (null, value);
	public Either(Either<T1, T0> value) => Value = (value.Value.Item2, value.Value.Item1);
}