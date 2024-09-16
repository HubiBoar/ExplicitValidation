namespace Definit.Results.NewApproach;

public interface IResult<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IResultBase<Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>
    where T0 : notnull
	where T1 : struct, IError<T1>
	where T2 : struct, IError<T2>
	where T3 : struct, IError<T3>
	where T4 : struct, IError<T4>
	where T5 : struct, IError<T5>
	where T6 : struct, IError<T6>
	where T7 : struct, IError<T7>
	where T8 : struct, IError<T8>
	where T9 : struct, IError<T9>
	where T10 : struct, IError<T10>;

public readonly struct Result<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IResult<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> 
    where T0 : notnull
	where T1 : struct, IError<T1>
	where T2 : struct, IError<T2>
	where T3 : struct, IError<T3>
	where T4 : struct, IError<T4>
	where T5 : struct, IError<T5>
	where T6 : struct, IError<T6>
	where T7 : struct, IError<T7>
	where T8 : struct, IError<T8>
	where T9 : struct, IError<T9>
	where T10 : struct, IError<T10>
{
    private Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Either { get; }

    [Obsolete(DefaultConstructorException.Attribute, true)]
    public Result() => throw new DefaultConstructorException();

    public Result(Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> value) => Either = value;

    Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> IResultBase<Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>.Value => Either;

    static Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> IResultBase<Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>.FromException(Exception exception)
    {
        //TODO error handling
        return T1.Matches(exception).Error;
    }

    public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T2 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T3 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T4 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T5 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T6 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T7 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T8 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T9 value) => new (value);
	public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T10 value) => new (value);

    public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> value) => new (value);
    // TODO Either Mapping
    // public static implicit operator Result<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Either<T1, T0> value) => new (value);
}