#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public interface IUnionInfo<T0, T1, T2, T3, T4, T5> : IUnionBase<(Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?)>
	where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull
	where T5 : notnull;

public readonly struct U<T0, T1, T2, T3, T4, T5> : U<T0, T1, T2, T3, T4, T5>.Base
	where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull
	where T5 : notnull 
{
    public interface Base : IUnionInfo<T0, T1, T2, T3, T4, T5>;

    public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public U() => throw new DefaultConstructorException();
	
	public U(T0 value) => Value = (value!, null, null, null, null, null);
	public U(T1 value) => Value = (null, value!, null, null, null, null);
	public U(T2 value) => Value = (null, null, value!, null, null, null);
	public U(T3 value) => Value = (null, null, null, value!, null, null);
	public U(T4 value) => Value = (null, null, null, null, value!, null);
	public U(T5 value) => Value = (null, null, null, null, null, value!);
	
	public static implicit operator U<T0, T1, T2, T3, T4, T5>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>();
	
	public static implicit operator U<T0, T1, T2, T3, T4, T5>(T0 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4, T5>(T1 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4, T5>(T2 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4, T5>(T3 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4, T5>(T4 value) => new (value);
	public static implicit operator U<T0, T1, T2, T3, T4, T5>(T5 value) => new (value);
	
	public void Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Action<T5> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    switch5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Action<T4> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    switch4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Action<T3> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    switch3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Action<T2> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Action<T1> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Action<T0> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task Switch<TReturn>
	(
	    Func<Async, T0, Task> switch0,
		Func<Async, T1, Task> switch1,
		Func<Async, T2, Task> switch2,
		Func<Async, T3, Task> switch3,
		Func<Async, T4, Task> switch4,
		Func<Async, T5, Task> switch5,
	    Action<System.Exception> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    await switch3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    await switch4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    await switch5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public TReturn Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<T5, TReturn> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return match5(_arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<T4, TReturn> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return match4(_arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<T3, TReturn> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return match3(_arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<T2, TReturn> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<T1, TReturn> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<T0, TReturn> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
	
	public async Task<TReturn> Match<TReturn>
	(
	    Func<Async, T0, Task<TReturn>> match0,
		Func<Async, T1, Task<TReturn>> match1,
		Func<Async, T2, Task<TReturn>> match2,
		Func<Async, T3, Task<TReturn>> match3,
		Func<Async, T4, Task<TReturn>> match4,
		Func<Async, T5, Task<TReturn>> match5,
	    Func<System.Exception, TReturn> onException
	)
	{
	    try
	    {
	        var (_arg0,_arg1,_arg2,_arg3,_arg4,_arg5) = this.Value;
	
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
			
			if (_arg3 is not null)
			{
			    return await match3(Async.Instance, _arg3.Value.Out);
			}
			
			if (_arg4 is not null)
			{
			    return await match4(Async.Instance, _arg4.Value.Out);
			}
			
			if (_arg5 is not null)
			{
			    return await match5(Async.Instance, _arg5.Value.Out);
			} 
	
	    }
	    catch (System.Exception exception)
	    {
	        return onException(exception);
	    }
	
	    throw new Definit.Results.UnionMatchException<U<T0, T1, T2, T3, T4, T5>>(); 
	}
}

public static class Extensions_U_6
{
    public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : struct
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : struct
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : struct
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : struct
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : struct
		where T3 : class
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : struct
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : struct
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
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
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5> either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
	{
	    var (_out_0, _out_1, _out_2, _out_3, _out_4, _out_5) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
		_arg_2 = _out_2?.Out ?? null;
		_arg_3 = _out_3?.Out ?? null;
		_arg_4 = _out_4?.Out ?? null;
		_arg_5 = _out_5?.Out ?? null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5>
	(
	    this U<T0, T1, T2, T3, T4, T5>? either,
	    out T0? _arg_0,
		out T1? _arg_1,
		out T2? _arg_2,
		out T3? _arg_3,
		out T4? _arg_4,
		out T5? _arg_5
	)
		where T0 : class
		where T1 : class
		where T2 : class
		where T3 : class
		where T4 : class
		where T5 : class
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