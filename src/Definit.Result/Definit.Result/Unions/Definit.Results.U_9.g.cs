#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct U<T0, T1, T2, T3, T4, T5, T6, T7, T8> : U<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Base
	where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull
	where T5 : notnull
	where T6 : notnull
	where T7 : notnull
	where T8 : notnull 
{
    public interface Base : IUnionBase<(Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?, Or<T6>?, Or<T7>?, Or<T8>?)>;

    public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?, Or<T6>?, Or<T7>?, Or<T8>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public U() => throw new DefaultConstructorException();
	
	public U(T0 value) => Value = (value!, null, null, null, null, null, null, null, null);
	public U(T1 value) => Value = (null, value!, null, null, null, null, null, null, null);
	public U(T2 value) => Value = (null, null, value!, null, null, null, null, null, null);
	public U(T3 value) => Value = (null, null, null, value!, null, null, null, null, null);
	public U(T4 value) => Value = (null, null, null, null, value!, null, null, null, null);
	public U(T5 value) => Value = (null, null, null, null, null, value!, null, null, null);
	public U(T6 value) => Value = (null, null, null, null, null, null, value!, null, null);
	public U(T7 value) => Value = (null, null, null, null, null, null, null, value!, null);
	public U(T8 value) => Value = (null, null, null, null, null, null, null, null, value!);
	
	public static implicit operator U<T0, T1, T2, T3, T4, T5, T6, T7, T8>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5, T6, T7, T8>>();
	public static implicit operator U<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T1 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T2 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T3 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T4 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T5 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T6 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T7 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T8 value) => new (value);
}

public static class Extensions_U_9
{
    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	(
	    this U<T0, T1, T2, T3, T4, T5, T6, T7, T8> either,
	    out U<T0, T1, T2, T3, T4>? _arg_0,
		out U<T5, T6, T7, T8>? _arg_1
	)
		where T0 : notnull
		where T1 : notnull
		where T2 : notnull
		where T3 : notnull
		where T4 : notnull
		where T5 : notnull
		where T6 : notnull
		where T7 : notnull
		where T8 : notnull
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5, _out_6, _out_7, _out_8) = either.Value;
	    _arg_0 = _out_0 is not null ? new (_out_0.Value.Out) : _out_1 is not null ? new (_out_1.Value.Out) : _out_2 is not null ? new (_out_2.Value.Out) : _out_3 is not null ? new (_out_3.Value.Out) : _out_4 is not null ? new (_out_4.Value.Out) : null;
		_arg_1 = _out_5 is not null ? new (_out_5.Value.Out) : _out_6 is not null ? new (_out_6.Value.Out) : _out_7 is not null ? new (_out_7.Value.Out) : _out_8 is not null ? new (_out_8.Value.Out) : null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	(
	    this U<T0, T1, T2, T3, T4, T5, T6, T7, T8>? either,
	    out U<T0, T1, T2, T3, T4>? _arg_0,
		out U<T5, T6, T7, T8>? _arg_1
	)
		where T0 : notnull
		where T1 : notnull
		where T2 : notnull
		where T3 : notnull
		where T4 : notnull
		where T5 : notnull
		where T6 : notnull
		where T7 : notnull
		where T8 : notnull
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5, _out_6, _out_7, _out_8) = either.Value.Value;
	    _arg_0 = _out_0 is not null ? new (_out_0.Value.Out) : _out_1 is not null ? new (_out_1.Value.Out) : _out_2 is not null ? new (_out_2.Value.Out) : _out_3 is not null ? new (_out_3.Value.Out) : _out_4 is not null ? new (_out_4.Value.Out) : null;
		_arg_1 = _out_5 is not null ? new (_out_5.Value.Out) : _out_6 is not null ? new (_out_6.Value.Out) : _out_7 is not null ? new (_out_7.Value.Out) : _out_8 is not null ? new (_out_8.Value.Out) : null;
	}
}