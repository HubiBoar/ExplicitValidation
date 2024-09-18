﻿namespace Definit.Results.NewApproach;

public interface IResult<T0, T1, T2, T3> : IResultBase<Either<T0, T1, T2, T3>>
    where T0 : notnull
	where T1 : struct, IError<T1>
	where T2 : struct, IError<T2>
	where T3 : struct, IError<T3>;

public readonly struct Result<T0, T1, T2, T3> : IResult<T0, T1, T2, T3> 
    where T0 : notnull
	where T1 : struct, IError<T1>
	where T2 : struct, IError<T2>
	where T3 : struct, IError<T3>
{
    private Either<T0, T1, T2, T3> Either { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Result() => throw new DefaultConstructorException();

    public Result(Either<T0, T1, T2, T3> value) => Either = value;

    Either<T0, T1, T2, T3> IResultBase<Either<T0, T1, T2, T3>>.Value => Either;

    static Either<T0, T1, T2, T3> IResultBase<Either<T0, T1, T2, T3>>.FromException(Exception exception)
    {
        var T1_match = T1.Matches(exception);

        if(T1_match.Matches)
        {
            return T1_match.Error;
        }

        var T2_match = T2.Matches(exception);

        if(T2_match.Matches)
        {
            return T2_match.Error;
        }

       return T3.Matches(exception).Error;
    }

    public static implicit operator Result<T0, T1, T2, T3>(T0 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3>(T1 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3>(T2 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3>(T3 value) => new (value);
}