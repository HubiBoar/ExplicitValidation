#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Either<T0, T1, T2, T3> : Either<T0, T1, T2, T3>.Base
	where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull 
{
    public interface Base : IEitherBase<(Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?)>;

    public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public Either() => throw new DefaultConstructorException();
	
	public Either(T0 value) => Value = (value!, null, null, null);
	public Either(T1 value) => Value = (null, value!, null, null);
	public Either(T2 value) => Value = (null, null, value!, null);
	public Either(T3 value) => Value = (null, null, null, value!);
	
	public static implicit operator Either<T0, T1, T2, T3>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, T3>>();
	public static implicit operator Either<T0, T1, T2, T3>(T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3>(T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3>(T2 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3>(T3 value) => new (value);
}

public static class EitherExtensions_4 
{
    
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3> result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3>
	(
	    this Either<T0, T1, T2, T3>? result,
	    out T0? T0_arg,
		out T1? T1_arg,
		out T2? T2_arg,
		out T3? T3_arg
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg) = result.Value.Value;
	}
	
}