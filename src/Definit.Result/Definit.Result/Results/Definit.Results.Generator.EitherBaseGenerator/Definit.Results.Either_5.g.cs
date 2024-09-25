#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Either<T0, T1, T2, T3, T4> : Either<T0, T1, T2, T3, T4>.Base
	where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull 
{
    public interface Base : IEitherBase<(Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?)>;

    public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public Either() => throw new DefaultConstructorException();
	
	public Either(T0 value) => Value = (value!, null, null, null, null);
	public Either(T1 value) => Value = (null, value!, null, null, null);
	public Either(T2 value) => Value = (null, null, value!, null, null);
	public Either(T3 value) => Value = (null, null, null, value!, null);
	public Either(T4 value) => Value = (null, null, null, null, value!);
	
	public static implicit operator Either<T0, T1, T2, T3, T4>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, T3, T4>>();
	public static implicit operator Either<T0, T1, T2, T3, T4>(T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(T2 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(T3 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4>(T4 value) => new (value);
}

public static class EitherExtensions_5 
{
    public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Either<T0, T1, T2, T3, T4>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out, T3_out, T4_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
		T3_arg = T3_out?.Out ?? null;
		T4_arg = T4_out?.Out ?? null;
	}
}