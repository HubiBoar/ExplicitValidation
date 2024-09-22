#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> : Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>.Base 
{
    public interface Base : IEitherBase<(Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?, Or<T6>?, Or<T7>?, Or<T8>?)>;

    public (Or<T0>?, Or<T1>?, Or<T2>?, Or<T3>?, Or<T4>?, Or<T5>?, Or<T6>?, Or<T7>?, Or<T8>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public Either() => throw new DefaultConstructorException();
	
	public Either(T0 value) => Value = (value!, null, null, null, null, null, null, null, null);
	public Either(T1 value) => Value = (null, value!, null, null, null, null, null, null, null);
	public Either(T2 value) => Value = (null, null, value!, null, null, null, null, null, null);
	public Either(T3 value) => Value = (null, null, null, value!, null, null, null, null, null);
	public Either(T4 value) => Value = (null, null, null, null, value!, null, null, null, null);
	public Either(T5 value) => Value = (null, null, null, null, null, value!, null, null, null);
	public Either(T6 value) => Value = (null, null, null, null, null, null, value!, null, null);
	public Either(T7 value) => Value = (null, null, null, null, null, null, null, value!, null);
	public Either(T8 value) => Value = (null, null, null, null, null, null, null, null, value!);
	
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>>();
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T0 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T1 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T2 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T3 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T4 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T5 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T6 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T7 value) => new (value);
	public static implicit operator Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>(T8 value) => new (value);
}

public static partial class EitherExtensions 
{
    public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8> result,
	    out Or<T0>? T0_arg,
		out Or<T1>? T1_arg,
		out Or<T2>? T2_arg,
		out Or<T3>? T3_arg,
		out Or<T4>? T4_arg,
		out Or<T5>? T5_arg,
		out Or<T6>? T6_arg,
		out Or<T7>? T7_arg,
		out Or<T8>? T8_arg
	)
	{
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg, T8_arg) = result.Value;
	}
	
	public static void Deconstruct<T0, T1, T2, T3, T4, T5, T6, T7, T8>
	(
	    this Either<T0, T1, T2, T3, T4, T5, T6, T7, T8>? result,
	    out Or<T0>? T0_arg,
		out Or<T1>? T1_arg,
		out Or<T2>? T2_arg,
		out Or<T3>? T3_arg,
		out Or<T4>? T4_arg,
		out Or<T5>? T5_arg,
		out Or<T6>? T6_arg,
		out Or<T7>? T7_arg,
		out Or<T8>? T8_arg
	)
	{
	    if(result is null)
	    {
	        T0_arg = null; T1_arg = null; T2_arg = null; T3_arg = null; T4_arg = null; T5_arg = null; T6_arg = null; T7_arg = null; T8_arg = null;
	        return;
	    }
	
	    (T0_arg, T1_arg, T2_arg, T3_arg, T4_arg, T5_arg, T6_arg, T7_arg, T8_arg) = result.Value.Value;
	}
}