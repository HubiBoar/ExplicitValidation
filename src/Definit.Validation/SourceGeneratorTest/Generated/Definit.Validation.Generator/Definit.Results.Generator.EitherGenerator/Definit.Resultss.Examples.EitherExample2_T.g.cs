using Definit.Results;
using Definit.Results.NewApproach;
using Definit.Validation;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Resultss.Examples;

readonly partial struct EitherExample2<T> where T : notnull
{
	public (Or<T>?, Or<string>?, Or<int>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public EitherExample2() => throw new DefaultConstructorException();
	
	public EitherExample2(T value) => Value = (value!, null, null);
	public EitherExample2(string value) => Value = (null, value!, null);
	public EitherExample2(int value) => Value = (null, null, value!);
	
	public static implicit operator EitherExample2<T>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T, string, int>>();
	public static implicit operator EitherExample2<T>(T value) => new (value);
	public static implicit operator EitherExample2<T>(string value) => new (value);
	public static implicit operator EitherExample2<T>(int value) => new (value);
}

public static partial class EitherExample2__Auto__Extensions
{
    public static void Deconstruct<T>
	(
	    this EitherExample2<T> result,
	    out Or<T>? T_arg,
		out Or<string>? string_arg,
		out Or<int>? int_arg
	)
	{
	    (T_arg, string_arg, int_arg) = result.Value;
	}
	
	public static void Deconstruct<T>
	(
	    this EitherExample2<T>? result,
	    out Or<T>? T_arg,
		out Or<string>? string_arg,
		out Or<int>? int_arg
	)
	{
	    if(result is null)
	    {
	        T_arg = null; string_arg = null; int_arg = null;
	        return;
	    }
	
	    (T_arg, string_arg, int_arg) = result.Value.Value;
	}
}
