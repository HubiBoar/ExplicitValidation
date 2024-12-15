#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Success;
public readonly struct NotFound;

public static class U
{
    public static Success Success { get; } = new Success();
}

//[Union]
public readonly partial struct U<TError> : U<Success, TError>.Base
    where TError : notnull
{
}

readonly partial struct U<TError>
	where TError : notnull
{
	public (Or<Definit.Results.Success>?, Or<TError>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public U() => throw new DefaultConstructorException();
	
	public U(Definit.Results.Success value) => Value = (value!, null);
	public U(TError value) => Value = (null, value!);
	
	public static implicit operator Definit.Results.U<TError>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<Definit.Results.U<TError>>();
	
	public static implicit operator Definit.Results.U<TError>(Definit.Results.Success value) => new (value);
	public static implicit operator Definit.Results.U<TError>(TError value) => new (value);
	
	public void Switch
	(
	    Action<Definit.Results.Success> switch0,
		Action<TError> switch1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Results.U<TError>>(); 
	}
	
	public async Task Switch
	(
	    Func<Async, Definit.Results.Success, Task> switch0,
		Action<TError> switch1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Results.U<TError>>(); 
	}
	
	public async Task Switch
	(
	    Action<Definit.Results.Success> switch0,
		Func<Async, TError, Task> switch1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Results.U<TError>>(); 
	}
	
	public async Task Switch
	(
	    Func<Async, Definit.Results.Success, Task> switch0,
		Func<Async, TError, Task> switch1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Results.U<TError>>(); 
	}
	
	public TReturn Match<TReturn>
	(
	    Func<Definit.Results.Success, TReturn> match0,
		Func<TError, TReturn> match1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Results.U<TError>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, Definit.Results.Success, Task<TReturn>> match0,
		Func<TError, TReturn> match1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Results.U<TError>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Definit.Results.Success, TReturn> match0,
		Func<Async, TError, Task<TReturn>> match1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Results.U<TError>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, Definit.Results.Success, Task<TReturn>> match0,
		Func<Async, TError, Task<TReturn>> match1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Results.U<TError>>(); 
	}
}

public static partial class U_Extensions_U
{
    public static void Deconstruct<TError>
	(
	    this Definit.Results.U<TError> either,
	    out Definit.Results.Success? _arg_0,
		out TError? _arg_1
	)
		where TError : struct
	{
	    var (_out_0, _out_1) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct<TError>
	(
	    this Definit.Results.U<TError>? either,
	    out Definit.Results.Success? _arg_0,
		out TError? _arg_1
	)
		where TError : struct
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
	
	public static void Deconstruct<TError>
	(
	    this Definit.Results.U<TError> either,
	    out Definit.Results.Success? _arg_0,
		out TError? _arg_1
	)
		where TError : class
	{
	    var (_out_0, _out_1) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct<TError>
	(
	    this Definit.Results.U<TError>? either,
	    out Definit.Results.Success? _arg_0,
		out TError? _arg_1
	)
		where TError : class
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
