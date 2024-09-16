namespace Definit.Results.NewApproach;

public interface IResult<T0, T1, T2, T3, T4, T5, T6, T7, T8> : IResultBase<Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>>
    where T0 : notnull
	where T1 : struct, IError<T1>
	where T2 : struct, IError<T2>
	where T3 : struct, IError<T3>
	where T4 : struct, IError<T4>
	where T5 : struct, IError<T5>
	where T6 : struct, IError<T6>
	where T7 : struct, IError<T7>
	where T8 : struct, IError<T8>;

public readonly struct Result<T0, T1, T2, T3, T4, T5, T6, T7, T8> : IResult<T0, T1, T2, T3, T4, T5, T6, T7, T8> 
    where T0 : notnull
	where T1 : struct, IError<T1>
	where T2 : struct, IError<T2>
	where T3 : struct, IError<T3>
	where T4 : struct, IError<T4>
	where T5 : struct, IError<T5>
	where T6 : struct, IError<T6>
	where T7 : struct, IError<T7>
	where T8 : struct, IError<T8>
{
    private Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> Either { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Result() => throw new DefaultConstructorException();

    public Result(Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> value) => Either = value;

    Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> IResultBase<Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>>.Value => Either;

    static Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> IResultBase<Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>>.FromException(Exception exception)
    {
        //TODO error handling
        return T1.Matches(exception).Error;
    }

    public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T1 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T2 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T3 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T4 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T5 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T6 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T7 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T8 value) => new (value);

    public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> value) => new (value);
    // TODO Either Mapping
    // public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Either<T1, T0> value) => new (value);
}