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
	
	public static implicit operator Definit.Resultss.Examples.ResultExample<T>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample<T>>();
	
	public static implicit operator Definit.Resultss.Examples.ResultExample<T>(T value) => new (value);
	public static implicit operator Definit.Resultss.Examples.ResultExample<T>(Definit.Resultss.Examples.NotFound value) => new (value);
	
	public void Switch
	(
	    Action<T> switch0,
		Action<Definit.Resultss.Examples.NotFound> switch1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample<T>>(); 
	}
	
	public async Task Switch
	(
	    Func<Async, T, Task> switch0,
		Action<Definit.Resultss.Examples.NotFound> switch1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample<T>>(); 
	}
	
	public async Task Switch
	(
	    Action<T> switch0,
		Func<Async, Definit.Resultss.Examples.NotFound, Task> switch1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample<T>>(); 
	}
	
	public async Task Switch
	(
	    Func<Async, T, Task> switch0,
		Func<Async, Definit.Resultss.Examples.NotFound, Task> switch1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample<T>>(); 
	}
	
	public TReturn Match<TReturn>
	(
	    Func<T, TReturn> match0,
		Func<Definit.Resultss.Examples.NotFound, TReturn> match1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample<T>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T, Task<TReturn>> match0,
		Func<Definit.Resultss.Examples.NotFound, TReturn> match1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample<T>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T, TReturn> match0,
		Func<Async, Definit.Resultss.Examples.NotFound, Task<TReturn>> match1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample<T>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T, Task<TReturn>> match0,
		Func<Async, Definit.Resultss.Examples.NotFound, Task<TReturn>> match1,
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
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample<T>>(); 
	}
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