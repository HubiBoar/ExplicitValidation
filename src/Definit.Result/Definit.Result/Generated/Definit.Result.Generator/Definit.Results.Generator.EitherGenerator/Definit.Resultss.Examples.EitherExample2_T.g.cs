#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Resultss.Examples;

readonly partial struct EitherExample2<T>
	where T : notnull
{
	public (Or<T>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public EitherExample2() => throw new DefaultConstructorException();
	
	public EitherExample2(T value) => Value = (value!);
	
	public static implicit operator Definit.Resultss.Examples.EitherExample2<T>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T>>();
	public static implicit operator Definit.Resultss.Examples.EitherExample2<T>(T value) => new (value);
}

public static partial class EitherExample2__Auto__Extensions
{
    
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.EitherExample2<T> result,
	    out T? T_arg
	)where T : struct
	{
	    (T_arg) = result.Value;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.EitherExample2<T>? result,
	    out T? T_arg
	)where T : struct
	{
	    if(result is null)
	    {
	        T_arg = null;
	        return;
	    }
	
	    (T_arg) = result.Value.Value;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.EitherExample2<T> result,
	    out T? T_arg
	)where T : class
	{
	    (T_arg) = result.Value;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.EitherExample2<T>? result,
	    out T? T_arg
	)where T : class
	{
	    if(result is null)
	    {
	        T_arg = null;
	        return;
	    }
	
	    (T_arg) = result.Value.Value;
	}
	
}
