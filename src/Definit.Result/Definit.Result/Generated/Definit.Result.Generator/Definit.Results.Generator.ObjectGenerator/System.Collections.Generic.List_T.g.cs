#nullable enable

using Definit.Results;
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
        
		public Error? Add(T item)
		{
		    try
			{
			    this.Value.Add(item);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Error? AddRange(System.Collections.Generic.IEnumerable<T> collection)
		{
		    try
			{
			    this.Value.AddRange(collection);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Either<System.Collections.ObjectModel.ReadOnlyCollection<T>, Error> AsReadOnly()
		{
		    try
			{
			    return new Either<System.Collections.ObjectModel.ReadOnlyCollection<T>, Error>((this.Value.AsReadOnly())!)
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
			    return new Either<int, Error>((this.Value.BinarySearch(index, count, item, comparer))!)
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
			    return new Either<int, Error>((this.Value.BinarySearch(item))!)
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
			    return new Either<int, Error>((this.Value.BinarySearch(item, comparer))!)
			}
			catch (Exception exception)
			{
			    return new Either<int, Error>(Error.Matches(exception).Error);
			}
		}
		
		public Error? Clear()
		{
		    try
			{
			    this.Value.Clear();
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Either<bool, Error> Contains(T item)
		{
		    try
			{
			    return new Either<bool, Error>((this.Value.Contains(item))!)
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
			    return new Either<System.Collections.Generic.List<TOutput>, Error>((this.Value.ConvertAll(converter))!)
			}
			catch (Exception exception)
			{
			    return new Either<System.Collections.Generic.List<TOutput>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public Error? CopyTo(int index, T[] array, int arrayIndex, int count)
		{
		    try
			{
			    this.Value.CopyTo(index, array, arrayIndex, count);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Error? CopyTo(T[] array)
		{
		    try
			{
			    this.Value.CopyTo(array);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Error? CopyTo(T[] array, int arrayIndex)
		{
		    try
			{
			    this.Value.CopyTo(array, arrayIndex);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Either<int, Error> EnsureCapacity(int capacity)
		{
		    try
			{
			    return new Either<int, Error>((this.Value.EnsureCapacity(capacity))!)
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
			    return new Either<bool, Error>((this.Value.Exists(match))!)
			}
			catch (Exception exception)
			{
			    return new Either<bool, Error>(Error.Matches(exception).Error);
			}
		}
		
		public Either<Maybe<T?>, Error> Find(System.Predicate<T> match)
		{
		    try
			{
			    var method_result = this.Value.Find(match);
			    var maybe_result = Maybe.Create(method_result); 
			
			    return new Either<Maybe<T?>, Error>(maybe_result);
			}
			catch (Exception exception)
			{
			    return new Either<Maybe<T?>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public Either<System.Collections.Generic.List<T>, Error> FindAll(System.Predicate<T> match)
		{
		    try
			{
			    return new Either<System.Collections.Generic.List<T>, Error>((this.Value.FindAll(match))!)
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
			    return new Either<int, Error>((this.Value.FindIndex(startIndex, count, match))!)
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
			    return new Either<int, Error>((this.Value.FindIndex(startIndex, match))!)
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
			    return new Either<int, Error>((this.Value.FindIndex(match))!)
			}
			catch (Exception exception)
			{
			    return new Either<int, Error>(Error.Matches(exception).Error);
			}
		}
		
		public Either<Maybe<T?>, Error> FindLast(System.Predicate<T> match)
		{
		    try
			{
			    var method_result = this.Value.FindLast(match);
			    var maybe_result = Maybe.Create(method_result); 
			
			    return new Either<Maybe<T?>, Error>(maybe_result);
			}
			catch (Exception exception)
			{
			    return new Either<Maybe<T?>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public Either<int, Error> FindLastIndex(int startIndex, int count, System.Predicate<T> match)
		{
		    try
			{
			    return new Either<int, Error>((this.Value.FindLastIndex(startIndex, count, match))!)
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
			    return new Either<int, Error>((this.Value.FindLastIndex(startIndex, match))!)
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
			    return new Either<int, Error>((this.Value.FindLastIndex(match))!)
			}
			catch (Exception exception)
			{
			    return new Either<int, Error>(Error.Matches(exception).Error);
			}
		}
		
		public Error? ForEach(System.Action<T> action)
		{
		    try
			{
			    this.Value.ForEach(action);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Either<System.Collections.Generic.List<T>.Enumerator, Error> GetEnumerator()
		{
		    try
			{
			    return new Either<System.Collections.Generic.List<T>.Enumerator, Error>((this.Value.GetEnumerator())!)
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
			    return new Either<System.Collections.Generic.List<T>, Error>((this.Value.GetRange(index, count))!)
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
			    return new Either<int, Error>((this.Value.IndexOf(item))!)
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
			    return new Either<int, Error>((this.Value.IndexOf(item, index))!)
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
			    return new Either<int, Error>((this.Value.IndexOf(item, index, count))!)
			}
			catch (Exception exception)
			{
			    return new Either<int, Error>(Error.Matches(exception).Error);
			}
		}
		
		public Error? Insert(int index, T item)
		{
		    try
			{
			    this.Value.Insert(index, item);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Error? InsertRange(int index, System.Collections.Generic.IEnumerable<T> collection)
		{
		    try
			{
			    this.Value.InsertRange(index, collection);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Either<int, Error> LastIndexOf(T item)
		{
		    try
			{
			    return new Either<int, Error>((this.Value.LastIndexOf(item))!)
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
			    return new Either<int, Error>((this.Value.LastIndexOf(item, index))!)
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
			    return new Either<int, Error>((this.Value.LastIndexOf(item, index, count))!)
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
			    return new Either<bool, Error>((this.Value.Remove(item))!)
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
			    return new Either<int, Error>((this.Value.RemoveAll(match))!)
			}
			catch (Exception exception)
			{
			    return new Either<int, Error>(Error.Matches(exception).Error);
			}
		}
		
		public Error? RemoveAt(int index)
		{
		    try
			{
			    this.Value.RemoveAt(index);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Error? RemoveRange(int index, int count)
		{
		    try
			{
			    this.Value.RemoveRange(index, count);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Error? Reverse()
		{
		    try
			{
			    this.Value.Reverse();
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Error? Reverse(int index, int count)
		{
		    try
			{
			    this.Value.Reverse(index, count);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Either<System.Collections.Generic.List<T>, Error> Slice(int start, int length)
		{
		    try
			{
			    return new Either<System.Collections.Generic.List<T>, Error>((this.Value.Slice(start, length))!)
			}
			catch (Exception exception)
			{
			    return new Either<System.Collections.Generic.List<T>, Error>(Error.Matches(exception).Error);
			}
		}
		
		public Error? Sort()
		{
		    try
			{
			    this.Value.Sort();
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Error? Sort(System.Collections.Generic.IComparer<T>? comparer)
		{
		    try
			{
			    this.Value.Sort(comparer);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Error? Sort(System.Comparison<T> comparison)
		{
		    try
			{
			    this.Value.Sort(comparison);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Error? Sort(int index, int count, System.Collections.Generic.IComparer<T>? comparer)
		{
		    try
			{
			    this.Value.Sort(index, count, comparer);
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		// EXCEPTION
		// T[] System.Collections.Generic.List<T>.ToArray() System.NullReferenceException: Object reference not set to an instance of an object.
		//    at Definit.Results.Generator.ObjectGenerator.GetReturnType(IMethodSymbol method) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 294
		//    at Definit.Results.Generator.ObjectGenerator.GenerateMethod(SourceProductionContext context, IMethodSymbol method, String typeName, Boolean allowUnsafe) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 154
		
		public Error? TrimExcess()
		{
		    try
			{
			    this.Value.TrimExcess();
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Either<bool, Error> TrueForAll(System.Predicate<T> match)
		{
		    try
			{
			    return new Either<bool, Error>((this.Value.TrueForAll(match))!)
			}
			catch (Exception exception)
			{
			    return new Either<bool, Error>(Error.Matches(exception).Error);
			}
		}
		
    }
}