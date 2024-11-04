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
	
	public static implicit operator Definit.Resultss.Examples.EitherExample2<T>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<U<T, string, int>>();
	public static implicit operator Definit.Resultss.Examples.EitherExample2<T>(T value) => new (value);
	public static implicit operator Definit.Resultss.Examples.EitherExample2<T>(string value) => new (value);
	public static implicit operator Definit.Resultss.Examples.EitherExample2<T>(int value) => new (value);
}

public static partial class EitherExample2_Extensions_U
{
    public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.EitherExample2<T> either,
	    out T? _arg_0,
		out string? _arg_1,
		out int? _arg_2
	)
		where T : struct
	{
	    var (_out_0, _out_1, _out_2) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.EitherExample2<T>? either,
	    out T? _arg_0,
		out string? _arg_1,
		out int? _arg_2
	)
		where T : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.EitherExample2<T> either,
	    out T? _arg_0,
		out string? _arg_1,
		out int? _arg_2
	)
		where T : class
	{
	    var (_out_0, _out_1, _out_2) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.EitherExample2<T>? either,
	    out T? _arg_0,
		out string? _arg_1,
		out int? _arg_2
	)
		where T : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
}