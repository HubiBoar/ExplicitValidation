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
    
	public static Result<Success, Error> Close(this Wrapper _value)
	{
	    try
	    {
	        return new Result<Success, Error>(_value.Value.Close());
	    }
	    catch(Exception exception)
	    {
	        return new Result<Success, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<Success, Error> Dispose(this Wrapper _value, bool disposing)
	{
	    try
	    {
	        return new Result<Success, Error>(_value.Value.Dispose(disposing));
	    }
	    catch(Exception exception)
	    {
	        return new Result<Success, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<int, Error> Peek(this Wrapper _value)
	{
	    try
	    {
	        return new Result<int, Error>(_value.Value.Peek());
	    }
	    catch(Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<int, Error> Read(this Wrapper _value)
	{
	    try
	    {
	        return new Result<int, Error>(_value.Value.Read());
	    }
	    catch(Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<int, Error> Read(this Wrapper _value, char[] buffer, int index, int count)
	{
	    try
	    {
	        return new Result<int, Error>(_value.Value.Read(buffer, index, count));
	    }
	    catch(Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<int, Error> Read(this Wrapper _value, System.Span<char> buffer)
	{
	    try
	    {
	        return new Result<int, Error>(_value.Value.Read(buffer));
	    }
	    catch(Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async Task<Result<int, Error>> ReadAsync(this Wrapper _value, char[] buffer, int index, int count)
	{
	    try
	    {
	        return new Result<int, Error>(await _value.Value.ReadAsync(buffer, index, count));
	    }
	    catch(Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async ValueTask<Result<int, Error>> ReadAsync(this Wrapper _value, System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken)
	{
	    try
	    {
	        return new Result<int, Error>(await _value.Value.ReadAsync(buffer, cancellationToken));
	    }
	    catch(Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<int, Error> ReadBlock(this Wrapper _value, System.Span<char> buffer)
	{
	    try
	    {
	        return new Result<int, Error>(_value.Value.ReadBlock(buffer));
	    }
	    catch(Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async Task<Result<int, Error>> ReadBlockAsync(this Wrapper _value, char[] buffer, int index, int count)
	{
	    try
	    {
	        return new Result<int, Error>(await _value.Value.ReadBlockAsync(buffer, index, count));
	    }
	    catch(Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async ValueTask<Result<int, Error>> ReadBlockAsync(this Wrapper _value, System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken)
	{
	    try
	    {
	        return new Result<int, Error>(await _value.Value.ReadBlockAsync(buffer, cancellationToken));
	    }
	    catch(Exception exception)
	    {
	        return new Result<int, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<string?, Error> ReadLine(this Wrapper _value)
	{
	    try
	    {
	        return new Result<string?, Error>(_value.Value.ReadLine());
	    }
	    catch(Exception exception)
	    {
	        return new Result<string?, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async Task<Result<string?, Error>> ReadLineAsync(this Wrapper _value)
	{
	    try
	    {
	        return new Result<string?, Error>(await _value.Value.ReadLineAsync());
	    }
	    catch(Exception exception)
	    {
	        return new Result<string?, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async ValueTask<Result<string?, Error>> ReadLineAsync(this Wrapper _value, System.Threading.CancellationToken cancellationToken)
	{
	    try
	    {
	        return new Result<string?, Error>(await _value.Value.ReadLineAsync(cancellationToken));
	    }
	    catch(Exception exception)
	    {
	        return new Result<string?, Error>(Error.Create(exception)); 
	    }
	}
	
	public static Result<string, Error> ReadToEnd(this Wrapper _value)
	{
	    try
	    {
	        return new Result<string, Error>(_value.Value.ReadToEnd());
	    }
	    catch(Exception exception)
	    {
	        return new Result<string, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async Task<Result<string, Error>> ReadToEndAsync(this Wrapper _value)
	{
	    try
	    {
	        return new Result<string, Error>(await _value.Value.ReadToEndAsync());
	    }
	    catch(Exception exception)
	    {
	        return new Result<string, Error>(Error.Create(exception)); 
	    }
	}
	
	public static async Task<Result<string, Error>> ReadToEndAsync(this Wrapper _value, System.Threading.CancellationToken cancellationToken)
	{
	    try
	    {
	        return new Result<string, Error>(await _value.Value.ReadToEndAsync(cancellationToken));
	    }
	    catch(Exception exception)
	    {
	        return new Result<string, Error>(Error.Create(exception)); 
	    }
	}
	
}