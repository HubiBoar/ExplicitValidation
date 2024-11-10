#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

readonly partial struct R<T>
	where T : notnull
{
	public (Or<T>?, Or<System.Exception>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public R() => throw new DefaultConstructorException();
	
	public R(T value) => Value = (value!, null);
	public R(System.Exception value) => Value = (null, value!);
	
	public static implicit operator Definit.Results.R<T>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<U<T, System.Exception>>();
	public static implicit operator Definit.Results.R<T>(T value) => new (value);
	public static implicit operator Definit.Results.R<T>(System.Exception value) => new (value);
}

public static partial class R_Extensions_U
{
    public static void Deconstruct<T>
	(
	    this Definit.Results.R<T> either,
	    out T? _arg_0,
		out System.Exception? _arg_1
	)
		where T : struct
	{
	    var (_out_0, _out_1) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Results.R<T>? either,
	    out T? _arg_0,
		out System.Exception? _arg_1
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
	    this Definit.Results.R<T> either,
	    out T? _arg_0,
		out System.Exception? _arg_1
	)
		where T : class
	{
	    var (_out_0, _out_1) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Results.R<T>? either,
	    out T? _arg_0,
		out System.Exception? _arg_1
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