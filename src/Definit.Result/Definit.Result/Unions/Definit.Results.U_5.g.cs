#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct U<T0, T1, T2, T3, T4> : U<T0, T1, T2, T3, T4>.Base
	where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull 
{
    public interface Base : IUnionBase<(Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?)>;

    public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public U() => throw new DefaultConstructorException();
	
	public U(T0 value) => Value = (value!, null, null, null, null);
	public U(T1 value) => Value = (null, value!, null, null, null);
	public U(T2 value) => Value = (null, null, value!, null, null);
	public U(T3 value) => Value = (null, null, null, value!, null);
	public U(T4 value) => Value = (null, null, null, null, value!);
	
	public static implicit operator U<T0, T1, T2, T3, T4>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4>>();
	public static implicit operator U<T0, T1, T2, T3, T4>(T0 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4>(T1 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4>(T2 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4>(T3 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4>(T4 value) => new (value);
}

public static class Extensions_U_5
{
    public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this U<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
	}
}