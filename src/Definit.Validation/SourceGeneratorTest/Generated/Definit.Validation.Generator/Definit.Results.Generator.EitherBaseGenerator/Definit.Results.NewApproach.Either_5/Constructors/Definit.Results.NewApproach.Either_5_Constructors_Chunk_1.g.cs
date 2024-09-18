namespace Definit.Results.NewApproach;

public readonly partial struct Either<T0, T1, T2, T3, T4> 
{
    public Either(Either<T4, T1, T2, T3, T0> value) => Value = (value.Value.Item5, value.Value.Item2, value.Value.Item3, value.Value.Item4, value.Value.Item1);
	public Either(Either<T4, T1, T2, T0, T3> value) => Value = (value.Value.Item4, value.Value.Item2, value.Value.Item3, value.Value.Item5, value.Value.Item1);
	public Either(Either<T4, T1, T3, T2, T0> value) => Value = (value.Value.Item5, value.Value.Item2, value.Value.Item4, value.Value.Item3, value.Value.Item1);
	public Either(Either<T4, T1, T3, T0, T2> value) => Value = (value.Value.Item4, value.Value.Item2, value.Value.Item5, value.Value.Item3, value.Value.Item1);
	public Either(Either<T4, T1, T0, T3, T2> value) => Value = (value.Value.Item3, value.Value.Item2, value.Value.Item5, value.Value.Item4, value.Value.Item1);
	public Either(Either<T4, T1, T0, T2, T3> value) => Value = (value.Value.Item3, value.Value.Item2, value.Value.Item4, value.Value.Item5, value.Value.Item1);
	public Either(Either<T4, T2, T1, T3, T0> value) => Value = (value.Value.Item5, value.Value.Item3, value.Value.Item2, value.Value.Item4, value.Value.Item1);
	public Either(Either<T4, T2, T1, T0, T3> value) => Value = (value.Value.Item4, value.Value.Item3, value.Value.Item2, value.Value.Item5, value.Value.Item1);
	public Either(Either<T4, T2, T3, T1, T0> value) => Value = (value.Value.Item5, value.Value.Item4, value.Value.Item2, value.Value.Item3, value.Value.Item1);
	public Either(Either<T4, T2, T3, T0, T1> value) => Value = (value.Value.Item4, value.Value.Item5, value.Value.Item2, value.Value.Item3, value.Value.Item1);
	public Either(Either<T4, T2, T0, T3, T1> value) => Value = (value.Value.Item3, value.Value.Item5, value.Value.Item2, value.Value.Item4, value.Value.Item1);
	public Either(Either<T4, T2, T0, T1, T3> value) => Value = (value.Value.Item3, value.Value.Item4, value.Value.Item2, value.Value.Item5, value.Value.Item1);
	public Either(Either<T4, T3, T2, T1, T0> value) => Value = (value.Value.Item5, value.Value.Item4, value.Value.Item3, value.Value.Item2, value.Value.Item1);
	public Either(Either<T4, T3, T2, T0, T1> value) => Value = (value.Value.Item4, value.Value.Item5, value.Value.Item3, value.Value.Item2, value.Value.Item1);
	public Either(Either<T4, T3, T1, T2, T0> value) => Value = (value.Value.Item5, value.Value.Item3, value.Value.Item4, value.Value.Item2, value.Value.Item1);
	public Either(Either<T4, T3, T1, T0, T2> value) => Value = (value.Value.Item4, value.Value.Item3, value.Value.Item5, value.Value.Item2, value.Value.Item1);
	public Either(Either<T4, T3, T0, T1, T2> value) => Value = (value.Value.Item3, value.Value.Item4, value.Value.Item5, value.Value.Item2, value.Value.Item1);
	public Either(Either<T4, T3, T0, T2, T1> value) => Value = (value.Value.Item3, value.Value.Item5, value.Value.Item4, value.Value.Item2, value.Value.Item1);
	public Either(Either<T4, T0, T2, T3, T1> value) => Value = (value.Value.Item2, value.Value.Item5, value.Value.Item3, value.Value.Item4, value.Value.Item1);
	public Either(Either<T4, T0, T2, T1, T3> value) => Value = (value.Value.Item2, value.Value.Item4, value.Value.Item3, value.Value.Item5, value.Value.Item1);
	public Either(Either<T4, T0, T3, T2, T1> value) => Value = (value.Value.Item2, value.Value.Item5, value.Value.Item4, value.Value.Item3, value.Value.Item1);
	public Either(Either<T4, T0, T3, T1, T2> value) => Value = (value.Value.Item2, value.Value.Item4, value.Value.Item5, value.Value.Item3, value.Value.Item1);
	public Either(Either<T4, T0, T1, T3, T2> value) => Value = (value.Value.Item2, value.Value.Item3, value.Value.Item5, value.Value.Item4, value.Value.Item1);
	public Either(Either<T4, T0, T1, T2, T3> value) => Value = (value.Value.Item2, value.Value.Item3, value.Value.Item4, value.Value.Item5, value.Value.Item1);
}