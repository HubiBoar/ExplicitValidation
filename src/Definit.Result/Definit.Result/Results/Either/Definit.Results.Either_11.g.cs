#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>.Base
	where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull
	where T5 : notnull
	where T6 : notnull
	where T7 : notnull
	where T8 : notnull
	where T9 : notnull
	where T10 : notnull 
{
    public interface Base : IEitherBase<(Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?, Or<T6>?, Or<T7>?, Or<T8>?, Or<T9>?, Or<T10>?)>;

    public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?, Or<T6>?, Or<T7>?, Or<T8>?, Or<T9>?, Or<T10>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public Either() => throw new DefaultConstructorException();
	
	public Either(T0 value) => Value = (value!, null, null, null, null, null, null, null, null, null, null);
	public Either(T1 value) => Value = (null, value!, null, null, null, null, null, null, null, null, null);
	public Either(T2 value) => Value = (null, null, value!, null, null, null, null, null, null, null, null);
	public Either(T3 value) => Value = (null, null, null, value!, null, null, null, null, null, null, null);
	public Either(T4 value) => Value = (null, null, null, null, value!, null, null, null, null, null, null);
	public Either(T5 value) => Value = (null, null, null, null, null, value!, null, null, null, null, null);
	public Either(T6 value) => Value = (null, null, null, null, null, null, value!, null, null, null, null);
	public Either(T7 value) => Value = (null, null, null, null, null, null, null, value!, null, null, null);
	public Either(T8 value) => Value = (null, null, null, null, null, null, null, null, value!, null, null);
	public Either(T9 value) => Value = (null, null, null, null, null, null, null, null, null, value!, null);
	public Either(T10 value) => Value = (null, null, null, null, null, null, null, null, null, null, value!);
	
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>();
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T2 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T3 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T4 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T5 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T6 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T7 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T8 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T9 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T10 value) => new (value);
}

public static class EitherExtensions_11 
{
    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> either,
	    out Either<T0, T1, T2, T3, T4, T5>? arg_0,
		out Either<T6, T7, T8, T9, T10>? arg_1
	)
		where T0 : notnull
		where T1 : notnull
		where T2 : notnull
		where T3 : notnull
		where T4 : notnull
		where T5 : notnull
		where T6 : notnull
		where T7 : notnull
		where T8 : notnull
		where T9 : notnull
		where T10 : notnull
	{
	    var (out_0, out_1, out_2, out_3, out_4, out_5, out_6, out_7, out_8, out_9, out_10) = either.Value;
	    arg_0 = out_0 is not null ? new (out_0.Value.Out) : out_1 is not null ? new (out_1.Value.Out) : out_2 is not null ? new (out_2.Value.Out) : out_3 is not null ? new (out_3.Value.Out) : out_4 is not null ? new (out_4.Value.Out) : out_5 is not null ? new (out_5.Value.Out) : null;
		arg_1 = out_6 is not null ? new (out_6.Value.Out) : out_7 is not null ? new (out_7.Value.Out) : out_8 is not null ? new (out_8.Value.Out) : out_9 is not null ? new (out_9.Value.Out) : out_10 is not null ? new (out_10.Value.Out) : null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>? either,
	    out Either<T0, T1, T2, T3, T4, T5>? arg_0,
		out Either<T6, T7, T8, T9, T10>? arg_1
	)
		where T0 : notnull
		where T1 : notnull
		where T2 : notnull
		where T3 : notnull
		where T4 : notnull
		where T5 : notnull
		where T6 : notnull
		where T7 : notnull
		where T8 : notnull
		where T9 : notnull
		where T10 : notnull
	{
	    if(result is null)
	    {
	        arg_0 = null; arg_1 = null;
	        return;
	    }
	
	    var (out_0, out_1, out_2, out_3, out_4, out_5, out_6, out_7, out_8, out_9, out_10) = either.Value.Value;
	    arg_0 = out_0 is not null ? new (out_0.Value.Out) : out_1 is not null ? new (out_1.Value.Out) : out_2 is not null ? new (out_2.Value.Out) : out_3 is not null ? new (out_3.Value.Out) : out_4 is not null ? new (out_4.Value.Out) : out_5 is not null ? new (out_5.Value.Out) : null;
		arg_1 = out_6 is not null ? new (out_6.Value.Out) : out_7 is not null ? new (out_7.Value.Out) : out_8 is not null ? new (out_8.Value.Out) : out_9 is not null ? new (out_9.Value.Out) : out_10 is not null ? new (out_10.Value.Out) : null;
	}
}