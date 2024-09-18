namespace Definit.Results.NewApproach;

public readonly partial struct Either<T0, T1, T2> 
{
    public Either(T0 value) => Value = (value, null, null);
	public Either(T1 value) => Value = (null, value, null);
	public Either(T2 value) => Value = (null, null, value);
	public Either(Either<T0, T1> value) => Value = (value.Value.Item1, value.Value.Item2, null);
	public Either(Either<T1, T0> value) => Value = (value.Value.Item2, value.Value.Item1, null);
	public Either(Either<T0, T2> value) => Value = (value.Value.Item1, null, value.Value.Item2);
	public Either(Either<T2, T0> value) => Value = (value.Value.Item2, null, value.Value.Item1);
	public Either(Either<T1, T2> value) => Value = (null, value.Value.Item1, value.Value.Item2);
	public Either(Either<T2, T1> value) => Value = (null, value.Value.Item2, value.Value.Item1);
	public Either(Either<T0, T2, T1> value) => Value = (value.Value.Item1, value.Value.Item3, value.Value.Item2);
	public Either(Either<T1, T0, T2> value) => Value = (value.Value.Item2, value.Value.Item1, value.Value.Item3);
	public Either(Either<T1, T2, T0> value) => Value = (value.Value.Item3, value.Value.Item1, value.Value.Item2);
	public Either(Either<T2, T1, T0> value) => Value = (value.Value.Item3, value.Value.Item2, value.Value.Item1);
	public Either(Either<T2, T0, T1> value) => Value = (value.Value.Item2, value.Value.Item3, value.Value.Item1);
}