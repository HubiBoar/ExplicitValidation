#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace System.Collections.Generic;

public static class List_T_Extensions_U
{
    public static UnionsWrapper<T> Try<T>(this System.Collections.Generic.List<T> value)
    {
        return new UnionsWrapper<T>() { Value = value };
    }

    public readonly struct UnionsWrapper<T>
    {
        public required System.Collections.Generic.List<T> Value { get; init; }

        public System.Exception? Add(T item) 
		{
		    try
		    {
		        this.Value.Add(item);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? AddRange(System.Collections.Generic.IEnumerable<T> collection) 
		{
		    try
		    {
		        this.Value.AddRange(collection);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Collections.ObjectModel.ReadOnlyCollection<T>, System.Exception> AsReadOnly() 
		{
		    try
		    {
		        return this.Value.AsReadOnly();
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> BinarySearch(int index, int count, T item, System.Collections.Generic.IComparer<T>? comparer) 
		{
		    try
		    {
		        return this.Value.BinarySearch(index, count, item, comparer);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> BinarySearch(T item) 
		{
		    try
		    {
		        return this.Value.BinarySearch(item);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> BinarySearch(T item, System.Collections.Generic.IComparer<T>? comparer) 
		{
		    try
		    {
		        return this.Value.BinarySearch(item, comparer);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? Clear() 
		{
		    try
		    {
		        this.Value.Clear();
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<bool, System.Exception> Contains(T item) 
		{
		    try
		    {
		        return this.Value.Contains(item);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Collections.Generic.List<TOutput>, System.Exception> ConvertAll<TOutput>(System.Converter<T, TOutput> converter) 
		{
		    try
		    {
		        return this.Value.ConvertAll(converter);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? CopyTo(int index, T[] array, int arrayIndex, int count) 
		{
		    try
		    {
		        this.Value.CopyTo(index, array, arrayIndex, count);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? CopyTo(T[] array) 
		{
		    try
		    {
		        this.Value.CopyTo(array);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? CopyTo(T[] array, int arrayIndex) 
		{
		    try
		    {
		        this.Value.CopyTo(array, arrayIndex);
		        return null;
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
		
		public U<bool, System.Exception> Exists(System.Predicate<T> match) 
		{
		    try
		    {
		        return this.Value.Exists(match);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<Opt<T?>, System.Exception> Find(System.Predicate<T> match) 
		{
		    try
		    {
		        return new Opt<T?>(this.Value.Find(match));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Collections.Generic.List<T>, System.Exception> FindAll(System.Predicate<T> match) 
		{
		    try
		    {
		        return this.Value.FindAll(match);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> FindIndex(int startIndex, int count, System.Predicate<T> match) 
		{
		    try
		    {
		        return this.Value.FindIndex(startIndex, count, match);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> FindIndex(int startIndex, System.Predicate<T> match) 
		{
		    try
		    {
		        return this.Value.FindIndex(startIndex, match);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> FindIndex(System.Predicate<T> match) 
		{
		    try
		    {
		        return this.Value.FindIndex(match);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<Opt<T?>, System.Exception> FindLast(System.Predicate<T> match) 
		{
		    try
		    {
		        return new Opt<T?>(this.Value.FindLast(match));
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> FindLastIndex(int startIndex, int count, System.Predicate<T> match) 
		{
		    try
		    {
		        return this.Value.FindLastIndex(startIndex, count, match);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> FindLastIndex(int startIndex, System.Predicate<T> match) 
		{
		    try
		    {
		        return this.Value.FindLastIndex(startIndex, match);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> FindLastIndex(System.Predicate<T> match) 
		{
		    try
		    {
		        return this.Value.FindLastIndex(match);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? ForEach(System.Action<T> action) 
		{
		    try
		    {
		        this.Value.ForEach(action);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Collections.Generic.List<T>.Enumerator, System.Exception> GetEnumerator() 
		{
		    try
		    {
		        return this.Value.GetEnumerator();
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Collections.Generic.List<T>, System.Exception> GetRange(int index, int count) 
		{
		    try
		    {
		        return this.Value.GetRange(index, count);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> IndexOf(T item) 
		{
		    try
		    {
		        return this.Value.IndexOf(item);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> IndexOf(T item, int index) 
		{
		    try
		    {
		        return this.Value.IndexOf(item, index);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> IndexOf(T item, int index, int count) 
		{
		    try
		    {
		        return this.Value.IndexOf(item, index, count);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? Insert(int index, T item) 
		{
		    try
		    {
		        this.Value.Insert(index, item);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? InsertRange(int index, System.Collections.Generic.IEnumerable<T> collection) 
		{
		    try
		    {
		        this.Value.InsertRange(index, collection);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> LastIndexOf(T item) 
		{
		    try
		    {
		        return this.Value.LastIndexOf(item);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> LastIndexOf(T item, int index) 
		{
		    try
		    {
		        return this.Value.LastIndexOf(item, index);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> LastIndexOf(T item, int index, int count) 
		{
		    try
		    {
		        return this.Value.LastIndexOf(item, index, count);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<bool, System.Exception> Remove(T item) 
		{
		    try
		    {
		        return this.Value.Remove(item);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<int, System.Exception> RemoveAll(System.Predicate<T> match) 
		{
		    try
		    {
		        return this.Value.RemoveAll(match);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? RemoveAt(int index) 
		{
		    try
		    {
		        this.Value.RemoveAt(index);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? RemoveRange(int index, int count) 
		{
		    try
		    {
		        this.Value.RemoveRange(index, count);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? Reverse() 
		{
		    try
		    {
		        this.Value.Reverse();
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? Reverse(int index, int count) 
		{
		    try
		    {
		        this.Value.Reverse(index, count);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<System.Collections.Generic.List<T>, System.Exception> Slice(int start, int length) 
		{
		    try
		    {
		        return this.Value.Slice(start, length);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? Sort() 
		{
		    try
		    {
		        this.Value.Sort();
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? Sort(System.Collections.Generic.IComparer<T>? comparer) 
		{
		    try
		    {
		        this.Value.Sort(comparer);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? Sort(System.Comparison<T> comparison) 
		{
		    try
		    {
		        this.Value.Sort(comparison);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? Sort(int index, int count, System.Collections.Generic.IComparer<T>? comparer) 
		{
		    try
		    {
		        this.Value.Sort(index, count, comparer);
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<T[], System.Exception> ToArray() 
		{
		    try
		    {
		        return this.Value.ToArray();
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public System.Exception? TrimExcess() 
		{
		    try
		    {
		        this.Value.TrimExcess();
		        return null;
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<bool, System.Exception> TrueForAll(System.Predicate<T> match) 
		{
		    try
		    {
		        return this.Value.TrueForAll(match);
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
    }
}