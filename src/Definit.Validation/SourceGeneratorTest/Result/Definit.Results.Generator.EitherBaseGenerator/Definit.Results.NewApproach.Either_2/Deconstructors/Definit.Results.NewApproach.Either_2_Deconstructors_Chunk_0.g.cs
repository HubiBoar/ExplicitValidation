namespace Definit.Results.NewApproach;

public static partial class EitherExtensions 
{
    
    public static void Deconstruct<T0, T1>
    (
        this Either<T0, T1> result,
        out T0? t0,
		out T1? t1
    )
        where T0 : struct
		where T1 : struct
    {
        var (t_0, t_1) = result.Value;

        t0 = t_0;
		t1 = t_1;
    }
	
    public static void Deconstruct<T0, T1>
    (
        this Either<T0, T1> result,
        out IsNull<T0>? t0,
		out T1? t1
    )
        where T0 : class
		where T1 : struct
    {
        var (t_0, t_1) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1;
    }
	
    public static void Deconstruct<T0, T1>
    (
        this Either<T0, T1> result,
        out T0? t0,
		out IsNull<T1>? t1
    )
        where T0 : struct
		where T1 : class
    {
        var (t_0, t_1) = result.Value;

        t0 = t_0;
		t1 = t_1.IsNull();
    }
	
    public static void Deconstruct<T0, T1>
    (
        this Either<T0, T1> result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1
    )
        where T0 : class
		where T1 : class
    {
        var (t_0, t_1) = result.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
    }

    public static void Deconstruct<T0, T1>
    (
        this Either<T0, T1>? result,
        out IsNull<T0>? t0,
		out IsNull<T1>? t1
    )
        where T0 : class
		where T1 : class
    {
        if(result is null)
        {
            t0 = null;
            t1 = null;
            return;
        }

        var (t_0, t_1) = result.Value.Value;

        t0 = t_0.IsNull();
		t1 = t_1.IsNull();
    }
}
