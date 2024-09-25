#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Either<T0, T1, T2> : Either<T0, T1, T2>.Base
	where T0 : notnull
	where T1 : notnull
	where T2 : notnull 
{
    public interface Base : IEitherBase<(Or<T0>?, Or<T1>?, Or<T2>?)>;

    public (Or<T0>?, Or<T1>?, Or<T2>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public Either() => throw new DefaultConstructorException();
	
	public Either(T0 value) => Value = (value!, null, null);
	public Either(T1 value) => Value = (null, value!, null);
	public Either(T2 value) => Value = (null, null, value!);
	
	public static implicit operator Either<T0, T1, T2>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2>>();
	public static implicit operator Either<T0, T1, T2>(T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2>(T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2>(T2 value) => new (value);
}

public static class EitherExtensions_3 
{
    public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
	{
	    var (T0_out, T1_out, T2_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
	{
	    var (T0_out, T1_out, T2_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
	{
	    var (T0_out, T1_out, T2_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
	{
	    var (T0_out, T1_out, T2_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
	{
	    var (T0_out, T1_out, T2_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
	{
	    var (T0_out, T1_out, T2_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
	{
	    var (T0_out, T1_out, T2_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
	{
	    var (T0_out, T1_out, T2_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this Either<T0, T1, T2>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out, T2_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
		T2_arg = T2_out?.Out ?? null;
	}
}