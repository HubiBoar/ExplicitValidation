#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Resultss.Examples;

partial class Examples
{
	
	public PublicUnionsWrapper PublicResults() => new PublicUnionsWrapper(this);
	
	public readonly struct PublicUnionsWrapper
	{
	    private Definit.Resultss.Examples.Examples Value { get; }
	
	    public PublicUnionsWrapper(Definit.Resultss.Examples.Examples value) { Value = value; }
	
	    public U<int, string, Definit.Resultss.Examples.NotFound, System.Exception> PublicRun(int i, System.IO.StringReader reader) 
		{
		    try
		    {
		        var (_arg_0, _arg_1, _arg_2) = this.Value.PublicRun(i, reader);
		
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
	
	private PrivateUnionsWrapper PrivateResults() => new PrivateUnionsWrapper(this);
	
	private readonly struct PrivateUnionsWrapper
	{
	    private Definit.Resultss.Examples.Examples Value { get; }
	
	    public PrivateUnionsWrapper(Definit.Resultss.Examples.Examples value) { Value = value; }
	
	    public U<int, string, Definit.Resultss.Examples.NotFound, System.Exception> PrivateRun(int i) 
		{
		    try
		    {
		        var (_arg_0, _arg_1, _arg_2) = this.Value.PrivateRun(i);
		
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
		
		public U<System.Exception> PrivateRun2(string t) 
		{
		    try
		    {
		        var () = this.Value.PrivateRun2(t);
		
		        return new Definit.Results.UnionMatchError();
		    }
		    catch (Exception exception)
		    {
		        return exception;
		    }
		}
		
		public U<string, Definit.Resultss.Examples.NotFound, System.Exception> PrivateRun(string t) 
		{
		    try
		    {
		        var (_arg_0, _arg_1) = this.Value.PrivateRun(t);
		
		        if (_arg_0 is not null)
		        {
		            return (string)_arg_0;
		        }
		
		        if (_arg_1 is not null)
		        {
		            return (Definit.Resultss.Examples.NotFound)_arg_1;
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