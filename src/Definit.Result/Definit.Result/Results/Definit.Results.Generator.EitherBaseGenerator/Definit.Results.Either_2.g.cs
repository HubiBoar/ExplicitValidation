﻿#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Either<T0, T1> : Either<T0, T1>.Base
	where T0 : notnull
	where T1 : notnull 
{
    public interface Base : IEitherBase<(Or<T0>?, Or<T1>?)>;

    public (Or<T0>?, Or<T1>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public Either() => throw new DefaultConstructorException();
	
	public Either(T0 value) => Value = (value!, null);
	public Either(T1 value) => Value = (null, value!);
	
	public static implicit operator Either<T0, T1>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1>>();
	public static implicit operator Either<T0, T1>(T0 value) => new (value);
	public static implicit operator Either<T0, T1>(T1 value) => new (value);
}

public static class EitherExtensions_2 
{
    public static void Deconstruct<T0, T1>
	(
	    this Either<T0, T1> either,
	    out T0? T0_arg,
		out T1? T1_arg
	)
		where T0 : struct
		where T1 : struct
	{
	    var (T0_out, T1_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1>
	(
	    this Either<T0, T1>? either,
	    out T0? T0_arg,
		out T1? T1_arg
	)
		where T0 : struct
		where T1 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1>
	(
	    this Either<T0, T1> either,
	    out T0? T0_arg,
		out T1? T1_arg
	)
		where T0 : class
		where T1 : struct
	{
	    var (T0_out, T1_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1>
	(
	    this Either<T0, T1>? either,
	    out T0? T0_arg,
		out T1? T1_arg
	)
		where T0 : class
		where T1 : struct
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1>
	(
	    this Either<T0, T1> either,
	    out T0? T0_arg,
		out T1? T1_arg
	)
		where T0 : struct
		where T1 : class
	{
	    var (T0_out, T1_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1>
	(
	    this Either<T0, T1>? either,
	    out T0? T0_arg,
		out T1? T1_arg
	)
		where T0 : struct
		where T1 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1>
	(
	    this Either<T0, T1> either,
	    out T0? T0_arg,
		out T1? T1_arg
	)
		where T0 : class
		where T1 : class
	{
	    var (T0_out, T1_out) = either.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1>
	(
	    this Either<T0, T1>? either,
	    out T0? T0_arg,
		out T1? T1_arg
	)
		where T0 : class
		where T1 : class
	{
	    if(either is null)
	    {
	        T0_arg = null; T1_arg = null;
	        return;
	    }
	
	    var (T0_out, T1_out) = either.Value.Value;
	    T0_arg = T0_out?.Out ?? null;
		T1_arg = T1_out?.Out ?? null;
	}
}