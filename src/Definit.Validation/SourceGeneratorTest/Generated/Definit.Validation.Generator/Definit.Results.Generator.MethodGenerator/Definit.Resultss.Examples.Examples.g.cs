using Definit.Results;
using Definit.Results.NewApproach;
using Definit.Validation;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Resultss.Examples;

partial class Examples 
{
	
	private Definit.Results.NewApproach.Either<int, string, Definit.Resultss.Examples.NotFound> PrivateRun(int i)
	{
	    try
	    {
	        return ResultHelper.ToReturn<Definit.Resultss.Examples.ResultExample2<int>, Definit.Results.NewApproach.Either<int, string, Definit.Resultss.Examples.NotFound>>(_PrivateRun(i));
	    }
	    catch (Exception exception)
	    {
	        return ResultHelper.ToReturn<Definit.Resultss.Examples.ResultExample2<int>, Definit.Results.NewApproach.Either<int, string, Definit.Resultss.Examples.NotFound>>(exception);
	    }
	}
	
	private Definit.Results.NewApproach.Either<string, Definit.Resultss.Examples.NotFound> PrivateRun(string t)
	{
	    try
	    {
	        return ResultHelper.ToReturn<Definit.Results.NewApproach.Result<string>.Error<Definit.Resultss.Examples.NotFound>, Definit.Results.NewApproach.Either<string, Definit.Resultss.Examples.NotFound>>(_PrivateRun(t));
	    }
	    catch (Exception exception)
	    {
	        return ResultHelper.ToReturn<Definit.Results.NewApproach.Result<string>.Error<Definit.Resultss.Examples.NotFound>, Definit.Results.NewApproach.Either<string, Definit.Resultss.Examples.NotFound>>(exception);
	    }
	}
	
	public static async System.Threading.Tasks.Task<Definit.Results.NewApproach.Either<T, Definit.Resultss.Examples.NotFound>> PublicRun<T>(T t)
		where T : Definit.Results.NewApproach.IError<T>
	{
	    try
	    {
	        return ResultHelper.ToReturn<Definit.Results.NewApproach.Result<T>.Error<Definit.Resultss.Examples.NotFound>, Definit.Results.NewApproach.Either<T, Definit.Resultss.Examples.NotFound>>(await _PublicRun(t));
	    }
	    catch (Exception exception)
	    {
	        return ResultHelper.ToReturn<Definit.Results.NewApproach.Result<T>.Error<Definit.Resultss.Examples.NotFound>, Definit.Results.NewApproach.Either<T, Definit.Resultss.Examples.NotFound>>(exception);
	    }
	}
	
}