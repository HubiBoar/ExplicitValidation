#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace System.Threading.Tasks;


public static class TryTask<TResult>
{
    public static U<System.Threading.Tasks.Task<TResult>, System.Exception> New(System.Func<object?, TResult> function, object? state) 
	{
	    try
	    {
	        return new System.Threading.Tasks.Task<TResult>(function, state);
	    }
	    catch (Exception exception)
	    {
	        return exception;
	    }
	}
	
	public static U<System.Threading.Tasks.Task<TResult>, System.Exception> New(System.Func<object?, TResult> function, object? state, System.Threading.CancellationToken cancellationToken) 
	{
	    try
	    {
	        return new System.Threading.Tasks.Task<TResult>(function, state, cancellationToken);
	    }
	    catch (Exception exception)
	    {
	        return exception;
	    }
	}
	
	public static U<System.Threading.Tasks.Task<TResult>, System.Exception> New(System.Func<object?, TResult> function, object? state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskCreationOptions creationOptions) 
	{
	    try
	    {
	        return new System.Threading.Tasks.Task<TResult>(function, state, cancellationToken, creationOptions);
	    }
	    catch (Exception exception)
	    {
	        return exception;
	    }
	}
	
	public static U<System.Threading.Tasks.Task<TResult>, System.Exception> New(System.Func<object?, TResult> function, object? state, System.Threading.Tasks.TaskCreationOptions creationOptions) 
	{
	    try
	    {
	        return new System.Threading.Tasks.Task<TResult>(function, state, creationOptions);
	    }
	    catch (Exception exception)
	    {
	        return exception;
	    }
	}
	
	public static U<System.Threading.Tasks.Task<TResult>, System.Exception> New(System.Func<TResult> function) 
	{
	    try
	    {
	        return new System.Threading.Tasks.Task<TResult>(function);
	    }
	    catch (Exception exception)
	    {
	        return exception;
	    }
	}
	
	public static U<System.Threading.Tasks.Task<TResult>, System.Exception> New(System.Func<TResult> function, System.Threading.CancellationToken cancellationToken) 
	{
	    try
	    {
	        return new System.Threading.Tasks.Task<TResult>(function, cancellationToken);
	    }
	    catch (Exception exception)
	    {
	        return exception;
	    }
	}
	
	public static U<System.Threading.Tasks.Task<TResult>, System.Exception> New(System.Func<TResult> function, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskCreationOptions creationOptions) 
	{
	    try
	    {
	        return new System.Threading.Tasks.Task<TResult>(function, cancellationToken, creationOptions);
	    }
	    catch (Exception exception)
	    {
	        return exception;
	    }
	}
	
	public static U<System.Threading.Tasks.Task<TResult>, System.Exception> New(System.Func<TResult> function, System.Threading.Tasks.TaskCreationOptions creationOptions) 
	{
	    try
	    {
	        return new System.Threading.Tasks.Task<TResult>(function, creationOptions);
	    }
	    catch (Exception exception)
	    {
	        return exception;
	    }
	}

    
}

public static class Task1_Extensions_U
{
    public static UnionsWrapper<TResult> Try<TResult>(this System.Threading.Tasks.Task<TResult> value)
    {
        return new UnionsWrapper<TResult>() { Value = value };
    }

    public readonly struct UnionsWrapper<TResult>
    {
        public required System.Threading.Tasks.Task<TResult> Value { get; init; }

        public U<System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>, System.Exception> ConfigureAwait(bool continueOnCapturedContext) 
		{
		    try
		    {
		        return this.Value.ConfigureAwait(continueOnCapturedContext);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Runtime.CompilerServices.ConfiguredTaskAwaitable<TResult>, System.Exception> ConfigureAwait(System.Threading.Tasks.ConfigureAwaitOptions options) 
		{
		    try
		    {
		        return this.Value.ConfigureAwait(options);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<System.Exception>> ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, object?> continuationAction, object? state) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state);
		        return U.Success;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<System.Exception>> ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, object?> continuationAction, object? state, System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state, cancellationToken);
		        return U.Success;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<System.Exception>> ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, object?> continuationAction, object? state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state, cancellationToken, continuationOptions, scheduler);
		        return U.Success;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<System.Exception>> ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, object?> continuationAction, object? state, System.Threading.Tasks.TaskContinuationOptions continuationOptions) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state, continuationOptions);
		        return U.Success;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<System.Exception>> ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>, object?> continuationAction, object? state, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state, scheduler);
		        return U.Success;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<System.Exception>> ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>> continuationAction) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction);
		        return U.Success;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<System.Exception>> ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>> continuationAction, System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, cancellationToken);
		        return U.Success;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<System.Exception>> ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>> continuationAction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, cancellationToken, continuationOptions, scheduler);
		        return U.Success;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<System.Exception>> ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>> continuationAction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, continuationOptions);
		        return U.Success;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<System.Exception>> ContinueWith(System.Action<System.Threading.Tasks.Task<TResult>> continuationAction, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, scheduler);
		        return U.Success;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, object?, TNewResult> continuationFunction, object? state) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith<TNewResult>(continuationFunction, state));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, object?, TNewResult> continuationFunction, object? state, System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith<TNewResult>(continuationFunction, state, cancellationToken));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, object?, TNewResult> continuationFunction, object? state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith<TNewResult>(continuationFunction, state, cancellationToken, continuationOptions, scheduler));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, object?, TNewResult> continuationFunction, object? state, System.Threading.Tasks.TaskContinuationOptions continuationOptions) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith<TNewResult>(continuationFunction, state, continuationOptions));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, object?, TNewResult> continuationFunction, object? state, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith<TNewResult>(continuationFunction, state, scheduler));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult> continuationFunction) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith<TNewResult>(continuationFunction));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult> continuationFunction, System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith<TNewResult>(continuationFunction, cancellationToken));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult> continuationFunction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith<TNewResult>(continuationFunction, cancellationToken, continuationOptions, scheduler));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult> continuationFunction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith<TNewResult>(continuationFunction, continuationOptions));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<TResult>, TNewResult> continuationFunction, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith<TNewResult>(continuationFunction, scheduler));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Runtime.CompilerServices.TaskAwaiter<TResult>, System.Exception> GetAwaiter() 
		{
		    try
		    {
		        return this.Value.GetAwaiter();
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TResult>, System.Exception>> WaitAsync(System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        return new Opt<TResult>(await this.Value.WaitAsync(cancellationToken));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TResult>, System.Exception>> WaitAsync(System.TimeSpan timeout) 
		{
		    try
		    {
		        return new Opt<TResult>(await this.Value.WaitAsync(timeout));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TResult>, System.Exception>> WaitAsync(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        return new Opt<TResult>(await this.Value.WaitAsync(timeout, cancellationToken));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TResult>, System.Exception>> WaitAsync(System.TimeSpan timeout, System.TimeProvider timeProvider) 
		{
		    try
		    {
		        return new Opt<TResult>(await this.Value.WaitAsync(timeout, timeProvider));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TResult>, System.Exception>> WaitAsync(System.TimeSpan timeout, System.TimeProvider timeProvider, System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        return new Opt<TResult>(await this.Value.WaitAsync(timeout, timeProvider, cancellationToken));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
    }
}