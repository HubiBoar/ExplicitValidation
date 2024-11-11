#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Resultss.Examples;

readonly partial struct ResultExample<T>
	where T : notnull
{
	public (Or<T>?, Or<Definit.Resultss.Examples.NotFound>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public ResultExample() => throw new DefaultConstructorException();
	
	public ResultExample(T value) => Value = (value!, null);
	public ResultExample(Definit.Resultss.Examples.NotFound value) => Value = (null, value!);
	
	public static implicit operator Definit.Resultss.Examples.ResultExample<T>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<U<T, Definit.Resultss.Examples.NotFound>>();
	public static implicit operator Definit.Resultss.Examples.ResultExample<T>(T value) => new (value);
	public static implicit operator Definit.Resultss.Examples.ResultExample<T>(Definit.Resultss.Examples.NotFound value) => new (value);
}

public static partial class ResultExample_Extensions_U
{
    public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.ResultExample<T> either,
	    out T? _arg_0,
		out Definit.Resultss.Examples.NotFound? _arg_1
	)
		where T : struct
	{
	    var (_out_0, _out_1) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.ResultExample<T>? either,
	    out T? _arg_0,
		out Definit.Resultss.Examples.NotFound? _arg_1
	)
		where T : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null;
	        return;
	    }
	
	    var (_out_0, _out_1) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.ResultExample<T> either,
	    out T? _arg_0,
		out Definit.Resultss.Examples.NotFound? _arg_1
	)
		where T : class
	{
	    var (_out_0, _out_1) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.ResultExample<T>? either,
	    out T? _arg_0,
		out Definit.Resultss.Examples.NotFound? _arg_1
	)
		where T : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null;
	        return;
	    }
	
	    var (_out_0, _out_1) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
}