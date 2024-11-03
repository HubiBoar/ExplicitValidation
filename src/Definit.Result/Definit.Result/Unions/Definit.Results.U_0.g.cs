#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct U : U.Base 
{
    public interface Base : IUnionBase<(Or<Definit.Results.Success>?, Or<System.Exception>?)>;

    public (Or<Definit.Results.Success>?, Or<System.Exception>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public U() => throw new DefaultConstructorException();
	
	public U(Definit.Results.Success value) => Value = (value!, null);
	public U(System.Exception value) => Value = (null, value!);
	
	public static implicit operator U([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<U<Definit.Results.Success, System.Exception>>();
	public static implicit operator U(Definit.Results.Success value) => new (value);
	public static implicit operator U(System.Exception value) => new (value);
}

public static class Extensions_U_0
{
    public static void Deconstruct
	(
	    this U either,
	    out Definit.Results.Success? _arg_0,
		out System.Exception? _arg_1
	)
	{
	    var (_out_0, _out_1) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct
	(
	    this U? either,
	    out Definit.Results.Success? _arg_0,
		out System.Exception? _arg_1
	)
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