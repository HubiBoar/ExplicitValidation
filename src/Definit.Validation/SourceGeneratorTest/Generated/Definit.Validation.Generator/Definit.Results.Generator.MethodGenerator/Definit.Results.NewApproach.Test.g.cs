using Definit.Results;
using Definit.Validation;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.NewApproach
{
	partial class Test 
	{
		
		private Definit.Results.NewApproach.Result<string, Definit.Results.NewApproach.Test.NotFound>.Value PrivateRun(string t) 
		{
		    try
		    {
		        return new Definit.Results.NewApproach.Result<string, Definit.Results.NewApproach.Test.NotFound>.Value(_PrivateRun(t));
		    }
		    catch(Exception exception)
		    {
		        return new Definit.Results.NewApproach.Result<string, Definit.Results.NewApproach.Test.NotFound>.Value(Definit.Results.NewApproach.Test.NotFound.Create(exception)); 
		    }
		}
		
		public static async System.Threading.Tasks.Task<Definit.Results.NewApproach.Result<T, Definit.Results.NewApproach.Test.NotFound>.Value> PublicRun<T>(T t) 
			where T : Definit.Results.NewApproach.IError<T>
		{
		    try
		    {
		        return new Definit.Results.NewApproach.Result<T, Definit.Results.NewApproach.Test.NotFound>.Value(await _PublicRun(t));
		    }
		    catch(Exception exception)
		    {
		        return new Definit.Results.NewApproach.Result<T, Definit.Results.NewApproach.Test.NotFound>.Value(Definit.Results.NewApproach.Test.NotFound.Create(exception)); 
		    }
		}
		
	}
}