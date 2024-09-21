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
		
		public async Task<Either<Success, Error>> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state)
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<Success, Error>> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state, System.Threading.CancellationToken cancellationToken)
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state, cancellationToken);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<Success, Error>> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state, cancellationToken, continuationOptions, scheduler);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<Success, Error>> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state, System.Threading.Tasks.TaskContinuationOptions continuationOptions)
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state, continuationOptions);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<Success, Error>> ContinueWith(System.Action<System.Threading.Tasks.Task<string>, object?> continuationAction, object? state, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, state, scheduler);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<Success, Error>> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction)
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<Success, Error>> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction, System.Threading.CancellationToken cancellationToken)
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, cancellationToken);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<Success, Error>> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, cancellationToken, continuationOptions, scheduler);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<Success, Error>> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction, System.Threading.Tasks.TaskContinuationOptions continuationOptions)
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, continuationOptions);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<Success, Error>> ContinueWith(System.Action<System.Threading.Tasks.Task<string>> continuationAction, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
		    {
		        await this.Value.ContinueWith(continuationAction, scheduler);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<TNewResult, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state)
		{
		    try
		    {
		        return new Either<TNewResult, Error>((await this.Value.ContinueWith(continuationFunction, state))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<TNewResult, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<TNewResult, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state, System.Threading.CancellationToken cancellationToken)
		{
		    try
		    {
		        return new Either<TNewResult, Error>((await this.Value.ContinueWith(continuationFunction, state, cancellationToken))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<TNewResult, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<TNewResult, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
		    {
		        return new Either<TNewResult, Error>((await this.Value.ContinueWith(continuationFunction, state, cancellationToken, continuationOptions, scheduler))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<TNewResult, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<TNewResult, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state, System.Threading.Tasks.TaskContinuationOptions continuationOptions)
		{
		    try
		    {
		        return new Either<TNewResult, Error>((await this.Value.ContinueWith(continuationFunction, state, continuationOptions))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<TNewResult, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<TNewResult, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, object?, TNewResult> continuationFunction, object? state, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
		    {
		        return new Either<TNewResult, Error>((await this.Value.ContinueWith(continuationFunction, state, scheduler))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<TNewResult, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<TNewResult, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction)
		{
		    try
		    {
		        return new Either<TNewResult, Error>((await this.Value.ContinueWith(continuationFunction))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<TNewResult, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<TNewResult, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction, System.Threading.CancellationToken cancellationToken)
		{
		    try
		    {
		        return new Either<TNewResult, Error>((await this.Value.ContinueWith(continuationFunction, cancellationToken))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<TNewResult, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<TNewResult, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction, System.Threading.CancellationToken cancellationToken, System.Threading.Tasks.TaskContinuationOptions continuationOptions, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
		    {
		        return new Either<TNewResult, Error>((await this.Value.ContinueWith(continuationFunction, cancellationToken, continuationOptions, scheduler))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<TNewResult, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<TNewResult, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction, System.Threading.Tasks.TaskContinuationOptions continuationOptions)
		{
		    try
		    {
		        return new Either<TNewResult, Error>((await this.Value.ContinueWith(continuationFunction, continuationOptions))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<TNewResult, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<TNewResult, Error>> ContinueWith<TNewResult>(System.Func<System.Threading.Tasks.Task<string>, TNewResult> continuationFunction, System.Threading.Tasks.TaskScheduler scheduler)
		{
		    try
		    {
		        return new Either<TNewResult, Error>((await this.Value.ContinueWith(continuationFunction, scheduler))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<TNewResult, Error>(Error.Matches(exception).Error);
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
		
		public async Task<Either<string, Error>> WaitAsync(System.Threading.CancellationToken cancellationToken)
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
		
		public async Task<Either<string, Error>> WaitAsync(System.TimeSpan timeout)
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
		
		public async Task<Either<string, Error>> WaitAsync(System.TimeSpan timeout, System.Threading.CancellationToken cancellationToken)
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
		
		public async Task<Either<string, Error>> WaitAsync(System.TimeSpan timeout, System.TimeProvider timeProvider)
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
		
		public async Task<Either<string, Error>> WaitAsync(System.TimeSpan timeout, System.TimeProvider timeProvider, System.Threading.CancellationToken cancellationToken)
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