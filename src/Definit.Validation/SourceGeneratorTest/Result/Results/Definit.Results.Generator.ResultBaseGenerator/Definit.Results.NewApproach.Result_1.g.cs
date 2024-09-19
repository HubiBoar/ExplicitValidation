﻿using Err = Definit.Results.NewApproach.Error;
using Success = Definit.Results.NewApproach.Success;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.NewApproach;

public readonly partial struct Result<T0> : Result<T0>.Base
	where T0 : notnull
{
    public interface Base : IResultBase<Either<T0, Err>>;
    
    private Either<T0, Err> Either { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public Result() => throw new DefaultConstructorException();
	
	public Result(Either<T0, Err> value) => Either = value;
	
	Either<T0, Err> IResultBase<Either<T0, Err>>.Value => Either;
	
	static Either<T0, Err> IResultBase<Either<T0, Err>>.FromException(Exception exception)
	{
	   return ErrorHelper.Matches<Err>(exception).Error;
	}
	
	public static implicit operator Result<T0>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, Err>>();
	public static implicit operator Result<T0>([DisallowNull] T0 value) => new (value);
	public static implicit operator Result<T0>([DisallowNull] Err value) => new (value);




    //ERRORS

    public readonly struct Error<TE0> : Error<TE0>.Base 
	    where TE0 : struct, IError<TE0>
	{
	    public interface Base : IResultBase<Either<T0, TE0>>;
	
	    private Either<T0, TE0> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public Error() => throw new DefaultConstructorException();
		
		public Error(Either<T0, TE0> value) => Either = value;
		
		Either<T0, TE0> IResultBase<Either<T0, TE0>>.Value => Either;
		
		static Either<T0, TE0> IResultBase<Either<T0, TE0>>.FromException(Exception exception)
		{
		   return ErrorHelper.Matches<TE0>(exception).Error;
		}
		
		public static implicit operator Error<TE0>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, TE0>>();
		public static implicit operator Error<TE0>([DisallowNull] T0 value) => new (value);
		public static implicit operator Error<TE0>([DisallowNull] TE0 value) => new (value);
	}


	public readonly struct Error<TE0, TE1> : Error<TE0, TE1>.Base 
	    where TE0 : struct, IError<TE0>
		where TE1 : struct, IError<TE1>
	{
	    public interface Base : IResultBase<Either<T0, TE0, TE1>>;
	
	    private Either<T0, TE0, TE1> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public Error() => throw new DefaultConstructorException();
		
		public Error(Either<T0, TE0, TE1> value) => Either = value;
		
		Either<T0, TE0, TE1> IResultBase<Either<T0, TE0, TE1>>.Value => Either;
		
		static Either<T0, TE0, TE1> IResultBase<Either<T0, TE0, TE1>>.FromException(Exception exception)
		{
		    var TE0_match = ErrorHelper.Matches<TE0>(exception);
		
		    if(TE0_match.Matches)
		    {
		        return TE0_match.Error;
		    }
		
		   return ErrorHelper.Matches<TE1>(exception).Error;
		}
		
		public static implicit operator Error<TE0, TE1>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, TE0, TE1>>();
		public static implicit operator Error<TE0, TE1>([DisallowNull] T0 value) => new (value);
		public static implicit operator Error<TE0, TE1>([DisallowNull] TE0 value) => new (value);
		public static implicit operator Error<TE0, TE1>([DisallowNull] TE1 value) => new (value);
	}


	public readonly struct Error<TE0, TE1, TE2> : Error<TE0, TE1, TE2>.Base 
	    where TE0 : struct, IError<TE0>
		where TE1 : struct, IError<TE1>
		where TE2 : struct, IError<TE2>
	{
	    public interface Base : IResultBase<Either<T0, TE0, TE1, TE2>>;
	
	    private Either<T0, TE0, TE1, TE2> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public Error() => throw new DefaultConstructorException();
		
		public Error(Either<T0, TE0, TE1, TE2> value) => Either = value;
		
		Either<T0, TE0, TE1, TE2> IResultBase<Either<T0, TE0, TE1, TE2>>.Value => Either;
		
		static Either<T0, TE0, TE1, TE2> IResultBase<Either<T0, TE0, TE1, TE2>>.FromException(Exception exception)
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
		
		public static implicit operator Error<TE0, TE1, TE2>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, TE0, TE1, TE2>>();
		public static implicit operator Error<TE0, TE1, TE2>([DisallowNull] T0 value) => new (value);
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
	    public interface Base : IResultBase<Either<T0, TE0, TE1, TE2, TE3>>;
	
	    private Either<T0, TE0, TE1, TE2, TE3> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public Error() => throw new DefaultConstructorException();
		
		public Error(Either<T0, TE0, TE1, TE2, TE3> value) => Either = value;
		
		Either<T0, TE0, TE1, TE2, TE3> IResultBase<Either<T0, TE0, TE1, TE2, TE3>>.Value => Either;
		
		static Either<T0, TE0, TE1, TE2, TE3> IResultBase<Either<T0, TE0, TE1, TE2, TE3>>.FromException(Exception exception)
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
		
		public static implicit operator Error<TE0, TE1, TE2, TE3>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, TE0, TE1, TE2, TE3>>();
		public static implicit operator Error<TE0, TE1, TE2, TE3>([DisallowNull] T0 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3>([DisallowNull] TE0 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3>([DisallowNull] TE1 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3>([DisallowNull] TE2 value) => new (value);
		public static implicit operator Error<TE0, TE1, TE2, TE3>([DisallowNull] TE3 value) => new (value);
	}
}