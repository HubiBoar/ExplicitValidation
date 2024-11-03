#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct U<T0, T1> : U<T0, T1>.Base
	where T0 : notnull
	where T1 : notnull 
{
    public interface Base : IUnionBase<(Or<T0>?, Or<T1>?)>;

    public (Or<T0>?, Or<T1>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public U() => throw new DefaultConstructorException();
	
	public U(T0 value) => Value = (value!, null);
	public U(T1 value) => Value = (null, value!);
	
	public static implicit operator U<T0, T1>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<U<T0, T1>>();
	public static implicit operator U<T0, T1>(T0 value) => new (value);
	public static implicit operator U<T0, T1>(T1 value) => new (value);
}

public static class Extensions_U_2
{
    public static void Deconstruct<T0, T1>
	(
	    this U<T0, T1> either,
	    out T0? _arg_0,
		out T1? _arg_1
	)
		where T0 : struct
		where T1 : struct
	{
	    var (_out_0, _out_1) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1>
	(
	    this U<T0, T1>? either,
	    out T0? _arg_0,
		out T1? _arg_1
	)
		where T0 : struct
		where T1 : struct
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
	
	public static void Deconstruct<T0, T1>
	(
	    this U<T0, T1> either,
	    out T0? _arg_0,
		out T1? _arg_1
	)
		where T0 : class
		where T1 : struct
	{
	    var (_out_0, _out_1) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1>
	(
	    this U<T0, T1>? either,
	    out T0? _arg_0,
		out T1? _arg_1
	)
		where T0 : class
		where T1 : struct
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
	
	public static void Deconstruct<T0, T1>
	(
	    this U<T0, T1> either,
	    out T0? _arg_0,
		out T1? _arg_1
	)
		where T0 : struct
		where T1 : class
	{
	    var (_out_0, _out_1) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1>
	(
	    this U<T0, T1>? either,
	    out T0? _arg_0,
		out T1? _arg_1
	)
		where T0 : struct
		where T1 : class
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
	
	public static void Deconstruct<T0, T1>
	(
	    this U<T0, T1> either,
	    out T0? _arg_0,
		out T1? _arg_1
	)
		where T0 : class
		where T1 : class
	{
	    var (_out_0, _out_1) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1>
	(
	    this U<T0, T1>? either,
	    out T0? _arg_0,
		out T1? _arg_1
	)
		where T0 : class
		where T1 : class
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