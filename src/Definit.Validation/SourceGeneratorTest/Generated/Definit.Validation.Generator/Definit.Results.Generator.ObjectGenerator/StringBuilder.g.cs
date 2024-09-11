#nullable enable

using Definit.Results.NewApproach;
using System.Diagnostics.CodeAnalysis;

namespace System.Text;

public static class StringBuilder__Auto__Extensions
{
    public static Wrapper Results(this System.Text.StringBuilder value)
    {
        return new Wrapper() { Value = value };
    }

    public readonly struct Wrapper
    {
        public required System.Text.StringBuilder Value { get; init; }
        
		public Result<System.Text.StringBuilder, Error>.Value Append(bool value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(byte value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(char value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(char value, int repeatCount)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value, repeatCount)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(char[]? value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(char[]? value, int startIndex, int charCount)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value, startIndex, charCount)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(decimal value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(double value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(System.IFormatProvider? provider, ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(provider, ref handler)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(short value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(int value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(long value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(object? value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(System.ReadOnlyMemory<char> value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(System.ReadOnlySpan<char> value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(sbyte value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(float value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(string? value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(string? value, int startIndex, int count)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value, startIndex, count)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(System.Text.StringBuilder? value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(System.Text.StringBuilder? value, int startIndex, int count)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value, startIndex, count)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(ref handler)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(ushort value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(uint value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Append(ulong value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Append(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendFormat(System.IFormatProvider? provider, string format, object? arg0)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendFormat(provider, format, arg0)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendFormat(System.IFormatProvider? provider, string format, object? arg0, object? arg1)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendFormat(provider, format, arg0, arg1)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendFormat(System.IFormatProvider? provider, string format, object? arg0, object? arg1, object? arg2)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendFormat(provider, format, arg0, arg1, arg2)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendFormat(System.IFormatProvider? provider, string format, params object?[] args)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendFormat(provider, format, args)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendFormat(string format, object? arg0)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendFormat(format, arg0)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendFormat(string format, object? arg0, object? arg1)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendFormat(format, arg0, arg1)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendFormat(string format, object? arg0, object? arg1, object? arg2)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendFormat(format, arg0, arg1, arg2)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendFormat(string format, params object?[] args)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendFormat(format, args)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendFormat<TArg0>(System.IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendFormat(provider, format, arg0)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendFormat<TArg0, TArg1>(System.IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0, TArg1 arg1)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendFormat(provider, format, arg0, arg1)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendFormat<TArg0, TArg1, TArg2>(System.IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0, TArg1 arg1, TArg2 arg2)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendFormat(provider, format, arg0, arg1, arg2)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendFormat(System.IFormatProvider? provider, System.Text.CompositeFormat format, params object?[] args)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendFormat(provider, format, args)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendFormat(System.IFormatProvider? provider, System.Text.CompositeFormat format, System.ReadOnlySpan<object?> args)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendFormat(provider, format, args)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendJoin(char separator, params object?[] values)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendJoin(separator, values)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendJoin(char separator, params string?[] values)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendJoin(separator, values)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendJoin(string? separator, params object?[] values)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendJoin(separator, values)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendJoin(string? separator, params string?[] values)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendJoin(separator, values)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendJoin<T>(char separator, System.Collections.Generic.IEnumerable<T> values)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendJoin(separator, values)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendJoin<T>(string? separator, System.Collections.Generic.IEnumerable<T> values)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendJoin(separator, values)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendLine()
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendLine()));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendLine(System.IFormatProvider? provider, ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendLine(provider, ref handler)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendLine(string? value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendLine(value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.AppendLine(ref handler)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Clear()
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Clear()));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
		    try
		    {
		        this.Value.CopyTo(sourceIndex, destination, destinationIndex, count);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value CopyTo(int sourceIndex, System.Span<char> destination, int count)
		{
		    try
		    {
		        this.Value.CopyTo(sourceIndex, destination, count);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value EnsureCapacity(int capacity)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.EnsureCapacity(capacity)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<bool, Error>.Value Equals(System.ReadOnlySpan<char> span)
		{
		    try
		    {
		        return new Result<bool, Error>.Value(new Result<bool, Error>(this.Value.Equals(span)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<bool, Error>.Value(new Result<bool, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<bool, Error>.Value Equals(System.Text.StringBuilder? sb)
		{
		    try
		    {
		        return new Result<bool, Error>.Value(new Result<bool, Error>(this.Value.Equals(sb)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<bool, Error>.Value(new Result<bool, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder.ChunkEnumerator, Error>.Value GetChunks()
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder.ChunkEnumerator, Error>.Value(new Result<System.Text.StringBuilder.ChunkEnumerator, Error>(this.Value.GetChunks()));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder.ChunkEnumerator, Error>.Value(new Result<System.Text.StringBuilder.ChunkEnumerator, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, bool value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, byte value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, char value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, char[]? value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, char[]? value, int startIndex, int charCount)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value, startIndex, charCount)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, decimal value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, double value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, short value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, int value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, long value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, object? value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, System.ReadOnlySpan<char> value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, sbyte value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, float value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, string? value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, string? value, int count)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value, count)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, ushort value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, uint value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Insert(int index, ulong value)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Insert(index, value)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Remove(int startIndex, int length)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Remove(startIndex, length)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Replace(char oldChar, char newChar)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Replace(oldChar, newChar)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Replace(char oldChar, char newChar, int startIndex, int count)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Replace(oldChar, newChar, startIndex, count)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Replace(string oldValue, string? newValue)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Replace(oldValue, newValue)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Text.StringBuilder, Error>.Value Replace(string oldValue, string? newValue, int startIndex, int count)
		{
		    try
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(this.Value.Replace(oldValue, newValue, startIndex, count)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Text.StringBuilder, Error>.Value(new Result<System.Text.StringBuilder, Error>(Error.Create(exception)));
		    }
		}
		
		public new Result<string, Error>.Value ToString()
		{
		    try
		    {
		        return new Result<string, Error>.Value(new Result<string, Error>(this.Value.ToString()));
		    }
		    catch (Exception exception)
		    {
		        return new Result<string, Error>.Value(new Result<string, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<string, Error>.Value ToString(int startIndex, int length)
		{
		    try
		    {
		        return new Result<string, Error>.Value(new Result<string, Error>(this.Value.ToString(startIndex, length)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<string, Error>.Value(new Result<string, Error>(Error.Create(exception)));
		    }
		}
		
    }
}