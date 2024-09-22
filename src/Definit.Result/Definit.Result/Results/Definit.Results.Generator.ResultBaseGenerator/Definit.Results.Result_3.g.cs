using Err = Definit.Results.Error;
using Success = Definit.Results.Success;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Result<T0, T1, T2> : Result<T0, T1, T2>.Base
{
    public interface Base : IResultBase<Either<T0, T1, T2, Err>>
    {
        static Either<T0, T1, T2, Err> IResultBase<Either<T0, T1, T2, Err>>.FromException(Exception exception)
		{
		   return ErrorHelper.Matches<Err>(exception).Error;
		}
    }
    
    private Either<T0, T1, T2, Err> Either { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public Result() => throw new DefaultConstructorException();
	
	public Result(Either<T0, T1, T2, Err> value) => Either = value;
	
	Either<T0, T1, T2, Err> IResultBase<Either<T0, T1, T2, Err>>.Value => Either;
	
	public static implicit operator Result<T0, T1, T2>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, Err>>();
	
	public static implicit operator Result<T0, T1, T2>(T0 value) => new (value);
	public static implicit operator Result<T0, T1, T2>(T1 value) => new (value);
	public static implicit operator Result<T0, T1, T2>(T2 value) => new (value);
	public static implicit operator Result<T0, T1, T2>(Err value) => new (value);


    public readonly struct Error<TE0> : Error<TE0>.Base 
	    where TE0 : struct, IError<TE0>
	{
	    public interface Base : IResultBase<Either<T0, T1, T2, TE0>>
	    {
	        static Either<T0, T1, T2, TE0> IResultBase<Either<T0, T1, T2, TE0>>.FromException(Exception exception)
			{
			   return ErrorHelper.Matches<TE0>(exception).Error;
			}
	    }
	
	    private Either<T0, T1, T2, TE0> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public Error() => throw new DefaultConstructorException();
		
		public Error(Either<T0, T1, T2, TE0> value) => Either = value;
		
		Either<T0, T1, T2, TE0> IResultBase<Either<T0, T1, T2, TE0>>.Value => Either;
		
		public static implicit operator Error<TE0>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, TE0>>();
		
		public static implicit operator Error<TE0>(T0 value) => new (value);
		public static implicit operator Error<TE0>(T1 value) => new (value);
		public static implicit operator Error<TE0>(T2 value) => new (value);
		public static implicit operator Error<TE0>(TE0 value) => new (value);
	}


	public readonly struct Error<TE0, TE1> : Error<TE0, TE1>.Base 
	    where TE0 : struct, IError<TE0>
		where TE1 : struct, IError<TE1>
	{
	    public interface Base : IResultBase<Either<T0, T1, T2, TE0, TE1>>
	    {
	        static Either<T0, T1, T2, TE0, TE1> IResultBase<Either<T0, T1, T2, TE0, TE1>>.FromException(Exception exception)
			{
			    var TE0_match = ErrorHelper.Matches<TE0>(exception);
			
			    if(TE0_match.Matches)
			    {
			        return TE0_match.Error;
			    }
			
			   return ErrorHelper.Matches<TE1>(exception).Error;
			}
	    }
	
	    private Either<T0, T1, T2, TE0, TE1> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public Error() => throw new DefaultConstructorException();
		
		public Error(Either<T0, T1, T2, TE0, TE1> value) => Either = value;
		
		Either<T0, T1, T2, TE0, TE1> IResultBase<Either<T0, T1, T2, TE0, TE1>>.Value => Either;
		
		public static implicit operator Error<TE0, TE1>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, TE0, TE1>>();
		
		public static implicit operator Error<TE0, TE1>(T0 value) => new (value);
		public static implicit operator Error<TE0, TE1>(T1 value) => new (value);
		public static implicit operator Error<TE0, TE1>(T2 value) => new (value);
		public static implicit operator Error<TE0, TE1>(TE0 value) => new (value);
		public static implicit operator Error<TE0, TE1>(TE1 value) => new (value);
	}


	public readonly struct Error<TE0, TE1, TE2> : Error<TE0, TE1, TE2>.Base 
	    where TE0 : struct, IError<TE0>
		where TE1 : struct, IError<TE1>
		where TE2 : struct, IError<TE2>
	{
	    public interface Base : IResultBase<Either<T0, T1, T2, TE0, TE1, TE2>>
	    {
	        static Either<T0, T1, T2, TE0, TE1, TE2> IResultBase<Either<T0, T1, T2, TE0, TE1, TE2>>.FromException(Exception exception)
			{
			    var TE0_match = ErrorHelper.Matches<TE0>(exception);
			
			    if(TE0_match.Matches)
			    {
			        return TE0_match.Error;
			    }
			
			    var TE1_match = ErrorHelper.Matches<TE1>(exception);
			
			    if(TE1_match.Matches)
			    {
			        return TE1_match.Error;
			    }
			
			   return ErrorHelper.Matches<TE2>(exception).Error;
			}
	    }
	
	    private Either<T0, T1, T2, TE0, TE1, TE2> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public Error() => throw new DefaultConstructorException();
		
		public Error(Either<T0, T1, T2, TE0, TE1, TE2> value) => Either = value;
		
		Either<T0, T1, T2, TE0, TE1, TE2> IResultBase<Either<T0, T1, T2, TE0, TE1, TE2>>.Value => Either;
		
		public static implicit operator Error<TE0, TE1, TE2>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, TE0, TE1, TE2>>();
		
		public static implicit operator Error<TE0, TE1, TE2>(T0 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2>(T1 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2>(T2 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2>(TE0 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2>(TE1 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2>(TE2 value) => new (value);
	}


	public readonly struct Error<TE0, TE1, TE2, TE3> : Error<TE0, TE1, TE2, TE3>.Base 
	    where TE0 : struct, IError<TE0>
		where TE1 : struct, IError<TE1>
		where TE2 : struct, IError<TE2>
		where TE3 : struct, IError<TE3>
	{
	    public interface Base : IResultBase<Either<T0, T1, T2, TE0, TE1, TE2, TE3>>
	    {
	        static Either<T0, T1, T2, TE0, TE1, TE2, TE3> IResultBase<Either<T0, T1, T2, TE0, TE1, TE2, TE3>>.FromException(Exception exception)
			{
			    var TE0_match = ErrorHelper.Matches<TE0>(exception);
			
			    if(TE0_match.Matches)
			    {
			        return TE0_match.Error;
			    }
			
			    var TE1_match = ErrorHelper.Matches<TE1>(exception);
			
			    if(TE1_match.Matches)
			    {
			        return TE1_match.Error;
			    }
			
			    var TE2_match = ErrorHelper.Matches<TE2>(exception);
			
			    if(TE2_match.Matches)
			    {
			        return TE2_match.Error;
			    }
			
			   return ErrorHelper.Matches<TE3>(exception).Error;
			}
	    }
	
	    private Either<T0, T1, T2, TE0, TE1, TE2, TE3> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public Error() => throw new DefaultConstructorException();
		
		public Error(Either<T0, T1, T2, TE0, TE1, TE2, TE3> value) => Either = value;
		
		Either<T0, T1, T2, TE0, TE1, TE2, TE3> IResultBase<Either<T0, T1, T2, TE0, TE1, TE2, TE3>>.Value => Either;
		
		public static implicit operator Error<TE0, TE1, TE2, TE3>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, TE0, TE1, TE2, TE3>>();
		
		public static implicit operator Error<TE0, TE1, TE2, TE3>(T0 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3>(T1 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3>(T2 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3>(TE0 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3>(TE1 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3>(TE2 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3>(TE3 value) => new (value);
	}


	public readonly struct Error<TE0, TE1, TE2, TE3, TE4> : Error<TE0, TE1, TE2, TE3, TE4>.Base 
	    where TE0 : struct, IError<TE0>
		where TE1 : struct, IError<TE1>
		where TE2 : struct, IError<TE2>
		where TE3 : struct, IError<TE3>
		where TE4 : struct, IError<TE4>
	{
	    public interface Base : IResultBase<Either<T0, T1, T2, TE0, TE1, TE2, TE3, TE4>>
	    {
	        static Either<T0, T1, T2, TE0, TE1, TE2, TE3, TE4> IResultBase<Either<T0, T1, T2, TE0, TE1, TE2, TE3, TE4>>.FromException(Exception exception)
			{
			    var TE0_match = ErrorHelper.Matches<TE0>(exception);
			
			    if(TE0_match.Matches)
			    {
			        return TE0_match.Error;
			    }
			
			    var TE1_match = ErrorHelper.Matches<TE1>(exception);
			
			    if(TE1_match.Matches)
			    {
			        return TE1_match.Error;
			    }
			
			    var TE2_match = ErrorHelper.Matches<TE2>(exception);
			
			    if(TE2_match.Matches)
			    {
			        return TE2_match.Error;
			    }
			
			    var TE3_match = ErrorHelper.Matches<TE3>(exception);
			
			    if(TE3_match.Matches)
			    {
			        return TE3_match.Error;
			    }
			
			   return ErrorHelper.Matches<TE4>(exception).Error;
			}
	    }
	
	    private Either<T0, T1, T2, TE0, TE1, TE2, TE3, TE4> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public Error() => throw new DefaultConstructorException();
		
		public Error(Either<T0, T1, T2, TE0, TE1, TE2, TE3, TE4> value) => Either = value;
		
		Either<T0, T1, T2, TE0, TE1, TE2, TE3, TE4> IResultBase<Either<T0, T1, T2, TE0, TE1, TE2, TE3, TE4>>.Value => Either;
		
		public static implicit operator Error<TE0, TE1, TE2, TE3, TE4>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, TE0, TE1, TE2, TE3, TE4>>();
		
		public static implicit operator Error<TE0, TE1, TE2, TE3, TE4>(T0 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3, TE4>(T1 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3, TE4>(T2 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3, TE4>(TE0 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3, TE4>(TE1 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3, TE4>(TE2 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3, TE4>(TE3 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3, TE4>(TE4 value) => new (value);
	}
}