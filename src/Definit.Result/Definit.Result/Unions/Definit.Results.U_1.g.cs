#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct U<T> : U<T>.Base
	where T : notnull 
{
    public interface Base : IUnionBase<(Or<T>?, Or<System.Exception>?)>;

    public (Or<T>?, Or<System.Exception>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public U() => throw new DefaultConstructorException();
	
	public U(T value) => Value = (value!, null);
	public U(System.Exception value) => Value = (null, value!);
	
	public static implicit operator U<T>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<U<T, System.Exception>>();
	public static implicit operator U<T>(T value) => new (value);
	public static implicit operator U<T>(System.Exception value) => new (value);
}

public static class Extensions_U_1
{
    public static void Deconstruct<T>
	(
	    this U<T> either,
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
	    this U<T>? either,
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
	    this U<T> either,
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
	    this U<T>? either,
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