namespace Definit.Results.NewApproach;

public interface IResult<T0, T1, T2> : IResultBase<Either<T0, T1, T2>>
    where T0 : notnull
	where T1 : struct, IError<T1>
	where T2 : struct, IError<T2>;

public readonly struct Result<T0, T1, T2> : IResult<T0, T1, T2> 
    where T0 : notnull
	where T1 : struct, IError<T1>
	where T2 : struct, IError<T2>
{
    private Either<T0, T1, T2> Either { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Result() => throw new DefaultConstructorException();

    public Result(Either<T0, T1, T2> value) => Either = value;

    Either<T0, T1, T2> IResultBase<Either<T0, T1, T2>>.Value => Either;

    static Either<T0, T1, T2> IResultBase<Either<T0, T1, T2>>.FromException(Exception exception)
    {
        var T1_match = T1.Matches(exception);

        if(T1_match.Matches)
        {
            return T1_match.Error;
        }

       return T2.Matches(exception).Error;
    }

    public static implicit operator Result<T0, T1, T2>(T0 value) => new (value);
	public static implicit operator Result<T0, T1, T2>(T1 value) => new (value);
	public static implicit operator Result<T0, T1, T2>(T2 value) => new (value);
}