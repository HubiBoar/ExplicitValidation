#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

readonly partial struct R<T0, T1, T2, T3, T4>
	where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull
{
	public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<System.Exception>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public R() => throw new DefaultConstructorException();
	
	public R(T0 value) => Value = (value!, null, null, null, null, null);
	public R(T1 value) => Value = (null, value!, null, null, null, null);
	public R(T2 value) => Value = (null, null, value!, null, null, null);
	public R(T3 value) => Value = (null, null, null, value!, null, null);
	public R(T4 value) => Value = (null, null, null, null, value!, null);
	public R(System.Exception value) => Value = (null, null, null, null, null, value!);
	
	public static implicit operator Definit.Results.R<T0, T1, T2, T3, T4>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, System.Exception>>();
	public static implicit operator Definit.Results.R<T0, T1, T2, T3, T4>(T0 value) => new (value);
	public static implicit operator Definit.Results.R<T0, T1, T2, T3, T4>(T1 value) => new (value);
	public static implicit operator Definit.Results.R<T0, T1, T2, T3, T4>(T2 value) => new (value);
	public static implicit operator Definit.Results.R<T0, T1, T2, T3, T4>(T3 value) => new (value);
	public static implicit operator Definit.Results.R<T0, T1, T2, T3, T4>(T4 value) => new (value);
	public static implicit operator Definit.Results.R<T0, T1, T2, T3, T4>(System.Exception value) => new (value);
}

public static partial class R_Extensions_U
{
    public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4>
	(
	    this Definit.Results.R<T0, T1, T2, T3, T4>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out System.Exception? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null; _arg_3 = null; _arg_4 = null; _arg_5 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
}