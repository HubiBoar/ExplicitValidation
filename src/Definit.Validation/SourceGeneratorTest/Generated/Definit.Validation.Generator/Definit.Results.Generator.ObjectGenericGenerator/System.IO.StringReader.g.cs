#nullable enable

using Definit.Results.NewApproach;
using System.Diagnostics.CodeAnalysis;

namespace System.IO;

public static class StringReader__Auto__Extensions
{
    public static Wrapper Results(this System.IO.StringReader value)
    {
        return new Wrapper() { Value = value };
    }

    public readonly struct Wrapper
    {
        public required System.IO.StringReader Value { get; init; }
        
		public Result<Success, Error>.Value Close()
		{
		    try
		    {
		        this.Value.Close();
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value Peek()
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.Peek()));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value Read()
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.Read()));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value Read(char[] buffer, int index, int count)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.Read(buffer, index, count)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value Read(System.Span<char> buffer)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.Read(buffer)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public async Task<Result<int, Error>.Value> ReadAsync(char[] buffer, int index, int count)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(await this.Value.ReadAsync(buffer, index, count)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public async ValueTask<Result<int, Error>.Value> ReadAsync(System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(await this.Value.ReadAsync(buffer, cancellationToken)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value ReadBlock(System.Span<char> buffer)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.ReadBlock(buffer)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public async Task<Result<int, Error>.Value> ReadBlockAsync(char[] buffer, int index, int count)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(await this.Value.ReadBlockAsync(buffer, index, count)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public async ValueTask<Result<int, Error>.Value> ReadBlockAsync(System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(await this.Value.ReadBlockAsync(buffer, cancellationToken)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<string, Null, Error>.Value ReadLine()
		{
		    try
		    {
		        var _call_result = this.Value.ReadLine();
		
		        if(_call_result is null)
		        {
		            return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(Result.Null));
		        }
		
		        return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(_call_result));
		    }
		    catch (Exception exception)
		    {
		        return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(Error.Create(exception)));
		    }
		}
		
		public async Task<Result<string, Null, Error>.Value> ReadLineAsync()
		{
		    try
		    {
		        var _call_result = await this.Value.ReadLineAsync();
		
		        if(_call_result is null)
		        {
		            return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(Result.Null));
		        }
		
		        return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(_call_result));
		    }
		    catch (Exception exception)
		    {
		        return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(Error.Create(exception)));
		    }
		}
		
		public async ValueTask<Result<string, Null, Error>.Value> ReadLineAsync(System.Threading.CancellationToken cancellationToken)
		{
		    try
		    {
		        var _call_result = await this.Value.ReadLineAsync(cancellationToken);
		
		        if(_call_result is null)
		        {
		            return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(Result.Null));
		        }
		
		        return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(_call_result));
		    }
		    catch (Exception exception)
		    {
		        return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<string, Error>.Value ReadToEnd()
		{
		    try
		    {
		        return new Result<string, Error>.Value(new Result<string, Error>(this.Value.ReadToEnd()));
		    }
		    catch (Exception exception)
		    {
		        return new Result<string, Error>.Value(new Result<string, Error>(Error.Create(exception)));
		    }
		}
		
		public async Task<Result<string, Error>.Value> ReadToEndAsync()
		{
		    try
		    {
		        return new Result<string, Error>.Value(new Result<string, Error>(await this.Value.ReadToEndAsync()));
		    }
		    catch (Exception exception)
		    {
		        return new Result<string, Error>.Value(new Result<string, Error>(Error.Create(exception)));
		    }
		}
		
		public async Task<Result<string, Error>.Value> ReadToEndAsync(System.Threading.CancellationToken cancellationToken)
		{
		    try
		    {
		        return new Result<string, Error>.Value(new Result<string, Error>(await this.Value.ReadToEndAsync(cancellationToken)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<string, Error>.Value(new Result<string, Error>(Error.Create(exception)));
		    }
		}
		
    }
}