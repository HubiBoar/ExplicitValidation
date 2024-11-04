#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Resultss.Examples;

public static class Examples_Extensions_U
{
    public static UnionsWrapper Results(this Definit.Resultss.Examples.Examples value)
    {
        return new UnionsWrapper() { Value = value };
    }

    public readonly struct UnionsWrapper
    {
        public required Definit.Resultss.Examples.Examples Value { get; init; }

        public U<int, string, Definit.Resultss.Examples.NotFound, System.Exception> PublicRun(int i) 
		{
		    try
		    {
		        var (_arg_0, _arg_1, _arg_2) = this.Value.PublicRun(i);
		
		        if (_arg_0 is not null)
		        {
		            return (int)_arg_0;
		        }
		
		        if (_arg_1 is not null)
		        {
		            return (string)_arg_1;
		        }
		
		        if (_arg_2 is not null)
		        {
		            return (Definit.Resultss.Examples.NotFound)_arg_2;
		        }
		
		        
		        return new Definit.Results.UnionMatchError();
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
    }
}