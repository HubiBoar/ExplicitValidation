#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace System.Threading.Tasks;

public static class Task_string__Auto__Extensions
{
    public static Wrapper Results(this System.Threading.Tasks.Task<string> value)
    {
        return new Wrapper() { Value = value };
    }

    public readonly struct Wrapper
    {
        public required System.Threading.Tasks.Task<string> Value { get; init; }
        
		public Either<System.Runtime.CompilerServices.ConfiguredTaskAwaitable<string>, Error> ConfigureAwait(bool continueOnCapturedContext)
		{
		    try
			{
			    return new Either<System.Runtime.CompilerServices.ConfiguredTaskAwaitable<string>, Error>((this.Value.ConfigureAwait(continueOnCapturedContext))!);
			}
			catch (Exception exception)
			{
			    return new Either<System.Runtime.CompilerServices.ConfiguredTaskAwaitable<string>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public Either<System.Runtime.CompilerServices.ConfiguredTaskAwaitable<string>, Error> ConfigureAwait(System.Threading.Tasks.ConfigureAwaitOptions options)
		{
		    try
			{
			    return new Either<System.Runtime.CompilerServices.ConfiguredTaskAwaitable<string>, Error>((this.Value.ConfigureAwait(options))!);
			}
			catch (Exception exception)
			{
			    return new Either<System.Runtime.CompilerServices.ConfiguredTaskAwaitable<string>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Error?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state)
		{
		    try
			{
			    await this.Value.ContinueWith(continuationAction, state);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public async System.Threading.Tasks.Task<Error?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state, System.Threading.CancellationToken cancellationToken)
		{
		    try
			{
			    await this.Value.ContinueWith(continuationAction, state, cancellationToken);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public async System.Threading.Tasks.Task<Error?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
			{
			    await this.Value.ContinueWith(continuationAction, state, cancellationToken, continuationOptions, scheduler);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public async System.Threading.Tasks.Task<Error?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state, System.Threading.Tasks.TaskContinuationOptions continuationOptions)
		{
		    try
			{
			    await this.Value.ContinueWith(continuationAction, state, continuationOptions);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public async System.Threading.Tasks.Task<Error?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
			{
			    await this.Value.ContinueWith(continuationAction, state, scheduler);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public async System.Threading.Tasks.Task<Error?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction)
		{
		    try
			{
			    await this.Value.ContinueWith(continuationAction);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public async System.Threading.Tasks.Task<Error?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction, System.Threading.CancellationToken cancellationToken)
		{
		    try
			{
			    await this.Value.ContinueWith(continuationAction, cancellationToken);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public async System.Threading.Tasks.Task<Error?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
			{
			    await this.Value.ContinueWith(continuationAction, cancellationToken, continuationOptions, scheduler);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public async System.Threading.Tasks.Task<Error?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction, System.Threading.Tasks.TaskContinuationOptions continuationOptions)
		{
		    try
			{
			    await this.Value.ContinueWith(continuationAction, continuationOptions);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public async System.Threading.Tasks.Task<Error?> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
			{
			    await this.Value.ContinueWith(continuationAction, scheduler);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public async System.Threading.Tasks.Task<Either<Maybe<TNewResult>, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state)
		{
		    try
			{
			    TNewResult method_result = await this.Value.ContinueWith(continuationFunction, state);
			    var maybe_result = new Maybe<TNewResult>(method_result); 
			
			    return new Either<Maybe<TNewResult>, Error>(maybe_result);
			}
			catch (Exception exception)
			{
			    return new Either<Maybe<TNewResult>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Either<Maybe<TNewResult>, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state, System.Threading.CancellationToken cancellationToken)
		{
		    try
			{
			    TNewResult method_result = await this.Value.ContinueWith(continuationFunction, state, cancellationToken);
			    var maybe_result = new Maybe<TNewResult>(method_result); 
			
			    return new Either<Maybe<TNewResult>, Error>(maybe_result);
			}
			catch (Exception exception)
			{
			    return new Either<Maybe<TNewResult>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Either<Maybe<TNewResult>, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
			{
			    TNewResult method_result = await this.Value.ContinueWith(continuationFunction, state, cancellationToken, continuationOptions, scheduler);
			    var maybe_result = new Maybe<TNewResult>(method_result); 
			
			    return new Either<Maybe<TNewResult>, Error>(maybe_result);
			}
			catch (Exception exception)
			{
			    return new Either<Maybe<TNewResult>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Either<Maybe<TNewResult>, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state, System.Threading.Tasks.TaskContinuationOptions continuationOptions)
		{
		    try
			{
			    TNewResult method_result = await this.Value.ContinueWith(continuationFunction, state, continuationOptions);
			    var maybe_result = new Maybe<TNewResult>(method_result); 
			
			    return new Either<Maybe<TNewResult>, Error>(maybe_result);
			}
			catch (Exception exception)
			{
			    return new Either<Maybe<TNewResult>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Either<Maybe<TNewResult>, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
			{
			    TNewResult method_result = await this.Value.ContinueWith(continuationFunction, state, scheduler);
			    var maybe_result = new Maybe<TNewResult>(method_result); 
			
			    return new Either<Maybe<TNewResult>, Error>(maybe_result);
			}
			catch (Exception exception)
			{
			    return new Either<Maybe<TNewResult>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Either<Maybe<TNewResult>, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction)
		{
		    try
			{
			    TNewResult method_result = await this.Value.ContinueWith(continuationFunction);
			    var maybe_result = new Maybe<TNewResult>(method_result); 
			
			    return new Either<Maybe<TNewResult>, Error>(maybe_result);
			}
			catch (Exception exception)
			{
			    return new Either<Maybe<TNewResult>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Either<Maybe<TNewResult>, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction, System.Threading.CancellationToken cancellationToken)
		{
		    try
			{
			    TNewResult method_result = await this.Value.ContinueWith(continuationFunction, cancellationToken);
			    var maybe_result = new Maybe<TNewResult>(method_result); 
			
			    return new Either<Maybe<TNewResult>, Error>(maybe_result);
			}
			catch (Exception exception)
			{
			    return new Either<Maybe<TNewResult>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Either<Maybe<TNewResult>, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
			{
			    TNewResult method_result = await this.Value.ContinueWith(continuationFunction, cancellationToken, continuationOptions, scheduler);
			    var maybe_result = new Maybe<TNewResult>(method_result); 
			
			    return new Either<Maybe<TNewResult>, Error>(maybe_result);
			}
			catch (Exception exception)
			{
			    return new Either<Maybe<TNewResult>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Either<Maybe<TNewResult>, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction, System.Threading.Tasks.TaskContinuationOptions continuationOptions)
		{
		    try
			{
			    TNewResult method_result = await this.Value.ContinueWith(continuationFunction, continuationOptions);
			    var maybe_result = new Maybe<TNewResult>(method_result); 
			
			    return new Either<Maybe<TNewResult>, Error>(maybe_result);
			}
			catch (Exception exception)
			{
			    return new Either<Maybe<TNewResult>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Either<Maybe<TNewResult>, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
			{
			    TNewResult method_result = await this.Value.ContinueWith(continuationFunction, scheduler);
			    var maybe_result = new Maybe<TNewResult>(method_result); 
			
			    return new Either<Maybe<TNewResult>, Error>(maybe_result);
			}
			catch (Exception exception)
			{
			    return new Either<Maybe<TNewResult>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public Either<System.Runtime.CompilerServices.TaskAwaiter<string>, Error> GetAwaiter()
		{
		    try
			{
			    return new Either<System.Runtime.CompilerServices.TaskAwaiter<string>, Error>((this.Value.GetAwaiter())!);
			}
			catch (Exception exception)
			{
			    return new Either<System.Runtime.CompilerServices.TaskAwaiter<string>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Either<string, Error>> WaitAsync(System.Threading.CancellationToken cancellationToken)
		{
		    try
			{
			    return new Either<string, Error>((await this.Value.WaitAsync(cancellationToken))!);
			}
			catch (Exception exception)
			{
			    return new Either<string, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Either<string, Error>> WaitAsync(System.TimeSpan timeout)
		{
		    try
			{
			    return new Either<string, Error>((await this.Value.WaitAsync(timeout))!);
			}
			catch (Exception exception)
			{
			    return new Either<string, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Either<string, Error>> WaitAsync(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken)
		{
		    try
			{
			    return new Either<string, Error>((await this.Value.WaitAsync(timeout, cancellationToken))!);
			}
			catch (Exception exception)
			{
			    return new Either<string, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Either<string, Error>> WaitAsync(System.TimeSpan timeout, System.TimeProvider timeProvider)
		{
		    try
			{
			    return new Either<string, Error>((await this.Value.WaitAsync(timeout, timeProvider))!);
			}
			catch (Exception exception)
			{
			    return new Either<string, Error>(Error.Matches(exception).Error);
			}
		}
		
		public async System.Threading.Tasks.Task<Either<string, Error>> WaitAsync(System.TimeSpan timeout, System.TimeProvider timeProvider, System.Threading.CancellationToken cancellationToken)
		{
		    try
			{
			    return new Either<string, Error>((await this.Value.WaitAsync(timeout, timeProvider, cancellationToken))!);
			}
			catch (Exception exception)
			{
			    return new Either<string, Error>(Error.Matches(exception).Error);
			}
		}
		
    }
}