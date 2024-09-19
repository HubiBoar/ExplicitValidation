#nullable enable

using Definit.Results.NewApproach;
using System.Diagnostics.CodeAnalysis;

namespace System.Collections.Generic;

public static class List_T__Auto__Extensions
{
    public static Wrapper<T> Results<T>(this System.Collections.Generic.List<T> value)
    {
        return new Wrapper<T>() { Value = value };
    }

    public readonly struct Wrapper<T>
    {
        public required System.Collections.Generic.List<T> Value { get; init; }
        
		public Either<Success, Error> Add(T item)
		{
		    try
		    {
		        this.Value.Add(item);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> AddRange(System.Collections.Generic.IEnumerable<T> collection)
		{
		    try
		    {
		        this.Value.AddRange(collection);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Collections.ObjectModel.ReadOnlyCollection<T>, Error> AsReadOnly()
		{
		    try
		    {
		        return new Either<System.Collections.ObjectModel.ReadOnlyCollection<T>, Error>(this.Value.AsReadOnly());
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Collections.ObjectModel.ReadOnlyCollection<T>, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> BinarySearch(int index, int count, T item, System.Collections.Generic.IComparer<T>? comparer)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.BinarySearch(index, count, item, comparer));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> BinarySearch(T item)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.BinarySearch(item));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> BinarySearch(T item, System.Collections.Generic.IComparer<T>? comparer)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.BinarySearch(item, comparer));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> Clear()
		{
		    try
		    {
		        this.Value.Clear();
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<bool, Error> Contains(T item)
		{
		    try
		    {
		        return new Either<bool, Error>(this.Value.Contains(item));
		    }
		    catch (Exception exception)
		    {
		        return new Either<bool, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Collections.Generic.List<TOutput>, Error> ConvertAll<TOutput>(System.Converter<T, TOutput> converter)
		{
		    try
		    {
		        return new Either<System.Collections.Generic.List<TOutput>, Error>(this.Value.ConvertAll(converter));
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Collections.Generic.List<TOutput>, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> CopyTo(int index, T[] array, int arrayIndex, int count)
		{
		    try
		    {
		        this.Value.CopyTo(index, array, arrayIndex, count);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> CopyTo(T[] array)
		{
		    try
		    {
		        this.Value.CopyTo(array);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> CopyTo(T[] array, int arrayIndex)
		{
		    try
		    {
		        this.Value.CopyTo(array, arrayIndex);
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
		        return new Either<int, Error>(this.Value.EnsureCapacity(capacity));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<bool, Error> Exists(System.Predicate<T> match)
		{
		    try
		    {
		        return new Either<bool, Error>(this.Value.Exists(match));
		    }
		    catch (Exception exception)
		    {
		        return new Either<bool, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<IsNull<T>, Error> Find(System.Predicate<T> match)
		{
		    try
		    {
		        return new Either<IsNull<T>, Error>((this.Value.Find(match)).IsNull());
		    }
		    catch (Exception exception)
		    {
		        return new Either<IsNull<T>, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Collections.Generic.List<T>, Error> FindAll(System.Predicate<T> match)
		{
		    try
		    {
		        return new Either<System.Collections.Generic.List<T>, Error>(this.Value.FindAll(match));
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Collections.Generic.List<T>, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> FindIndex(int startIndex, int count, System.Predicate<T> match)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.FindIndex(startIndex, count, match));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> FindIndex(int startIndex, System.Predicate<T> match)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.FindIndex(startIndex, match));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> FindIndex(System.Predicate<T> match)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.FindIndex(match));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<IsNull<T>, Error> FindLast(System.Predicate<T> match)
		{
		    try
		    {
		        return new Either<IsNull<T>, Error>((this.Value.FindLast(match)).IsNull());
		    }
		    catch (Exception exception)
		    {
		        return new Either<IsNull<T>, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> FindLastIndex(int startIndex, int count, System.Predicate<T> match)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.FindLastIndex(startIndex, count, match));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> FindLastIndex(int startIndex, System.Predicate<T> match)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.FindLastIndex(startIndex, match));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> FindLastIndex(System.Predicate<T> match)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.FindLastIndex(match));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> ForEach(System.Action<T> action)
		{
		    try
		    {
		        this.Value.ForEach(action);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Collections.Generic.List<T>.Enumerator, Error> GetEnumerator()
		{
		    try
		    {
		        return new Either<System.Collections.Generic.List<T>.Enumerator, Error>(this.Value.GetEnumerator());
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Collections.Generic.List<T>.Enumerator, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Collections.Generic.List<T>, Error> GetRange(int index, int count)
		{
		    try
		    {
		        return new Either<System.Collections.Generic.List<T>, Error>(this.Value.GetRange(index, count));
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Collections.Generic.List<T>, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> IndexOf(T item)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.IndexOf(item));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> IndexOf(T item, int index)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.IndexOf(item, index));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> IndexOf(T item, int index, int count)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.IndexOf(item, index, count));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> Insert(int index, T item)
		{
		    try
		    {
		        this.Value.Insert(index, item);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> InsertRange(int index, System.Collections.Generic.IEnumerable<T> collection)
		{
		    try
		    {
		        this.Value.InsertRange(index, collection);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> LastIndexOf(T item)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.LastIndexOf(item));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> LastIndexOf(T item, int index)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.LastIndexOf(item, index));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> LastIndexOf(T item, int index, int count)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.LastIndexOf(item, index, count));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<bool, Error> Remove(T item)
		{
		    try
		    {
		        return new Either<bool, Error>(this.Value.Remove(item));
		    }
		    catch (Exception exception)
		    {
		        return new Either<bool, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<int, Error> RemoveAll(System.Predicate<T> match)
		{
		    try
		    {
		        return new Either<int, Error>(this.Value.RemoveAll(match));
		    }
		    catch (Exception exception)
		    {
		        return new Either<int, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> RemoveAt(int index)
		{
		    try
		    {
		        this.Value.RemoveAt(index);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> RemoveRange(int index, int count)
		{
		    try
		    {
		        this.Value.RemoveRange(index, count);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> Reverse()
		{
		    try
		    {
		        this.Value.Reverse();
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> Reverse(int index, int count)
		{
		    try
		    {
		        this.Value.Reverse(index, count);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<System.Collections.Generic.List<T>, Error> Slice(int start, int length)
		{
		    try
		    {
		        return new Either<System.Collections.Generic.List<T>, Error>(this.Value.Slice(start, length));
		    }
		    catch (Exception exception)
		    {
		        return new Either<System.Collections.Generic.List<T>, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> Sort()
		{
		    try
		    {
		        this.Value.Sort();
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> Sort(System.Collections.Generic.IComparer<T>? comparer)
		{
		    try
		    {
		        this.Value.Sort(comparer);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> Sort(System.Comparison<T> comparison)
		{
		    try
		    {
		        this.Value.Sort(comparison);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> Sort(int index, int count, System.Collections.Generic.IComparer<T>? comparer)
		{
		    try
		    {
		        this.Value.Sort(index, count, comparer);
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<T[], Error> ToArray()
		{
		    try
		    {
		        return new Either<T[], Error>(this.Value.ToArray());
		    }
		    catch (Exception exception)
		    {
		        return new Either<T[], Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<Success, Error> TrimExcess()
		{
		    try
		    {
		        this.Value.TrimExcess();
				return new Either<Success, Error>(Result.Success);
		    }
		    catch (Exception exception)
		    {
		        return new Either<Success, Error>(Error.Matches(exception).Error);
		    }
		}
		
		public Either<bool, Error> TrueForAll(System.Predicate<T> match)
		{
		    try
		    {
		        return new Either<bool, Error>(this.Value.TrueForAll(match));
		    }
		    catch (Exception exception)
		    {
		        return new Either<bool, Error>(Error.Matches(exception).Error);
		    }
		}
		
    }
}