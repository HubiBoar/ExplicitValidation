namespace Definit.Results.NewApproach;

public static partial class EitherExtensions 
{
    
    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7>? result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
    {
        if(result is null)
        {
            t0 = null;
			t1 = null;
			t2 = null;
			t3 = null;
			t4 = null;
			t5 = null;
			t6 = null;
			t7 = null;
            return;
        }

        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7) = result.Value.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
    }
	
    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7> result,
        out IsNull<T0>? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7
    )
        where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7>? result,
        out IsNull<T0>? t0,
		out T1? t1,
		out T2? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7
    )
        where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
    {
        if(result is null)
        {
            t0 = null;
			t1 = null;
			t2 = null;
			t3 = null;
			t4 = null;
			t5 = null;
			t6 = null;
			t7 = null;
            return;
        }

        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7) = result.Value.Value;

        t0 = t_0.IsNull();
		t1 = t_1;
		t2 = t_2;
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
    }
	
    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out T2? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7
    )
        where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2;
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7>? result,
        out T0? t0,
		out IsNull<T1>? t1,
		out T2? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7
    )
        where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
    {
        if(result is null)
        {
            t0 = null;
			t1 = null;
			t2 = null;
			t3 = null;
			t4 = null;
			t5 = null;
			t6 = null;
			t7 = null;
            return;
        }

        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7) = result.Value.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2;
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
    }
	
    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out T2? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7
    )
        where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2;
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7>? result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out T2? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7
    )
        where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
    {
        if(result is null)
        {
            t0 = null;
			t1 = null;
			t2 = null;
			t3 = null;
			t4 = null;
			t5 = null;
			t6 = null;
			t7 = null;
            return;
        }

        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7) = result.Value.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2;
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
    }
	
    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7> result,
        out T0? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7
    )
        where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7>? result,
        out T0? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7
    )
        where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
    {
        if(result is null)
        {
            t0 = null;
			t1 = null;
			t2 = null;
			t3 = null;
			t4 = null;
			t5 = null;
			t6 = null;
			t7 = null;
            return;
        }

        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7) = result.Value.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
    }
	
    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7> result,
        out IsNull<T0>? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7
    )
        where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
    {
        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
    }

    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
    (
        this Either<T0, T1, T2, T3, T4, T5, T6, T7>? result,
        out IsNull<T0>? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out T3? t3,
		out IsNull<T4>? t4,
		out IsNull<T5>? t5,
		out IsNull<T6>? t6,
		out IsNull<T7>? t7
    )
        where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
    {
        if(result is null)
        {
            t0 = null;
			t1 = null;
			t2 = null;
			t3 = null;
			t4 = null;
			t5 = null;
			t6 = null;
			t7 = null;
            return;
        }

        var (t_0, t_1, t_2, t_3, t_4, t_5, t_6, t_7) = result.Value.Value;

        t0 = t_0.IsNull();
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3;
		t4 = t_4.IsNull();
		t5 = t_5.IsNull();
		t6 = t_6.IsNull();
		t7 = t_7.IsNull();
    }
}