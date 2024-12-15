#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Resultss.Examples;

readonly partial struct ResultExample2<T>
	where T : notnull
{
	public (Or<T>?, Or<string>?, Or<Definit.Resultss.Examples.NotFound>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public ResultExample2() => throw new DefaultConstructorException();
	
	public ResultExample2(T value) => Value = (value!, null, null);
	public ResultExample2(string value) => Value = (null, value!, null);
	public ResultExample2(Definit.Resultss.Examples.NotFound value) => Value = (null, null, value!);
	
	public static implicit operator Definit.Resultss.Examples.ResultExample2<T>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>();
	
	public static implicit operator Definit.Resultss.Examples.ResultExample2<T>(T value) => new (value);
	public static implicit operator Definit.Resultss.Examples.ResultExample2<T>(string value) => new (value);
	public static implicit operator Definit.Resultss.Examples.ResultExample2<T>(Definit.Resultss.Examples.NotFound value) => new (value);
	
	public void Switch<TReturn>
	(
	    Action<T> switch0,
		Action<string> switch1,
		Action<Definit.Resultss.Examples.NotFound> switch2,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    switch0(_arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    switch1(_arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    switch2(_arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T, Task> switch0,
		Action<string> switch1,
		Action<Definit.Resultss.Examples.NotFound> switch2,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    await switch0(Async.Instance, _arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    switch1(_arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    switch2(_arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T> switch0,
		Func<Async, string, Task> switch1,
		Action<Definit.Resultss.Examples.NotFound> switch2,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    switch0(_arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    await switch1(Async.Instance, _arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    switch2(_arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T, Task> switch0,
		Func<Async, string, Task> switch1,
		Action<Definit.Resultss.Examples.NotFound> switch2,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    await switch0(Async.Instance, _arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    await switch1(Async.Instance, _arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    switch2(_arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T> switch0,
		Action<string> switch1,
		Func<Async, Definit.Resultss.Examples.NotFound, Task> switch2,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    switch0(_arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    switch1(_arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    await switch2(Async.Instance, _arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T, Task> switch0,
		Action<string> switch1,
		Func<Async, Definit.Resultss.Examples.NotFound, Task> switch2,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    await switch0(Async.Instance, _arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    switch1(_arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    await switch2(Async.Instance, _arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T> switch0,
		Func<Async, string, Task> switch1,
		Func<Async, Definit.Resultss.Examples.NotFound, Task> switch2,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    switch0(_arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    await switch1(Async.Instance, _arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    await switch2(Async.Instance, _arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T, Task> switch0,
		Func<Async, string, Task> switch1,
		Func<Async, Definit.Resultss.Examples.NotFound, Task> switch2,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    await switch0(Async.Instance, _arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    await switch1(Async.Instance, _arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    await switch2(Async.Instance, _arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public TReturn Match<TReturn>
	(
	    Func<T, TReturn> match0,
		Func<string, TReturn> match1,
		Func<Definit.Resultss.Examples.NotFound, TReturn> match2,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    return match0(_arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    return match1(_arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    return match2(_arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T, Task<TReturn>> match0,
		Func<string, TReturn> match1,
		Func<Definit.Resultss.Examples.NotFound, TReturn> match2,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    return await match0(Async.Instance, _arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    return match1(_arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    return match2(_arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T, TReturn> match0,
		Func<Async, string, Task<TReturn>> match1,
		Func<Definit.Resultss.Examples.NotFound, TReturn> match2,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    return match0(_arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    return await match1(Async.Instance, _arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    return match2(_arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T, Task<TReturn>> match0,
		Func<Async, string, Task<TReturn>> match1,
		Func<Definit.Resultss.Examples.NotFound, TReturn> match2,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    return await match0(Async.Instance, _arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    return await match1(Async.Instance, _arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    return match2(_arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T, TReturn> match0,
		Func<string, TReturn> match1,
		Func<Async, Definit.Resultss.Examples.NotFound, Task<TReturn>> match2,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    return match0(_arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    return match1(_arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    return await match2(Async.Instance, _arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T, Task<TReturn>> match0,
		Func<string, TReturn> match1,
		Func<Async, Definit.Resultss.Examples.NotFound, Task<TReturn>> match2,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    return await match0(Async.Instance, _arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    return match1(_arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    return await match2(Async.Instance, _arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T, TReturn> match0,
		Func<Async, string, Task<TReturn>> match1,
		Func<Async, Definit.Resultss.Examples.NotFound, Task<TReturn>> match2,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    return match0(_arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    return await match1(Async.Instance, _arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    return await match2(Async.Instance, _arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T, Task<TReturn>> match0,
		Func<Async, string, Task<TReturn>> match1,
		Func<Async, Definit.Resultss.Examples.NotFound, Task<TReturn>> match2,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2) = this.Value;
	
	        if (_arg0 is not null)
			{
			    return await match0(Async.Instance, _arg0.Value.Out);
			}
			
			if (_arg1 is not null)
			{
			    return await match1(Async.Instance, _arg1.Value.Out);
			}
			
			if (_arg2 is not null)
			{
			    return await match2(Async.Instance, _arg2.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<Definit.Resultss.Examples.ResultExample2<T>>(); 
	}
}

public static partial class ResultExample2_Extensions_U
{
    public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.ResultExample2<T> either,
	    out T? _arg_0,
		out string? _arg_1,
		out Definit.Resultss.Examples.NotFound? _arg_2
	)
		where T : struct
	{
	    var (_out_0, _out_1, _out_2) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.ResultExample2<T>? either,
	    out T? _arg_0,
		out string? _arg_1,
		out Definit.Resultss.Examples.NotFound? _arg_2
	)
		where T : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.ResultExample2<T> either,
	    out T? _arg_0,
		out string? _arg_1,
		out Definit.Resultss.Examples.NotFound? _arg_2
	)
		where T : class
	{
	    var (_out_0, _out_1, _out_2) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
	
	public static void Deconstruct<T>
	(
	    this Definit.Resultss.Examples.ResultExample2<T>? either,
	    out T? _arg_0,
		out string? _arg_1,
		out Definit.Resultss.Examples.NotFound? _arg_2
	)
		where T : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null; _arg_2 = null;
	        return;
	    }
	
	    var (_out_0, _out_1, _out_2) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
}