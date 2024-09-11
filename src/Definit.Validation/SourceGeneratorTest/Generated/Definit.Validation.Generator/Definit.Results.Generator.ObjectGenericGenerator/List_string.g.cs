#nullable enable

using Definit.Results.NewApproach;

namespace System.Collections.Generic;

public static class List_string__Auto__Extensions
{
    public static Wrapper Results(this System.Collections.Generic.List<string> value)
    {
        return new Wrapper() { Value = value };
    }

    public readonly struct Wrapper
    {
        public required System.Collections.Generic.List<string> Value { get; init; }
        
		public Result<Success, Error>.Value Add(string item)
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
		
		public Result<Success, Error>.Value AddRange(System.Collections.Generic.IEnumerable<string> collection)
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
		
		public Result<System.Collections.ObjectModel.ReadOnlyCollection<string>, Error>.Value AsReadOnly()
		{
		    try
		    {
		        return new Result<System.Collections.ObjectModel.ReadOnlyCollection<string>, Error>.Value(new Result<System.Collections.ObjectModel.ReadOnlyCollection<string>, Error>(this.Value.AsReadOnly()));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Collections.ObjectModel.ReadOnlyCollection<string>, Error>.Value(new Result<System.Collections.ObjectModel.ReadOnlyCollection<string>, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value BinarySearch(int index, int count, string item, System.Collections.Generic.IComparer<string>? comparer)
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
		
		public Result<int, Error>.Value BinarySearch(string item)
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
		
		public Result<int, Error>.Value BinarySearch(string item, System.Collections.Generic.IComparer<string>? comparer)
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
		
		public Result<bool, Error>.Value Contains(string item)
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
		
		public Result<System.Collections.Generic.List<TOutput>, Error>.Value ConvertAll<TOutput>(System.Converter<string, TOutput> converter)
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
		
		public Result<Success, Error>.Value CopyTo(int index, string[] array, int arrayIndex, int count)
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
		
		public Result<Success, Error>.Value CopyTo(string[] array)
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
		
		public Result<Success, Error>.Value CopyTo(string[] array, int arrayIndex)
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
		
		public Result<bool, Error>.Value Exists(System.Predicate<string> match)
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
		
		public Result<string, Null, Error>.Value Find(System.Predicate<string> match)
		{
		    try
		    {
		        var _call_result = this.Value.Find(match);
		
		        if(_call_result is null)
		        {
		            return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(Result.Null));
		        }
		
		        return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(_call_result));
		    }
		    catch (Exception exception)
		    {
		        return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Collections.Generic.List<string>, Error>.Value FindAll(System.Predicate<string> match)
		{
		    try
		    {
		        return new Result<System.Collections.Generic.List<string>, Error>.Value(new Result<System.Collections.Generic.List<string>, Error>(this.Value.FindAll(match)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Collections.Generic.List<string>, Error>.Value(new Result<System.Collections.Generic.List<string>, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value FindIndex(int startIndex, int count, System.Predicate<string> match)
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
		
		public Result<int, Error>.Value FindIndex(int startIndex, System.Predicate<string> match)
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
		
		public Result<int, Error>.Value FindIndex(System.Predicate<string> match)
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
		
		public Result<string, Null, Error>.Value FindLast(System.Predicate<string> match)
		{
		    try
		    {
		        var _call_result = this.Value.FindLast(match);
		
		        if(_call_result is null)
		        {
		            return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(Result.Null));
		        }
		
		        return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(_call_result));
		    }
		    catch (Exception exception)
		    {
		        return new Result<string, Null, Error>.Value(new Result<string, Null, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value FindLastIndex(int startIndex, int count, System.Predicate<string> match)
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
		
		public Result<int, Error>.Value FindLastIndex(int startIndex, System.Predicate<string> match)
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
		
		public Result<int, Error>.Value FindLastIndex(System.Predicate<string> match)
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
		
		public Result<Success, Error>.Value ForEach(System.Action<string> action)
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
		
		public Result<System.Collections.Generic.List<string>.Enumerator, Error>.Value GetEnumerator()
		{
		    try
		    {
		        return new Result<System.Collections.Generic.List<string>.Enumerator, Error>.Value(new Result<System.Collections.Generic.List<string>.Enumerator, Error>(this.Value.GetEnumerator()));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Collections.Generic.List<string>.Enumerator, Error>.Value(new Result<System.Collections.Generic.List<string>.Enumerator, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<System.Collections.Generic.List<string>, Error>.Value GetRange(int index, int count)
		{
		    try
		    {
		        return new Result<System.Collections.Generic.List<string>, Error>.Value(new Result<System.Collections.Generic.List<string>, Error>(this.Value.GetRange(index, count)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Collections.Generic.List<string>, Error>.Value(new Result<System.Collections.Generic.List<string>, Error>(Error.Create(exception)));
		    }
		}
		
		public Result<int, Error>.Value IndexOf(string item)
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
		
		public Result<int, Error>.Value IndexOf(string item, int index)
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
		
		public Result<int, Error>.Value IndexOf(string item, int index, int count)
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
		
		public Result<Success, Error>.Value Insert(int index, string item)
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
		
		public Result<Success, Error>.Value InsertRange(int index, System.Collections.Generic.IEnumerable<string> collection)
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
		
		public Result<int, Error>.Value LastIndexOf(string item)
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
		
		public Result<int, Error>.Value LastIndexOf(string item, int index)
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
		
		public Result<int, Error>.Value LastIndexOf(string item, int index, int count)
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
		
		public Result<bool, Error>.Value Remove(string item)
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
		
		public Result<int, Error>.Value RemoveAll(System.Predicate<string> match)
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
		
		public Result<System.Collections.Generic.List<string>, Error>.Value Slice(int start, int length)
		{
		    try
		    {
		        return new Result<System.Collections.Generic.List<string>, Error>.Value(new Result<System.Collections.Generic.List<string>, Error>(this.Value.Slice(start, length)));
		    }
		    catch (Exception exception)
		    {
		        return new Result<System.Collections.Generic.List<string>, Error>.Value(new Result<System.Collections.Generic.List<string>, Error>(Error.Create(exception)));
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
		
		public Result<Success, Error>.Value Sort(System.Collections.Generic.IComparer<string>? comparer)
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
		
		public Result<Success, Error>.Value Sort(System.Comparison<string> comparison)
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
		
		public Result<Success, Error>.Value Sort(int index, int count, System.Collections.Generic.IComparer<string>? comparer)
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
		//string[] :: System.Collections.Generic.List<string>.ToArray()
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
		
		public Result<bool, Error>.Value TrueForAll(System.Predicate<string> match)
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