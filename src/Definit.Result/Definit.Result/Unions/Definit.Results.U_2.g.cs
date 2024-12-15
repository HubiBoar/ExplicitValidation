#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public interface IUnionInfo<T0, T1> : IUnionBase<(Or<T0>?, Or<T1>?)>
	where T0 : notnull
	where T1 : notnull;

public readonly struct U<T0, T1> : U<T0, T1>.Base
	where T0 : notnull
	where T1 : notnull 
{
    public interface Base : IUnionInfo<T0, T1>;

    public (Or<T0>?, Or<T1>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public U() => throw new DefaultConstructorException();
	
	public U(T0 value) => Value = (value!, null);
	public U(T1 value) => Value = (null, value!);
	
	public static implicit operator U<T0, T1>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<U<T0, T1>>();
	
	public static implicit operator U<T0, T1>(T0 value) => new (value);
	public static implicit operator U<T0, T1>(T1 value) => new (value);
	
	public void Switch
	(
	    Action<T0> switch0,
		Action<T1> switch1,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1) = this.Value;
	
	        if (_arg0 is not null)
			{
			    switch0(_arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    switch1(_arg1.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1>>(); 
	}
	
	public async Task Switch
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1) = this.Value;
	
	        if (_arg0 is not null)
			{
			    await switch0(Async.Instance, _arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    switch1(_arg1.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1>>(); 
	}
	
	public async Task Switch
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1) = this.Value;
	
	        if (_arg0 is not null)
			{
			    switch0(_arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    await switch1(Async.Instance, _arg1.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1>>(); 
	}
	
	public async Task Switch
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1) = this.Value;
	
	        if (_arg0 is not null)
			{
			    await switch0(Async.Instance, _arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    await switch1(Async.Instance, _arg1.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1>>(); 
	}
	
	public TReturn Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1) = this.Value;
	
	        if (_arg0 is not null)
			{
			    return match0(_arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    return match1(_arg1.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1) = this.Value;
	
	        if (_arg0 is not null)
			{
			    return await match0(Async.Instance, _arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    return match1(_arg1.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1) = this.Value;
	
	        if (_arg0 is not null)
			{
			    return match0(_arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    return await match1(Async.Instance, _arg1.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1) = this.Value;
	
	        if (_arg0 is not null)
			{
			    return await match0(Async.Instance, _arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    return await match1(Async.Instance, _arg1.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1>>(); 
	}
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