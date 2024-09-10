#nullable enable

using Definit.Results.NewApproach;

namespace System.IO;

public static class StringReader__Auto__Extensions
{
    public readonly struct Wrapper
    {
        public required System.IO.StringReader Value { get; init; }
    }

    public static Wrapper Results(this System.IO.StringReader value)
    {
        return new Wrapper() { Value = value };
    }
    
	public static Result<Success, Error> Close(this Wrapper _wrapper)
	{
	    try
	    {
	        _wrapper.Value.Close(); return new Result<Success, Error>(Result.Success);
	    }
	    catch (Exception exception)
	    {
	        return new Result<Success, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<Success, Error> Dispose(this Wrapper _wrapper, bool disposing)
	{
	    try
	    {
	        _wrapper.Value.Dispose(disposing); return new Result<Success, Error>(Result.Success);
	    }
	    catch (Exception exception)
	    {
	        return new Result<Success, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<int, Error> Peek(this Wrapper _wrapper)
	{
	    try
	    {
	        return new Result<int, Error>(_wrapper.Value.Peek());
	    }
	    catch (Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<int, Error> Read(this Wrapper _wrapper)
	{
	    try
	    {
	        return new Result<int, Error>(_wrapper.Value.Read());
	    }
	    catch (Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<int, Error> Read(this Wrapper _wrapper, char[] buffer, int index, int count)
	{
	    try
	    {
	        return new Result<int, Error>(_wrapper.Value.Read(buffer, index, count));
	    }
	    catch (Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<int, Error> Read(this Wrapper _wrapper, System.Span<char> buffer)
	{
	    try
	    {
	        return new Result<int, Error>(_wrapper.Value.Read(buffer));
	    }
	    catch (Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async Task<Result<int, Error>> ReadAsync(this Wrapper _wrapper, char[] buffer, int index, int count)
	{
	    try
	    {
	        return new Result<int, Error>(await _wrapper.Value.ReadAsync(buffer, index, count));
	    }
	    catch (Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async ValueTask<Result<int, Error>> ReadAsync(this Wrapper _wrapper, System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken)
	{
	    try
	    {
	        return new Result<int, Error>(await _wrapper.Value.ReadAsync(buffer, cancellationToken));
	    }
	    catch (Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<int, Error> ReadBlock(this Wrapper _wrapper, System.Span<char> buffer)
	{
	    try
	    {
	        return new Result<int, Error>(_wrapper.Value.ReadBlock(buffer));
	    }
	    catch (Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async Task<Result<int, Error>> ReadBlockAsync(this Wrapper _wrapper, char[] buffer, int index, int count)
	{
	    try
	    {
	        return new Result<int, Error>(await _wrapper.Value.ReadBlockAsync(buffer, index, count));
	    }
	    catch (Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async ValueTask<Result<int, Error>> ReadBlockAsync(this Wrapper _wrapper, System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken)
	{
	    try
	    {
	        return new Result<int, Error>(await _wrapper.Value.ReadBlockAsync(buffer, cancellationToken));
	    }
	    catch (Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<string?, Error> ReadLine(this Wrapper _wrapper)
	{
	    try
	    {
	        return new Result<string?, Error>(_wrapper.Value.ReadLine());
	    }
	    catch (Exception exception)
	    {
	        return new Result<string?, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async Task<Result<string?, Error>> ReadLineAsync(this Wrapper _wrapper)
	{
	    try
	    {
	        return new Result<string?, Error>(await _wrapper.Value.ReadLineAsync());
	    }
	    catch (Exception exception)
	    {
	        return new Result<string?, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async ValueTask<Result<string?, Error>> ReadLineAsync(this Wrapper _wrapper, System.Threading.CancellationToken cancellationToken)
	{
	    try
	    {
	        return new Result<string?, Error>(await _wrapper.Value.ReadLineAsync(cancellationToken));
	    }
	    catch (Exception exception)
	    {
	        return new Result<string?, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<string, Error> ReadToEnd(this Wrapper _wrapper)
	{
	    try
	    {
	        return new Result<string, Error>(_wrapper.Value.ReadToEnd());
	    }
	    catch (Exception exception)
	    {
	        return new Result<string, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async Task<Result<string, Error>> ReadToEndAsync(this Wrapper _wrapper)
	{
	    try
	    {
	        return new Result<string, Error>(await _wrapper.Value.ReadToEndAsync());
	    }
	    catch (Exception exception)
	    {
	        return new Result<string, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async Task<Result<string, Error>> ReadToEndAsync(this Wrapper _wrapper, System.Threading.CancellationToken cancellationToken)
	{
	    try
	    {
	        return new Result<string, Error>(await _wrapper.Value.ReadToEndAsync(cancellationToken));
	    }
	    catch (Exception exception)
	    {
	        return new Result<string, Error>(Error.Create(exception)); 
	    }
	}
	
}