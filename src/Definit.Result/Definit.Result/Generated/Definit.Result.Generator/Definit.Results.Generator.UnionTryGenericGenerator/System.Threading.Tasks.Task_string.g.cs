#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace System.Threading.Tasks;

public static class Task_string_Extensions_U
{
    public static UnionsWrapper Try(this System.Threading.Tasks.Task<string> value)
    {
        return new UnionsWrapper() { Value = value };
    }

    public readonly struct UnionsWrapper
    {
        public required System.Threading.Tasks.Task<string> Value { get; init; }

        public U<System.Runtime.CompilerServices.ConfiguredTaskAwaitable<string>, System.Exception> ConfigureAwait(bool continueOnCapturedContext) 
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
		
		public U<System.Runtime.CompilerServices.ConfiguredTaskAwaitable<string>, System.Exception> ConfigureAwait(System.Threading.Tasks.ConfigureAwaitOptions options) 
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
		
		public async System.Threading.Tasks.Task<System.Exception?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<System.Exception?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state, System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state, cancellationToken);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<System.Exception?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state, cancellationToken, continuationOptions, scheduler);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<System.Exception?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state, System.Threading.Tasks.TaskContinuationOptions continuationOptions) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state, continuationOptions);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<System.Exception?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state, scheduler);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<System.Exception?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<System.Exception?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction, System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, cancellationToken);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<System.Exception?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, cancellationToken, continuationOptions, scheduler);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<System.Exception?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, continuationOptions);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<System.Exception?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, scheduler);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith(continuationFunction, state));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state, System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith(continuationFunction, state, cancellationToken));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith(continuationFunction, state, cancellationToken, continuationOptions, scheduler));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state, System.Threading.Tasks.TaskContinuationOptions continuationOptions) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith(continuationFunction, state, continuationOptions));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith(continuationFunction, state, scheduler));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith(continuationFunction));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction, System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith(continuationFunction, cancellationToken));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith(continuationFunction, cancellationToken, continuationOptions, scheduler));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction, System.Threading.Tasks.TaskContinuationOptions continuationOptions) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith(continuationFunction, continuationOptions));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<TNewResult>, System.Exception>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction, System.Threading.Tasks.TaskScheduler scheduler) 
		{
		    try
		    {
		        return new Opt<TNewResult>(await this.Value.ContinueWith(continuationFunction, scheduler));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Runtime.CompilerServices.TaskAwaiter<string>, System.Exception> GetAwaiter() 
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
		
		public async System.Threading.Tasks.Task<U<string, System.Exception>> WaitAsync(System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        return await this.Value.WaitAsync(cancellationToken);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<string, System.Exception>> WaitAsync(System.TimeSpan timeout) 
		{
		    try
		    {
		        return await this.Value.WaitAsync(timeout);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<string, System.Exception>> WaitAsync(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        return await this.Value.WaitAsync(timeout, cancellationToken);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<string, System.Exception>> WaitAsync(System.TimeSpan timeout, System.TimeProvider timeProvider) 
		{
		    try
		    {
		        return await this.Value.WaitAsync(timeout, timeProvider);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<string, System.Exception>> WaitAsync(System.TimeSpan timeout, System.TimeProvider timeProvider, System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        return await this.Value.WaitAsync(timeout, timeProvider, cancellationToken);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
    }
}