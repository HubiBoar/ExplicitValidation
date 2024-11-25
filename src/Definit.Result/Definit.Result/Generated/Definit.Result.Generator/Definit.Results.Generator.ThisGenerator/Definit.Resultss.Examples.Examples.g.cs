﻿#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Resultss.Examples;

public static class Examples_Extensions_U
{
    public static UnionsWrapper Try(this Definit.Resultss.Examples.Examples value)
    {
        return new UnionsWrapper() { Value = value };
    }

    public readonly struct UnionsWrapper
    {
        public required Definit.Resultss.Examples.Examples Value { get; init; }

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
		
		public R<System.Exception> PrivateRun2(string t) 
		{
		    try
		    {
		        this.Value.PrivateRun2(t);
		        return R.Success;
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
		        var (_arg_0, _arg_1, _arg_2) = this.Value.PrivateRun(t);
		
		        if (_arg_0 is not null)
		        {
		            return (string)_arg_0;
		        }
		
		        if (_arg_1 is not null)
		        {
		            return (System.Exception)_arg_1;
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
		
		public async System.Threading.Tasks.Task<U<T, Definit.Resultss.Examples.NotFound, System.Exception>> PublicRun<T>(T t)
			where T : struct, Definit.Results.IError<T> 
		{
		    try
		    {
		        var (_arg_0, _arg_1) = await this.Value.PublicRun(t);
		
		        if (_arg_0 is not null)
		        {
		            return (T)_arg_0;
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