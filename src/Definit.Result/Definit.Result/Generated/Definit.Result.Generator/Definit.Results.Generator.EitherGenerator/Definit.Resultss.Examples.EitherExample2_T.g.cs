#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Resultss.Examples;

readonly partial struct EitherExample2<T>
	where T : notnull
{
	public (Or<T>?, Or<string>?, Or<int>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public EitherExample2() => throw new DefaultConstructorException();
	
	public EitherExample2(T value) => Value = (value!, null, null);
	public EitherExample2(string value) => Value = (null, value!, null);
	public EitherExample2(int value) => Value = (null, null, value!);
	
	public static implicit operator Definit.Resultss.Examples.EitherExample2<T>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T, string, int>>();
	public static implicit operator Definit.Resultss.Examples.EitherExample2<T>(T value) => new (value);
	public static implicit operator Definit.Resultss.Examples.EitherExample2<T>(string value) => new (value);
	public static implicit operator Definit.Resultss.Examples.EitherExample2<T>(int value) => new (value);
}

public static partial class EitherExample2__Auto__Extensions
{
    public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.EitherExample2<T> either,
	    out T? T_arg,
		out string? string_arg,
		out int? int_arg
	)
		where T : struct
	{
	    var (T_out, string_out, int_out) = either.Value;
	    T_arg = T_out?.Out ?? null;
		string_arg = string_out?.Out ?? null;
		int_arg = int_out?.Out ?? null;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.EitherExample2<T>? either,
	    out T? T_arg,
		out string? string_arg,
		out int? int_arg
	)
		where T : struct
	{
	    if(either is null)
	    {
	        T_arg = null; string_arg = null; int_arg = null;
	        return;
	    }
	
	    var (T_out, string_out, int_out) = either.Value.Value;
	    T_arg = T_out?.Out ?? null;
		string_arg = string_out?.Out ?? null;
		int_arg = int_out?.Out ?? null;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.EitherExample2<T> either,
	    out T? T_arg,
		out string? string_arg,
		out int? int_arg
	)
		where T : class
	{
	    var (T_out, string_out, int_out) = either.Value;
	    T_arg = T_out?.Out ?? null;
		string_arg = string_out?.Out ?? null;
		int_arg = int_out?.Out ?? null;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.EitherExample2<T>? either,
	    out T? T_arg,
		out string? string_arg,
		out int? int_arg
	)
		where T : class
	{
	    if(either is null)
	    {
	        T_arg = null; string_arg = null; int_arg = null;
	        return;
	    }
	
	    var (T_out, string_out, int_out) = either.Value.Value;
	    T_arg = T_out?.Out ?? null;
		string_arg = string_out?.Out ?? null;
		int_arg = int_out?.Out ?? null;
	}
}
