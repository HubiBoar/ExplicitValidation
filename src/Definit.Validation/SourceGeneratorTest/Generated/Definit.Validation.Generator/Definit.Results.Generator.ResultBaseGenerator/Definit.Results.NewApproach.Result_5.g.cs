namespace Definit.Results.NewApproach;

public interface IResult<T0, T1, T2, T3, T4> : IResultBase<Either<T0, T1, T2, T3, T4>>
    where T0 : notnull
	where T1 : struct, IError<T1>
	where T2 : struct, IError<T2>
	where T3 : struct, IError<T3>
	where T4 : struct, IError<T4>;

public readonly struct Result<T0, T1, T2, T3, T4> : IResult<T0, T1, T2, T3, T4> 
    where T0 : notnull
	where T1 : struct, IError<T1>
	where T2 : struct, IError<T2>
	where T3 : struct, IError<T3>
	where T4 : struct, IError<T4>
{
    private Either<T0, T1, T2, T3, T4> Either { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Result() => throw new DefaultConstructorException();

    public Result(Either<T0, T1, T2, T3, T4> value) => Either = value;

    Either<T0, T1, T2, T3, T4> IResultBase<Either<T0, T1, T2, T3, T4>>.Value => Either;

    static Either<T0, T1, T2, T3, T4> IResultBase<Either<T0, T1, T2, T3, T4>>.FromException(Exception exception)
    {
        //TODO error handling
        return T1.Matches(exception).Error;
    }

    public static implicit operator Result<T0, T1, T2, T3, T4>(T0 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4>(T1 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4>(T2 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4>(T3 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4>(T4 value) => new (value);

    public static implicit operator Result<T0, T1, T2, T3, T4>(Either<T0, T1, T2, T3, T4> value) => new (value);
    // TODO Either Mapping
    // public static implicit operator Result<T0, T1, T2, T3, T4>(Either<T1, T0> value) => new (value);
}