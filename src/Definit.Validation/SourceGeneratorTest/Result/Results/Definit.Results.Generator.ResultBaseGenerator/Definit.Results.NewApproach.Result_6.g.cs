using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.NewApproach;

public interface IResult<T0, T1, T2, T3, T4, T5> : IResultBase<Either<T0, T1, T2, T3, T4, T5>>
    where T0 : notnull
	where T1 : struct, IError<T1>
	where T2 : struct, IError<T2>
	where T3 : struct, IError<T3>
	where T4 : struct, IError<T4>
	where T5 : struct, IError<T5>;

public readonly struct Result<T0, T1, T2, T3, T4, T5> : IResult<T0, T1, T2, T3, T4, T5> 
    where T0 : notnull
	where T1 : struct, IError<T1>
	where T2 : struct, IError<T2>
	where T3 : struct, IError<T3>
	where T4 : struct, IError<T4>
	where T5 : struct, IError<T5>
{
    private Either<T0, T1, T2, T3, T4, T5> Either { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public Result() => throw new DefaultConstructorException();
	
	public Result(Either<T0, T1, T2, T3, T4, T5> value) => Either = value;
	
	Either<T0, T1, T2, T3, T4, T5> IResultBase<Either<T0, T1, T2, T3, T4, T5>>.Value => Either;
	
	static Either<T0, T1, T2, T3, T4, T5> IResultBase<Either<T0, T1, T2, T3, T4, T5>>.FromException(Exception exception)
	{
	    var T1_match = ErrorHelper.Matches<T1>(exception);
	
	    if(T1_match.Matches)
	    {
	        return T1_match.Error;
	    }
	
	    var T2_match = ErrorHelper.Matches<T2>(exception);
	
	    if(T2_match.Matches)
	    {
	        return T2_match.Error;
	    }
	
	    var T3_match = ErrorHelper.Matches<T3>(exception);
	
	    if(T3_match.Matches)
	    {
	        return T3_match.Error;
	    }
	
	    var T4_match = ErrorHelper.Matches<T4>(exception);
	
	    if(T4_match.Matches)
	    {
	        return T4_match.Error;
	    }
	
	   return ErrorHelper.Matches<T5>(exception).Error;
	}
	
	public static implicit operator Result<T0, T1, T2, T3, T4, T5>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, T3, T4, T5>>();
	public static implicit operator Result<T0, T1, T2, T3, T4, T5>([DisallowNull] T0 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5>([DisallowNull] T1 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5>([DisallowNull] T2 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5>([DisallowNull] T3 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5>([DisallowNull] T4 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5>([DisallowNull] T5 value) => new (value);
}