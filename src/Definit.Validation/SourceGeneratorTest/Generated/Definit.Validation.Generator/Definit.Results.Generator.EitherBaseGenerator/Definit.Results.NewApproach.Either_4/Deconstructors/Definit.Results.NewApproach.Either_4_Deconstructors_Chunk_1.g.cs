﻿namespace Definit.Results.NewApproach;

public static partial class EitherExtensions 
{
    
    public static void Deconstruct<T0, T1, T2, T3>
    (
        this Either<T0, T1, T2, T3> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3
    )
        where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
    {
        var (t_0, t_1, t_2, t_3) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
    }
	
    public static void Deconstruct<T0, T1, T2, T3>
    (
        this Either<T0, T1, T2, T3> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3
    )
        where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
    {
        var (t_0, t_1, t_2, t_3) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
    }
}