#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace System.Text;

public static class StringBuilder_Extensions_U
{
    public static UnionsWrapper Results(this System.Text.StringBuilder value)
    {
        return new UnionsWrapper() { Value = value };
    }

    public readonly struct UnionsWrapper
    {
        public required System.Text.StringBuilder Value { get; init; }

        public U<System.Text.StringBuilder, System.Exception> Append(bool value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(byte value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(char value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(char value, int repeatCount) 
		{
		    try
		    {
		        return this.Value.Append(value, repeatCount);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(char[]? value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(char[]? value, int startIndex, int charCount) 
		{
		    try
		    {
		        return this.Value.Append(value, startIndex, charCount);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(decimal value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(double value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(System.IFormatProvider? provider, ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler) 
		{
		    try
		    {
		        return this.Value.Append(provider, ref handler);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(short value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(int value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(long value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(object? value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(System.ReadOnlyMemory<char> value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(System.ReadOnlySpan<char> value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(sbyte value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(float value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(string? value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(string? value, int startIndex, int count) 
		{
		    try
		    {
		        return this.Value.Append(value, startIndex, count);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(System.Text.StringBuilder? value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(System.Text.StringBuilder? value, int startIndex, int count) 
		{
		    try
		    {
		        return this.Value.Append(value, startIndex, count);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler) 
		{
		    try
		    {
		        return this.Value.Append(ref handler);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(ushort value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(uint value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Append(ulong value) 
		{
		    try
		    {
		        return this.Value.Append(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendFormat(System.IFormatProvider? provider, string format, object? arg0) 
		{
		    try
		    {
		        return this.Value.AppendFormat(provider, format, arg0);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendFormat(System.IFormatProvider? provider, string format, object? arg0, object? arg1) 
		{
		    try
		    {
		        return this.Value.AppendFormat(provider, format, arg0, arg1);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendFormat(System.IFormatProvider? provider, string format, object? arg0, object? arg1, object? arg2) 
		{
		    try
		    {
		        return this.Value.AppendFormat(provider, format, arg0, arg1, arg2);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendFormat(System.IFormatProvider? provider, string format, params object?[] args) 
		{
		    try
		    {
		        return this.Value.AppendFormat(provider, format, args);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendFormat(string format, object? arg0) 
		{
		    try
		    {
		        return this.Value.AppendFormat(format, arg0);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendFormat(string format, object? arg0, object? arg1) 
		{
		    try
		    {
		        return this.Value.AppendFormat(format, arg0, arg1);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendFormat(string format, object? arg0, object? arg1, object? arg2) 
		{
		    try
		    {
		        return this.Value.AppendFormat(format, arg0, arg1, arg2);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendFormat(string format, params object?[] args) 
		{
		    try
		    {
		        return this.Value.AppendFormat(format, args);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendFormat<TArg0>(System.IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0) 
		{
		    try
		    {
		        return this.Value.AppendFormat(provider, format, arg0);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendFormat<TArg0, TArg1>(System.IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0, TArg1 arg1) 
		{
		    try
		    {
		        return this.Value.AppendFormat(provider, format, arg0, arg1);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendFormat<TArg0, TArg1, TArg2>(System.IFormatProvider? provider, System.Text.CompositeFormat format, TArg0 arg0, TArg1 arg1, TArg2 arg2) 
		{
		    try
		    {
		        return this.Value.AppendFormat(provider, format, arg0, arg1, arg2);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendFormat(System.IFormatProvider? provider, System.Text.CompositeFormat format, params object?[] args) 
		{
		    try
		    {
		        return this.Value.AppendFormat(provider, format, args);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendFormat(System.IFormatProvider? provider, System.Text.CompositeFormat format, System.ReadOnlySpan<object?> args) 
		{
		    try
		    {
		        return this.Value.AppendFormat(provider, format, args);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendJoin(char separator, params object?[] values) 
		{
		    try
		    {
		        return this.Value.AppendJoin(separator, values);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendJoin(char separator, params string?[] values) 
		{
		    try
		    {
		        return this.Value.AppendJoin(separator, values);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendJoin(string? separator, params object?[] values) 
		{
		    try
		    {
		        return this.Value.AppendJoin(separator, values);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendJoin(string? separator, params string?[] values) 
		{
		    try
		    {
		        return this.Value.AppendJoin(separator, values);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendJoin<T>(char separator, System.Collections.Generic.IEnumerable<T> values) 
		{
		    try
		    {
		        return this.Value.AppendJoin(separator, values);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendJoin<T>(string? separator, System.Collections.Generic.IEnumerable<T> values) 
		{
		    try
		    {
		        return this.Value.AppendJoin(separator, values);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendLine() 
		{
		    try
		    {
		        return this.Value.AppendLine();
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendLine(System.IFormatProvider? provider, ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler) 
		{
		    try
		    {
		        return this.Value.AppendLine(provider, ref handler);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendLine(string? value) 
		{
		    try
		    {
		        return this.Value.AppendLine(value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> AppendLine(ref System.Text.StringBuilder.AppendInterpolatedStringHandler handler) 
		{
		    try
		    {
		        return this.Value.AppendLine(ref handler);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Clear() 
		{
		    try
		    {
		        return this.Value.Clear();
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) 
		{
		    try
		    {
		        this.Value.CopyTo(sourceIndex, destination, destinationIndex, count);
		        return Definit.Results.Union.Success;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U CopyTo(int sourceIndex, System.Span<char> destination, int count) 
		{
		    try
		    {
		        this.Value.CopyTo(sourceIndex, destination, count);
		        return Definit.Results.Union.Success;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> EnsureCapacity(int capacity) 
		{
		    try
		    {
		        return this.Value.EnsureCapacity(capacity);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<bool, System.Exception> Equals(System.ReadOnlySpan<char> span) 
		{
		    try
		    {
		        return this.Value.Equals(span);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<bool, System.Exception> Equals(System.Text.StringBuilder? sb) 
		{
		    try
		    {
		        return this.Value.Equals(sb);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder.ChunkEnumerator, System.Exception> GetChunks() 
		{
		    try
		    {
		        return this.Value.GetChunks();
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, bool value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, byte value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, char value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, char[]? value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, char[]? value, int startIndex, int charCount) 
		{
		    try
		    {
		        return this.Value.Insert(index, value, startIndex, charCount);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, decimal value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, double value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, short value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, int value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, long value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, object? value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, System.ReadOnlySpan<char> value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, sbyte value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, float value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, string? value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, string? value, int count) 
		{
		    try
		    {
		        return this.Value.Insert(index, value, count);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, ushort value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, uint value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Insert(int index, ulong value) 
		{
		    try
		    {
		        return this.Value.Insert(index, value);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Remove(int startIndex, int length) 
		{
		    try
		    {
		        return this.Value.Remove(startIndex, length);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Replace(char oldChar, char newChar) 
		{
		    try
		    {
		        return this.Value.Replace(oldChar, newChar);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Replace(char oldChar, char newChar, int startIndex, int count) 
		{
		    try
		    {
		        return this.Value.Replace(oldChar, newChar, startIndex, count);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Replace(string oldValue, string? newValue) 
		{
		    try
		    {
		        return this.Value.Replace(oldValue, newValue);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Text.StringBuilder, System.Exception> Replace(string oldValue, string? newValue, int startIndex, int count) 
		{
		    try
		    {
		        return this.Value.Replace(oldValue, newValue, startIndex, count);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
    }
}