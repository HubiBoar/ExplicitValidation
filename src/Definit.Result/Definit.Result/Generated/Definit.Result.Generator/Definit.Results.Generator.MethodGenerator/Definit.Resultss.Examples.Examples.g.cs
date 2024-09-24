#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Resultss.Examples;

partial class Examples
	
{
	
	private Definit.Results.Either<int, string, Definit.Resultss.Examples.NotFound> PrivateRun(int i)
		
	{
	    try
	    {
	        return ResultHelper.ToReturn<Definit.Resultss.Examples.ResultExample2<int>, Definit.Results.Either<int, string, Definit.Resultss.Examples.NotFound>>(_PrivateRun(i));
	    }
	    catch (Exception exception)
	    {
	        return ResultHelper.ToReturn<Definit.Resultss.Examples.ResultExample2<int>, Definit.Results.Either<int, string, Definit.Resultss.Examples.NotFound>>(exception);
	    }
	}
	
	private Definit.Results.Error? PrivateRun2(string t)
		
	{
	    try
	    {
	        return ResultHelper.ToReturn<Definit.Results.Result, Definit.Results.Error?>(_PrivateRun2(t));
	    }
	    catch (Exception exception)
	    {
	        return ResultHelper.ToReturn<Definit.Results.Result, Definit.Results.Error?>(exception);
	    }
	}
	
	private Definit.Results.Either<string, Definit.Resultss.Examples.NotFound> PrivateRun(string t)
		
	{
	    try
	    {
	        return ResultHelper.ToReturn<Definit.Results.Result<string>.Error<Definit.Resultss.Examples.NotFound>, Definit.Results.Either<string, Definit.Resultss.Examples.NotFound>>(_PrivateRun(t));
	    }
	    catch (Exception exception)
	    {
	        return ResultHelper.ToReturn<Definit.Results.Result<string>.Error<Definit.Resultss.Examples.NotFound>, Definit.Results.Either<string, Definit.Resultss.Examples.NotFound>>(exception);
	    }
	}
	
	public static async System.Threading.Tasks.Task<Definit.Results.Either<T, Definit.Resultss.Examples.NotFound>> PublicRun<T>(T t)
		where T : struct, Definit.Results.IError<T>, Definit.Results.IError
	{
	    try
	    {
	        return ResultHelper.ToReturn<Definit.Results.Result<T>.Error<Definit.Resultss.Examples.NotFound>, Definit.Results.Either<T, Definit.Resultss.Examples.NotFound>>(await _PublicRun(t));
	    }
	    catch (Exception exception)
	    {
	        return ResultHelper.ToReturn<Definit.Results.Result<T>.Error<Definit.Resultss.Examples.NotFound>, Definit.Results.Either<T, Definit.Resultss.Examples.NotFound>>(exception);
	    }
	}
	
}