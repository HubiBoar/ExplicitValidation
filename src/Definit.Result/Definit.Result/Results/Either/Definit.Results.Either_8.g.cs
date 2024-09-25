﻿#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Either<T0, T1, T2, T3, T4, T5, T6, T7> : Either<T0, T1, T2, T3, T4, T5, T6, T7>.Base
	where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull
	where T5 : notnull
	where T6 : notnull
	where T7 : notnull 
{
    public interface Base : IEitherBase<(Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?, Or<T6>?, Or<T7>?)>;

    public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?, Or<T6>?, Or<T7>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public Either() => throw new DefaultConstructorException();
	
	public Either(T0 value) => Value = (value!, null, null, null, null, null, null, null);
	public Either(T1 value) => Value = (null, value!, null, null, null, null, null, null);
	public Either(T2 value) => Value = (null, null, value!, null, null, null, null, null);
	public Either(T3 value) => Value = (null, null, null, value!, null, null, null, null);
	public Either(T4 value) => Value = (null, null, null, null, value!, null, null, null);
	public Either(T5 value) => Value = (null, null, null, null, null, value!, null, null);
	public Either(T6 value) => Value = (null, null, null, null, null, null, value!, null);
	public Either(T7 value) => Value = (null, null, null, null, null, null, null, value!);
	
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, T3, T4, T5, T6, T7>>();
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7>(T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7>(T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7>(T2 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7>(T3 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7>(T4 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7>(T5 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7>(T6 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7>(T7 value) => new (value);
}

public static class EitherExtensions_8 
{
    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : struct
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
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
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
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
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
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
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
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
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
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
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
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
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
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
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
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
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
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
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
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
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
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
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
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
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7> either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7>? either,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg,
		out T4? T4_arg,
		out T5? T5_arg,
		out T6? T6_arg,
		out T7? T7_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
		where T6 : class
		where T7 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg) = either.Value.Value;
	}
}