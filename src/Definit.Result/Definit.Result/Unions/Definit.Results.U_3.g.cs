#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public interface IUnionInfo<T0, T1, T2> : IUnionBase<(Or<T0>?, Or<T1>?, Or<T2>?)>
	where T0 : notnull
	where T1 : notnull
	where T2 : notnull;

public readonly struct U<T0, T1, T2> : U<T0, T1, T2>.Base
	where T0 : notnull
	where T1 : notnull
	where T2 : notnull 
{
    public interface Base : IUnionInfo<T0, T1, T2>;

    public (Or<T0>?, Or<T1>?, Or<T2>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public U() => throw new DefaultConstructorException();
	
	public U(T0 value) => Value = (value!, null, null);
	public U(T1 value) => Value = (null, value!, null);
	public U(T2 value) => Value = (null, null, value!);
	
	public static implicit operator U<T0, T1, T2>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>();
	
	public static implicit operator U<T0, T1, T2>(T0 value) => new (value);
	public static implicit operator U<T0, T1, T2>(T1 value) => new (value);
	public static implicit operator U<T0, T1, T2>(T2 value) => new (value);
	
	public void Switch
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public async Task Switch
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public async Task Switch
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public async Task Switch
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public async Task Switch
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public async Task Switch
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public async Task Switch
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public async Task Switch
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public TReturn Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
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
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2>>(); 
	}
}

public static class Extensions_U_3
{
    public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
	{
	    var (_out_0, _out_1, _out_2) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
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
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
	{
	    var (_out_0, _out_1, _out_2) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
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
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
	{
	    var (_out_0, _out_1, _out_2) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
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
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : class
		where T1 : class
		where T2 : struct
	{
	    var (_out_0, _out_1, _out_2) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : class
		where T1 : class
		where T2 : struct
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
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
	{
	    var (_out_0, _out_1, _out_2) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
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
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : class
		where T1 : struct
		where T2 : class
	{
	    var (_out_0, _out_1, _out_2) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : class
		where T1 : struct
		where T2 : class
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
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : struct
		where T1 : class
		where T2 : class
	{
	    var (_out_0, _out_1, _out_2) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : struct
		where T1 : class
		where T2 : class
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
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : class
		where T1 : class
		where T2 : class
	{
	    var (_out_0, _out_1, _out_2) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2>
	(
	    this U<T0, T1, T2>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2
	)
		where T0 : class
		where T1 : class
		where T2 : class
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