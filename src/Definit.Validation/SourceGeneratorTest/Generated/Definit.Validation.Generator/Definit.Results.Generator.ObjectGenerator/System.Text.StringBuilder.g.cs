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
        
		public Either<System.Text.StringBuilder, Error> Append(bool value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(byte value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(char value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(char value, int repeatCount)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value, repeatCount))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(char[]? value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(char[]? value, int startIndex, int charCount)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value, startIndex, charCount))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(decimal value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(double value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(System.IFormatProvider? provider, ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(provider, ref handler))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(short value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(int value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(long value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(object? value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(System.ReadOnlyMemory<char> value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(System.ReadOnlySpan<char> value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(sbyte value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(float value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(string? value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(string? value, int startIndex, int count)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value, startIndex, count))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(System.Text.StringBuilder? value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(System.Text.StringBuilder? value, int startIndex, int count)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value, startIndex, count))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(ref handler))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(ushort value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(uint value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Append(ulong value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Append(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendFormat(System.IFormatProvider? provider, string format, object? arg0)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendFormat(provider, format, arg0))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendFormat(System.IFormatProvider? provider, string format, object? arg0, object? arg1)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendFormat(provider, format, arg0, arg1))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendFormat(System.IFormatProvider? provider, string format, object? arg0, object? arg1, object? arg2)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendFormat(provider, format, arg0, arg1, arg2))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendFormat(System.IFormatProvider? provider, string format, params object?[] args)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendFormat(provider, format, args))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendFormat(string format, object? arg0)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendFormat(format, arg0))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendFormat(string format, object? arg0, object? arg1)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendFormat(format, arg0, arg1))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendFormat(string format, object? arg0, object? arg1, object? arg2)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendFormat(format, arg0, arg1, arg2))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendFormat(string format, params object?[] args)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendFormat(format, args))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendFormat<TArg0>(System.IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendFormat(provider, format, arg0))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendFormat<TArg0, TArg1>(System.IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0, TArg1 arg1)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendFormat(provider, format, arg0, arg1))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendFormat<TArg0, TArg1, TArg2>(System.IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0, TArg1 arg1, TArg2 arg2)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendFormat(provider, format, arg0, arg1, arg2))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendFormat(System.IFormatProvider? provider, System.Text.CompositeFormat format, params object?[] args)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendFormat(provider, format, args))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendFormat(System.IFormatProvider? provider, System.Text.CompositeFormat format, System.ReadOnlySpan<object?> args)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendFormat(provider, format, args))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendJoin(char separator, params object?[] values)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendJoin(separator, values))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendJoin(char separator, params string?[] values)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendJoin(separator, values))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendJoin(string? separator, params object?[] values)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendJoin(separator, values))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendJoin(string? separator, params string?[] values)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendJoin(separator, values))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendJoin<T>(char separator, System.Collections.Generic.IEnumerable<T> values)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendJoin(separator, values))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendJoin<T>(string? separator, System.Collections.Generic.IEnumerable<T> values)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendJoin(separator, values))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendLine()
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendLine())!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendLine(System.IFormatProvider? provider, ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendLine(provider, ref handler))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendLine(string? value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendLine(value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.AppendLine(ref handler))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Clear()
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Clear())!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
		{
		    try
		    {
		        this.Value.CopyTo(sourceIndex, destination, destinationIndex, count);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> CopyTo(int sourceIndex, System.Span<char> destination, int count)
		{
		    try
		    {
		        this.Value.CopyTo(sourceIndex, destination, count);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> EnsureCapacity(int capacity)
		{
		    try
		    {
		        return new Either<int, Error>((this.Value.EnsureCapacity(capacity))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<bool, Error> Equals(System.ReadOnlySpan<char> span)
		{
		    try
		    {
		        return new Either<bool, Error>((this.Value.Equals(span))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<bool, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<bool, Error> Equals(System.Text.StringBuilder? sb)
		{
		    try
		    {
		        return new Either<bool, Error>((this.Value.Equals(sb))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<bool, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder.ChunkEnumerator, Error> GetChunks()
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder.ChunkEnumerator, Error>((this.Value.GetChunks())!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder.ChunkEnumerator, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, bool value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, byte value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, char value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, char[]? value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, char[]? value, int startIndex, int charCount)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value, startIndex, charCount))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, decimal value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, double value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, short value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, int value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, long value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, object? value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, System.ReadOnlySpan<char> value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, sbyte value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, float value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, string? value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, string? value, int count)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value, count))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, ushort value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, uint value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Insert(int index, ulong value)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Insert(index, value))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Remove(int startIndex, int length)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Remove(startIndex, length))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Replace(char oldChar, char newChar)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Replace(oldChar, newChar))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Replace(char oldChar, char newChar, int startIndex, int count)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Replace(oldChar, newChar, startIndex, count))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Replace(string oldValue, string? newValue)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Replace(oldValue, newValue))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Text.StringBuilder, Error> Replace(string oldValue, string? newValue, int startIndex, int count)
		{
		    try
		    {
		        return new Either<System.Text.StringBuilder, Error>((this.Value.Replace(oldValue, newValue, startIndex, count))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Text.StringBuilder, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public new Either<string, Error> ToString()
		{
		    try
		    {
		        return new Either<string, Error>((this.Value.ToString())!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<string, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<string, Error> ToString(int startIndex, int length)
		{
		    try
		    {
		        return new Either<string, Error>((this.Value.ToString(startIndex, length))!);
		    }
		    catch (Exception exception)
		    {
		        return new Either<string, Error>(Error.Matches(exception).Error);
		    }
		}
		
    }
}