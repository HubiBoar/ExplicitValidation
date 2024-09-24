#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Either<T0, T1, T2, T3, T4, T5, T6> : Either<T0, T1, T2, T3, T4, T5, T6>.Base
	where T0 : notnull
	where T1 : notnull
	where T2 : notnull
	where T3 : notnull
	where T4 : notnull
	where T5 : notnull
	where T6 : notnull 
{
    public interface Base : IEitherBase<(Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?, Or<T6>?)>;

    public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?, Or<T6>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public Either() => throw new DefaultConstructorException();
	
	public Either(T0 value) => Value = (value!, null, null, null, null, null, null);
	public Either(T1 value) => Value = (null, value!, null, null, null, null, null);
	public Either(T2 value) => Value = (null, null, value!, null, null, null, null);
	public Either(T3 value) => Value = (null, null, null, value!, null, null, null);
	public Either(T4 value) => Value = (null, null, null, null, value!, null, null);
	public Either(T5 value) => Value = (null, null, null, null, null, value!, null);
	public Either(T6 value) => Value = (null, null, null, null, null, null, value!);
	
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, T3, T4, T5, T6>>();
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6>(T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6>(T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6>(T2 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6>(T3 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6>(T4 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6>(T5 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6>(T6 value) => new (value);
}

public static class EitherExtensions_7 
{
    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6> either,
	    out Either<T0, T1, T2, T3>? arg_0,
		out Either<T4, T5, T6>? arg_1
	)
		where T0 : notnull
		where T1 : notnull
		where T2 : notnull
		where T3 : notnull
		where T4 : notnull
		where T5 : notnull
		where T6 : notnull
	{
	    var (out_0, out_1, out_2, out_3, out_4, out_5, out_6) = either.Value;
	    arg_0 = out_0 is not null ? new (out_0.Value.Out) : out_1 is not null ? new (out_1.Value.Out) : out_2 is not null ? new (out_2.Value.Out) : out_3 is not null ? new (out_3.Value.Out) : null;
		arg_1 = out_4 is not null ? new (out_4.Value.Out) : out_5 is not null ? new (out_5.Value.Out) : out_6 is not null ? new (out_6.Value.Out) : null;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6>? either,
	    out Either<T0, T1, T2, T3>? arg_0,
		out Either<T4, T5, T6>? arg_1
	)
		where T0 : notnull
		where T1 : notnull
		where T2 : notnull
		where T3 : notnull
		where T4 : notnull
		where T5 : notnull
		where T6 : notnull
	{
	    if(result is null)
	    {
	        arg_0 = null; arg_1 = null;
	        return;
	    }
	
	    var (out_0, out_1, out_2, out_3, out_4, out_5, out_6) = either.Value.Value;
	    arg_0 = out_0 is not null ? new (out_0.Value.Out) : out_1 is not null ? new (out_1.Value.Out) : out_2 is not null ? new (out_2.Value.Out) : out_3 is not null ? new (out_3.Value.Out) : null;
		arg_1 = out_4 is not null ? new (out_4.Value.Out) : out_5 is not null ? new (out_5.Value.Out) : out_6 is not null ? new (out_6.Value.Out) : null;
	}
}