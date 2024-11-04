#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace System.IO;

public static class StringReader_Extensions_U
{
    public static UnionsWrapper Results(this System.IO.StringReader value)
    {
        return new UnionsWrapper() { Value = value };
    }

    public readonly struct UnionsWrapper
    {
        public required System.IO.StringReader Value { get; init; }

        public U Close() 
		{
		    try
		    {
		        this.Value.Close();
		        return Definit.Results.Union.Success;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> Peek() 
		{
		    try
		    {
		        return this.Value.Peek();
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> Read() 
		{
		    try
		    {
		        return this.Value.Read();
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> Read(char[] buffer, int index, int count) 
		{
		    try
		    {
		        return this.Value.Read(buffer, index, count);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> Read(System.Span<char> buffer) 
		{
		    try
		    {
		        return this.Value.Read(buffer);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<int, System.Exception>> ReadAsync(char[] buffer, int index, int count) 
		{
		    try
		    {
		        return await this.Value.ReadAsync(buffer, index, count);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.ValueTask<U<int, System.Exception>> ReadAsync(System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        return await this.Value.ReadAsync(buffer, cancellationToken);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> ReadBlock(System.Span<char> buffer) 
		{
		    try
		    {
		        return this.Value.ReadBlock(buffer);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<int, System.Exception>> ReadBlockAsync(char[] buffer, int index, int count) 
		{
		    try
		    {
		        return await this.Value.ReadBlockAsync(buffer, index, count);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.ValueTask<U<int, System.Exception>> ReadBlockAsync(System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        return await this.Value.ReadBlockAsync(buffer, cancellationToken);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<Opt<string?>, System.Exception> ReadLine() 
		{
		    try
		    {
		        return new Opt<string?>(this.Value.ReadLine());
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<Opt<string?>, System.Exception>> ReadLineAsync() 
		{
		    try
		    {
		        return new Opt<string?>(await this.Value.ReadLineAsync());
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.ValueTask<U<Opt<string?>, System.Exception>> ReadLineAsync(System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        return new Opt<string?>(await this.Value.ReadLineAsync(cancellationToken));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<string, System.Exception> ReadToEnd() 
		{
		    try
		    {
		        return this.Value.ReadToEnd();
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<string, System.Exception>> ReadToEndAsync() 
		{
		    try
		    {
		        return await this.Value.ReadToEndAsync();
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public async System.Threading.Tasks.Task<U<string, System.Exception>> ReadToEndAsync(System.Threading.CancellationToken cancellationToken) 
		{
		    try
		    {
		        return await this.Value.ReadToEndAsync(cancellationToken);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
    }
}