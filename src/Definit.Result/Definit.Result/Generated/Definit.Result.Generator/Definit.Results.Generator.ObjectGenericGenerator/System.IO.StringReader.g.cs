#nullable enable

using Definit.Results;
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
        
		public Error? Close()
		{
		    try
			{
			    this.Value.Close();
			    return (Error?)null;
			}
			catch (Exception exception)
			{
			    return Error.Matches(exception).Error;
			}
		}
		
		public Either<int, Error> Peek()
		{
		    try
			{
			    return new Either<int, Error>((this.Value.Peek())!)
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
			    return new Either<int, Error>((this.Value.Read())!)
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
			    return new Either<int, Error>((this.Value.Read(buffer, index, count))!)
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
			    return new Either<int, Error>((this.Value.Read(buffer))!)
			}
			catch (Exception exception)
			{
			    return new Either<int, Error>(Error.Matches(exception).Error);
			}
		}
		// EXCEPTION
		// System.Threading.Tasks.Task<int> System.IO.StringReader.ReadAsync(char[], int, int) System.NullReferenceException: Object reference not set to an instance of an object.
		//    at Definit.Results.Generator.ObjectGenerator.<GetReturnType>g__IsResult|9_0(ITypeSymbol type) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 371
		//    at Definit.Results.Generator.ObjectGenerator.GetReturnType(IMethodSymbol method) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 333
		//    at Definit.Results.Generator.ObjectGenerator.GenerateMethod(SourceProductionContext context, IMethodSymbol method, String typeName, Boolean allowUnsafe) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 154
		// EXCEPTION
		// System.Threading.Tasks.ValueTask<int> System.IO.StringReader.ReadAsync(System.Memory<char>, System.Threading.CancellationToken) System.NullReferenceException: Object reference not set to an instance of an object.
		//    at Definit.Results.Generator.ObjectGenerator.<GetReturnType>g__IsResult|9_0(ITypeSymbol type) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 371
		//    at Definit.Results.Generator.ObjectGenerator.GetReturnType(IMethodSymbol method) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 351
		//    at Definit.Results.Generator.ObjectGenerator.GenerateMethod(SourceProductionContext context, IMethodSymbol method, String typeName, Boolean allowUnsafe) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 154
		
		public Either<int, Error> ReadBlock(System.Span<char> buffer)
		{
		    try
			{
			    return new Either<int, Error>((this.Value.ReadBlock(buffer))!)
			}
			catch (Exception exception)
			{
			    return new Either<int, Error>(Error.Matches(exception).Error);
			}
		}
		// EXCEPTION
		// System.Threading.Tasks.Task<int> System.IO.StringReader.ReadBlockAsync(char[], int, int) System.NullReferenceException: Object reference not set to an instance of an object.
		//    at Definit.Results.Generator.ObjectGenerator.<GetReturnType>g__IsResult|9_0(ITypeSymbol type) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 371
		//    at Definit.Results.Generator.ObjectGenerator.GetReturnType(IMethodSymbol method) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 333
		//    at Definit.Results.Generator.ObjectGenerator.GenerateMethod(SourceProductionContext context, IMethodSymbol method, String typeName, Boolean allowUnsafe) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 154
		// EXCEPTION
		// System.Threading.Tasks.ValueTask<int> System.IO.StringReader.ReadBlockAsync(System.Memory<char>, System.Threading.CancellationToken) System.NullReferenceException: Object reference not set to an instance of an object.
		//    at Definit.Results.Generator.ObjectGenerator.<GetReturnType>g__IsResult|9_0(ITypeSymbol type) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 371
		//    at Definit.Results.Generator.ObjectGenerator.GetReturnType(IMethodSymbol method) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 351
		//    at Definit.Results.Generator.ObjectGenerator.GenerateMethod(SourceProductionContext context, IMethodSymbol method, String typeName, Boolean allowUnsafe) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 154
		
		public Either<Maybe<string?>, Error> ReadLine()
		{
		    try
			{
			    var method_result = this.Value.ReadLine();
			    var maybe_result = Maybe.Create(method_result); 
			
			    return new Either<Maybe<string?>, Error>(maybe_result);
			}
			catch (Exception exception)
			{
			    return new Either<Maybe<string?>, Error>(Error.Matches(exception).Error);
			}
		}
		// EXCEPTION
		// System.Threading.Tasks.Task<string?> System.IO.StringReader.ReadLineAsync() System.NullReferenceException: Object reference not set to an instance of an object.
		//    at Definit.Results.Generator.ObjectGenerator.<GetReturnType>g__IsResult|9_0(ITypeSymbol type) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 371
		//    at Definit.Results.Generator.ObjectGenerator.GetReturnType(IMethodSymbol method) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 333
		//    at Definit.Results.Generator.ObjectGenerator.GenerateMethod(SourceProductionContext context, IMethodSymbol method, String typeName, Boolean allowUnsafe) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 154
		// EXCEPTION
		// System.Threading.Tasks.ValueTask<string?> System.IO.StringReader.ReadLineAsync(System.Threading.CancellationToken) System.NullReferenceException: Object reference not set to an instance of an object.
		//    at Definit.Results.Generator.ObjectGenerator.<GetReturnType>g__IsResult|9_0(ITypeSymbol type) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 371
		//    at Definit.Results.Generator.ObjectGenerator.GetReturnType(IMethodSymbol method) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 351
		//    at Definit.Results.Generator.ObjectGenerator.GenerateMethod(SourceProductionContext context, IMethodSymbol method, String typeName, Boolean allowUnsafe) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 154
		
		public Either<string, Error> ReadToEnd()
		{
		    try
			{
			    return new Either<string, Error>((this.Value.ReadToEnd())!)
			}
			catch (Exception exception)
			{
			    return new Either<string, Error>(Error.Matches(exception).Error);
			}
		}
		// EXCEPTION
		// System.Threading.Tasks.Task<string> System.IO.StringReader.ReadToEndAsync() System.NullReferenceException: Object reference not set to an instance of an object.
		//    at Definit.Results.Generator.ObjectGenerator.<GetReturnType>g__IsResult|9_0(ITypeSymbol type) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 371
		//    at Definit.Results.Generator.ObjectGenerator.GetReturnType(IMethodSymbol method) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 333
		//    at Definit.Results.Generator.ObjectGenerator.GenerateMethod(SourceProductionContext context, IMethodSymbol method, String typeName, Boolean allowUnsafe) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 154
		// EXCEPTION
		// System.Threading.Tasks.Task<string> System.IO.StringReader.ReadToEndAsync(System.Threading.CancellationToken) System.NullReferenceException: Object reference not set to an instance of an object.
		//    at Definit.Results.Generator.ObjectGenerator.<GetReturnType>g__IsResult|9_0(ITypeSymbol type) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 371
		//    at Definit.Results.Generator.ObjectGenerator.GetReturnType(IMethodSymbol method) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 333
		//    at Definit.Results.Generator.ObjectGenerator.GenerateMethod(SourceProductionContext context, IMethodSymbol method, String typeName, Boolean allowUnsafe) in /workspaces/Definit/src/Definit.Result/Definit.Result.Generator/Generator.Result.Object.cs:line 154
		
    }
}