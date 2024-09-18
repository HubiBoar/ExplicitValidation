namespace Definit.Results.NewApproach;

public static partial class EitherExtensions 
{
    
    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4> result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3.IsNull();
		t4 = t_4;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4>? result,
        out T0? t0,
		out T1? t1,
		out T2? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
    {
        if(result is null)
        {
            t0 = null;
			t1 = null;
			t2 = null;
			t3 = null;
			t4 = null;
            return;
        }

        var (t_0, t_1, t_2, t_3, t_4) = result.Value.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2;
		t3 = t_3.IsNull();
		t4 = t_4;
    }
	
    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4> result,
        out IsNull<T0>? t0,
		out T1? t1,
		out T2? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1;
		t2 = t_2;
		t3 = t_3.IsNull();
		t4 = t_4;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4>? result,
        out IsNull<T0>? t0,
		out T1? t1,
		out T2? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
    {
        if(result is null)
        {
            t0 = null;
			t1 = null;
			t2 = null;
			t3 = null;
			t4 = null;
            return;
        }

        var (t_0, t_1, t_2, t_3, t_4) = result.Value.Value;

        t0 = t_0.IsNull();
		t1 = t_1;
		t2 = t_2;
		t3 = t_3.IsNull();
		t4 = t_4;
    }
	
    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out T2? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2;
		t3 = t_3.IsNull();
		t4 = t_4;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4>? result,
        out T0? t0,
		out IsNull<T1>? t1,
		out T2? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
    {
        if(result is null)
        {
            t0 = null;
			t1 = null;
			t2 = null;
			t3 = null;
			t4 = null;
            return;
        }

        var (t_0, t_1, t_2, t_3, t_4) = result.Value.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2;
		t3 = t_3.IsNull();
		t4 = t_4;
    }
	
    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out T2? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2;
		t3 = t_3.IsNull();
		t4 = t_4;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4>? result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out T2? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
    {
        if(result is null)
        {
            t0 = null;
			t1 = null;
			t2 = null;
			t3 = null;
			t4 = null;
            return;
        }

        var (t_0, t_1, t_2, t_3, t_4) = result.Value.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2;
		t3 = t_3.IsNull();
		t4 = t_4;
    }
	
    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4> result,
        out T0? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4) = result.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4>? result,
        out T0? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
    {
        if(result is null)
        {
            t0 = null;
			t1 = null;
			t2 = null;
			t3 = null;
			t4 = null;
            return;
        }

        var (t_0, t_1, t_2, t_3, t_4) = result.Value.Value;

        t0 = t_0;
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4;
    }
	
    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4> result,
        out IsNull<T0>? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4>? result,
        out IsNull<T0>? t0,
		out T1? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
    {
        if(result is null)
        {
            t0 = null;
			t1 = null;
			t2 = null;
			t3 = null;
			t4 = null;
            return;
        }

        var (t_0, t_1, t_2, t_3, t_4) = result.Value.Value;

        t0 = t_0.IsNull();
		t1 = t_1;
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4;
    }
	
    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4> result,
        out T0? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4>? result,
        out T0? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
    {
        if(result is null)
        {
            t0 = null;
			t1 = null;
			t2 = null;
			t3 = null;
			t4 = null;
            return;
        }

        var (t_0, t_1, t_2, t_3, t_4) = result.Value.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4;
    }
	
    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
    {
        var (t_0, t_1, t_2, t_3, t_4) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4;
    }

    public static void Deconstruct<T0, T1, T2, T3, T4>
    (
        this Either<T0, T1, T2, T3, T4>? result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1,
		out IsNull<T2>? t2,
		out IsNull<T3>? t3,
		out T4? t4
    )
        where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
    {
        if(result is null)
        {
            t0 = null;
			t1 = null;
			t2 = null;
			t3 = null;
			t4 = null;
            return;
        }

        var (t_0, t_1, t_2, t_3, t_4) = result.Value.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
		t2 = t_2.IsNull();
		t3 = t_3.IsNull();
		t4 = t_4;
    }
}