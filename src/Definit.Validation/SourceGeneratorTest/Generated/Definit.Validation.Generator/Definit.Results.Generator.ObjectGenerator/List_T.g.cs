#nullable enable

using Definit.Results.NewApproach;

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
        
		public Result<Success, Error>.Value Add(T item)
		{
		    try
		    {
		        this.Value.Add(item);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value AddRange(System.Collections.Generic.IEnumerable<T> collection)
		{
		    try
		    {
		        this.Value.AddRange(collection);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Collections.ObjectModel.ReadOnlyCollection<T>, Error>.Value AsReadOnly()
		{
		    try
		    {
		        return new Result<System.Collections.ObjectModel.ReadOnlyCollection<T>, Error>.Value(new Result<System.Collections.ObjectModel.ReadOnlyCollection<T>, Error>(this.Value.AsReadOnly()));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Collections.ObjectModel.ReadOnlyCollection<T>, Error>.Value(new Result<System.Collections.ObjectModel.ReadOnlyCollection<T>, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value BinarySearch(int index, int count, T item, System.Collections.Generic.IComparer<T>? comparer)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.BinarySearch(index, count, item, comparer)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value BinarySearch(T item)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.BinarySearch(item)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value BinarySearch(T item, System.Collections.Generic.IComparer<T>? comparer)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.BinarySearch(item, comparer)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value Clear()
		{
		    try
		    {
		        this.Value.Clear();
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<bool, Error>.Value Contains(T item)
		{
		    try
		    {
		        return new Result<bool, Error>.Value(new Result<bool, Error>(this.Value.Contains(item)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<bool, Error>.Value(new Result<bool, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Collections.Generic.List<TOutput>, Error>.Value ConvertAll<TOutput>(System.Converter<T, TOutput> converter)
		{
		    try
		    {
		        return new Result<System.Collections.Generic.List<TOutput>, Error>.Value(new Result<System.Collections.Generic.List<TOutput>, Error>(this.Value.ConvertAll(converter)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Collections.Generic.List<TOutput>, Error>.Value(new Result<System.Collections.Generic.List<TOutput>, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value CopyTo(int index, T[] array, int arrayIndex, int count)
		{
		    try
		    {
		        this.Value.CopyTo(index, array, arrayIndex, count);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value CopyTo(T[] array)
		{
		    try
		    {
		        this.Value.CopyTo(array);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value CopyTo(T[] array, int arrayIndex)
		{
		    try
		    {
		        this.Value.CopyTo(array, arrayIndex);
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
		
		public Result<bool, Error>.Value Exists(System.Predicate<T> match)
		{
		    try
		    {
		        return new Result<bool, Error>.Value(new Result<bool, Error>(this.Value.Exists(match)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<bool, Error>.Value(new Result<bool, Error>(Error.Create(exception)));
		    }
		}
		//T? :: System.Collections.Generic.List<T>.Find(System.Predicate<T>)
		// System.NullReferenceException: Object reference not set to an instance of an object.
		//    at Definit.Results.Generator.ObjectGenerator.GetReturnType(IMethodSymbol method)
		//    at Definit.Results.Generator.ObjectGenerator.GenerateMethod(IMethodSymbol method, Boolean allowUnsafe)
		
		public Result<System.Collections.Generic.List<T>, Error>.Value FindAll(System.Predicate<T> match)
		{
		    try
		    {
		        return new Result<System.Collections.Generic.List<T>, Error>.Value(new Result<System.Collections.Generic.List<T>, Error>(this.Value.FindAll(match)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Collections.Generic.List<T>, Error>.Value(new Result<System.Collections.Generic.List<T>, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value FindIndex(int startIndex, int count, System.Predicate<T> match)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.FindIndex(startIndex, count, match)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value FindIndex(int startIndex, System.Predicate<T> match)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.FindIndex(startIndex, match)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value FindIndex(System.Predicate<T> match)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.FindIndex(match)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		//T? :: System.Collections.Generic.List<T>.FindLast(System.Predicate<T>)
		// System.NullReferenceException: Object reference not set to an instance of an object.
		//    at Definit.Results.Generator.ObjectGenerator.GetReturnType(IMethodSymbol method)
		//    at Definit.Results.Generator.ObjectGenerator.GenerateMethod(IMethodSymbol method, Boolean allowUnsafe)
		
		public Result<int, Error>.Value FindLastIndex(int startIndex, int count, System.Predicate<T> match)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.FindLastIndex(startIndex, count, match)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value FindLastIndex(int startIndex, System.Predicate<T> match)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.FindLastIndex(startIndex, match)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value FindLastIndex(System.Predicate<T> match)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.FindLastIndex(match)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value ForEach(System.Action<T> action)
		{
		    try
		    {
		        this.Value.ForEach(action);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Collections.Generic.List<T>.Enumerator, Error>.Value GetEnumerator()
		{
		    try
		    {
		        return new Result<System.Collections.Generic.List<T>.Enumerator, Error>.Value(new Result<System.Collections.Generic.List<T>.Enumerator, Error>(this.Value.GetEnumerator()));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Collections.Generic.List<T>.Enumerator, Error>.Value(new Result<System.Collections.Generic.List<T>.Enumerator, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Collections.Generic.List<T>, Error>.Value GetRange(int index, int count)
		{
		    try
		    {
		        return new Result<System.Collections.Generic.List<T>, Error>.Value(new Result<System.Collections.Generic.List<T>, Error>(this.Value.GetRange(index, count)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Collections.Generic.List<T>, Error>.Value(new Result<System.Collections.Generic.List<T>, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value IndexOf(T item)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.IndexOf(item)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value IndexOf(T item, int index)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.IndexOf(item, index)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value IndexOf(T item, int index, int count)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.IndexOf(item, index, count)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value Insert(int index, T item)
		{
		    try
		    {
		        this.Value.Insert(index, item);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value InsertRange(int index, System.Collections.Generic.IEnumerable<T> collection)
		{
		    try
		    {
		        this.Value.InsertRange(index, collection);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value LastIndexOf(T item)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.LastIndexOf(item)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value LastIndexOf(T item, int index)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.LastIndexOf(item, index)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value LastIndexOf(T item, int index, int count)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.LastIndexOf(item, index, count)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<bool, Error>.Value Remove(T item)
		{
		    try
		    {
		        return new Result<bool, Error>.Value(new Result<bool, Error>(this.Value.Remove(item)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<bool, Error>.Value(new Result<bool, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value RemoveAll(System.Predicate<T> match)
		{
		    try
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(this.Value.RemoveAll(match)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<int, Error>.Value(new Result<int, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value RemoveAt(int index)
		{
		    try
		    {
		        this.Value.RemoveAt(index);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value RemoveRange(int index, int count)
		{
		    try
		    {
		        this.Value.RemoveRange(index, count);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value Reverse()
		{
		    try
		    {
		        this.Value.Reverse();
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value Reverse(int index, int count)
		{
		    try
		    {
		        this.Value.Reverse(index, count);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Collections.Generic.List<T>, Error>.Value Slice(int start, int length)
		{
		    try
		    {
		        return new Result<System.Collections.Generic.List<T>, Error>.Value(new Result<System.Collections.Generic.List<T>, Error>(this.Value.Slice(start, length)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Collections.Generic.List<T>, Error>.Value(new Result<System.Collections.Generic.List<T>, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value Sort()
		{
		    try
		    {
		        this.Value.Sort();
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value Sort(System.Collections.Generic.IComparer<T>? comparer)
		{
		    try
		    {
		        this.Value.Sort(comparer);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value Sort(System.Comparison<T> comparison)
		{
		    try
		    {
		        this.Value.Sort(comparison);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<Success, Error>.Value Sort(int index, int count, System.Collections.Generic.IComparer<T>? comparer)
		{
		    try
		    {
		        this.Value.Sort(index, count, comparer);
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		//T[] :: System.Collections.Generic.List<T>.ToArray()
		// System.NullReferenceException: Object reference not set to an instance of an object.
		//    at Definit.Results.Generator.ObjectGenerator.GetReturnType(IMethodSymbol method)
		//    at Definit.Results.Generator.ObjectGenerator.GenerateMethod(IMethodSymbol method, Boolean allowUnsafe)
		
		public Result<Success, Error>.Value TrimExcess()
		{
		    try
		    {
		        this.Value.TrimExcess();
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Result.Success));
		    }
		    catch (Exception exception)
		    {
		        return new Result<Success, Error>.Value(new Result<Success, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<bool, Error>.Value TrueForAll(System.Predicate<T> match)
		{
		    try
		    {
		        return new Result<bool, Error>.Value(new Result<bool, Error>(this.Value.TrueForAll(match)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<bool, Error>.Value(new Result<bool, Error>(Error.Create(exception)));
		    }
		}
		
    }
}