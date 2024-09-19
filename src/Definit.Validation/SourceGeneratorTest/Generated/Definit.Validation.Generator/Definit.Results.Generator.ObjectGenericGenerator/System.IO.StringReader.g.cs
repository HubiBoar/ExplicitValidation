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
        
		public Either<Success, Error> Close()
		{
		    try
		    {
		        this.Value.Close();
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> Peek()
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.Peek());
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> Read()
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.Read());
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> Read(char[] buffer, int index, int count)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.Read(buffer, index, count));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> Read(System.Span<char> buffer)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.Read(buffer));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<int, Error>> ReadAsync(char[] buffer, int index, int count)
		{
		    try
		    {
		        return new Either<int, Error>(await this.Value.ReadAsync(buffer, index, count));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async ValueTask<Either<int, Error>> ReadAsync(System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken)
		{
		    try
		    {
		        return new Either<int, Error>(await this.Value.ReadAsync(buffer, cancellationToken));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> ReadBlock(System.Span<char> buffer)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.ReadBlock(buffer));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<int, Error>> ReadBlockAsync(char[] buffer, int index, int count)
		{
		    try
		    {
		        return new Either<int, Error>(await this.Value.ReadBlockAsync(buffer, index, count));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async ValueTask<Either<int, Error>> ReadBlockAsync(System.Memory<char> buffer, System.Threading.CancellationToken cancellationToken)
		{
		    try
		    {
		        return new Either<int, Error>(await this.Value.ReadBlockAsync(buffer, cancellationToken));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<IsNull<string>, Error> ReadLine()
		{
		    try
		    {
		        return new Either<IsNull<string>, Error>((this.Value.ReadLine()).IsNull());
		    }
		    catch (Exception exception)
		    {
		        return new Either<IsNull<string>, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<IsNull<string>, Error>> ReadLineAsync()
		{
		    try
		    {
		        return new Either<IsNull<string>, Error>((await this.Value.ReadLineAsync()).IsNull());
		    }
		    catch (Exception exception)
		    {
		        return new Either<IsNull<string>, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async ValueTask<Either<IsNull<string>, Error>> ReadLineAsync(System.Threading.CancellationToken cancellationToken)
		{
		    try
		    {
		        return new Either<IsNull<string>, Error>((await this.Value.ReadLineAsync(cancellationToken)).IsNull());
		    }
		    catch (Exception exception)
		    {
		        return new Either<IsNull<string>, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<string, Error> ReadToEnd()
		{
		    try
		    {
		        return new Either<string, Error>(this.Value.ReadToEnd());
		    }
		    catch (Exception exception)
		    {
		        return new Either<string, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<string, Error>> ReadToEndAsync()
		{
		    try
		    {
		        return new Either<string, Error>(await this.Value.ReadToEndAsync());
		    }
		    catch (Exception exception)
		    {
		        return new Either<string, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public async Task<Either<string, Error>> ReadToEndAsync(System.Threading.CancellationToken cancellationToken)
		{
		    try
		    {
		        return new Either<string, Error>(await this.Value.ReadToEndAsync(cancellationToken));
		    }
		    catch (Exception exception)
		    {
		        return new Either<string, Error>(Error.Matches(exception).Error);
		    }
		}
		
    }
}