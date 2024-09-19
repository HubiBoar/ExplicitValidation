﻿using Err = Definit.Results.NewApproach.Error;
using Success = Definit.Results.NewApproach.Success;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.NewApproach;

public readonly partial struct Result : Result.Base
{
    public interface Base : IResultBase<Either<Success, Err>>
    {
        static Either<Success, Err> IResultBase<Either<Success, Err>>.FromException(Exception exception)
		{
		   return ErrorHelper.Matches<Err>(exception).Error;
		}
    }
    
    private Either<Success, Err> Either { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public Result() => throw new DefaultConstructorException();
	
	public Result(Either<Success, Err> value) => Either = value;
	
	Either<Success, Err> IResultBase<Either<Success, Err>>.Value => Either;
	
	public static implicit operator Result([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<Success, Err>>();
	public static implicit operator Result([DisallowNull] Success value) => new (value);
	public static implicit operator Result([DisallowNull] Err value) => new (value);




    public readonly struct Error<TE0> : Error<TE0>.Base 
	    where TE0 : struct, IError<TE0>
	{
	    public interface Base : IResultBase<Either<Success, TE0>>
	    {
	        static Either<Success, TE0> IResultBase<Either<Success, TE0>>.FromException(Exception exception)
			{
			   return ErrorHelper.Matches<TE0>(exception).Error;
			}
	    }
	
	    private Either<Success, TE0> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public Error() => throw new DefaultConstructorException();
		
		public Error(Either<Success, TE0> value) => Either = value;
		
		Either<Success, TE0> IResultBase<Either<Success, TE0>>.Value => Either;
		
		public static implicit operator Error<TE0>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<Success, TE0>>();
		public static implicit operator Error<TE0>([DisallowNull] Success value) => new (value);
		public static implicit operator Error<TE0>([DisallowNull] TE0 value) => new (value);
	}


	public readonly struct Error<TE0, TE1> : Error<TE0, TE1>.Base 
	    where TE0 : struct, IError<TE0>
		where TE1 : struct, IError<TE1>
	{
	    public interface Base : IResultBase<Either<Success, TE0, TE1>>
	    {
	        static Either<Success, TE0, TE1> IResultBase<Either<Success, TE0, TE1>>.FromException(Exception exception)
			{
			    var TE0_match = ErrorHelper.Matches<TE0>(exception);
			
			    if(TE0_match.Matches)
			    {
			        return TE0_match.Error;
			    }
			
			   return ErrorHelper.Matches<TE1>(exception).Error;
			}
	    }
	
	    private Either<Success, TE0, TE1> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public Error() => throw new DefaultConstructorException();
		
		public Error(Either<Success, TE0, TE1> value) => Either = value;
		
		Either<Success, TE0, TE1> IResultBase<Either<Success, TE0, TE1>>.Value => Either;
		
		public static implicit operator Error<TE0, TE1>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<Success, TE0, TE1>>();
		public static implicit operator Error<TE0, TE1>([DisallowNull] Success value) => new (value);
		public static implicit operator Error<TE0, TE1>([DisallowNull] TE0 value) => new (value);
		public static implicit operator Error<TE0, TE1>([DisallowNull] TE1 value) => new (value);
	}


	public readonly struct Error<TE0, TE1, TE2> : Error<TE0, TE1, TE2>.Base 
	    where TE0 : struct, IError<TE0>
		where TE1 : struct, IError<TE1>
		where TE2 : struct, IError<TE2>
	{
	    public interface Base : IResultBase<Either<Success, TE0, TE1, TE2>>
	    {
	        static Either<Success, TE0, TE1, TE2> IResultBase<Either<Success, TE0, TE1, TE2>>.FromException(Exception exception)
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
	
	    private Either<Success, TE0, TE1, TE2> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public Error() => throw new DefaultConstructorException();
		
		public Error(Either<Success, TE0, TE1, TE2> value) => Either = value;
		
		Either<Success, TE0, TE1, TE2> IResultBase<Either<Success, TE0, TE1, TE2>>.Value => Either;
		
		public static implicit operator Error<TE0, TE1, TE2>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<Success, TE0, TE1, TE2>>();
		public static implicit operator Error<TE0, TE1, TE2>([DisallowNull] Success value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2>([DisallowNull] TE0 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2>([DisallowNull] TE1 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2>([DisallowNull] TE2 value) => new (value);
	}


	public readonly struct Error<TE0, TE1, TE2, TE3> : Error<TE0, TE1, TE2, TE3>.Base 
	    where TE0 : struct, IError<TE0>
		where TE1 : struct, IError<TE1>
		where TE2 : struct, IError<TE2>
		where TE3 : struct, IError<TE3>
	{
	    public interface Base : IResultBase<Either<Success, TE0, TE1, TE2, TE3>>
	    {
	        static Either<Success, TE0, TE1, TE2, TE3> IResultBase<Either<Success, TE0, TE1, TE2, TE3>>.FromException(Exception exception)
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
	
	    private Either<Success, TE0, TE1, TE2, TE3> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public Error() => throw new DefaultConstructorException();
		
		public Error(Either<Success, TE0, TE1, TE2, TE3> value) => Either = value;
		
		Either<Success, TE0, TE1, TE2, TE3> IResultBase<Either<Success, TE0, TE1, TE2, TE3>>.Value => Either;
		
		public static implicit operator Error<TE0, TE1, TE2, TE3>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<Success, TE0, TE1, TE2, TE3>>();
		public static implicit operator Error<TE0, TE1, TE2, TE3>([DisallowNull] Success value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3>([DisallowNull] TE0 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3>([DisallowNull] TE1 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3>([DisallowNull] TE2 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3>([DisallowNull] TE3 value) => new (value);
	}
}