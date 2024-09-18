﻿namespace Definit.Results.NewApproach;

public readonly partial struct Either<T0, T1, T2, T3, T4> 
{
    public static implicit operator Either<T0, T1, T2, T3, T4>(T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(T2 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(T3 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(T4 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1, T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1, T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1, T2, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1, T3, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1, T3, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1, T4, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T1, T4, T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T1, T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T1, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T3, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T3, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T4, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T2, T4, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T2, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T2, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T1, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T1, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T4, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T3, T4, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T2, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T2, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T3, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T3, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T1, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T0, T4, T1, T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T2, T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T2, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T3, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T3, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T4, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T0, T4, T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T0, T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T0, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T3, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T3, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T4, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T2, T4, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T2, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T2, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T0, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T0, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T4, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T3, T4, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T2, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T2, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T3, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T3, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T0, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T1, T4, T0, T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T0, T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T0, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T3, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T3, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T4, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T1, T4, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T1, T3, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T1, T4, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T3, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T3, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T4, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T0, T4, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T0, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T0, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T1, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T1, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T4, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T3, T4, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T0, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T0, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T3, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T3, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T1, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T2, T4, T1, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T2, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T2, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T0, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T0, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T4, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T1, T4, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T1, T0, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T1, T4, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T0, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T0, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T4, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T2, T4, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T2, T1, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T2, T4, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T1, T2, T4> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T1, T4, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T4, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T0, T4, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T2, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T2, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T0, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T0, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T1, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T3, T4, T1, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T2, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T2, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T3, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T3, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T0, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T1, T0, T2, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T1, T3, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T1, T0, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T3, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T3, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T0, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T2, T0, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T2, T1, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T2, T0, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T1, T2, T0> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T1, T0, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T0, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T3, T0, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T2, T3, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T2, T1, T3> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T3, T2, T1> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T3, T1, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T1, T3, T2> value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(Either<T4, T0, T1, T2, T3> value) => new (value);
}