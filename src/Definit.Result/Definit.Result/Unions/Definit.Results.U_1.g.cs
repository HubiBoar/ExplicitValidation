#nullable enable

using System.Diagnostics.CodeAnalysis;
using Definit.Resultss.Examples;

namespace Definit.Results;

public readonly struct Success;

public static class U
{
    public static Success Success { get; } = new Success();
}

public interface IUnionInfo<TError> : IUnionBase<(Or<Success>?, Or<TError>?)>
	where TError : notnull;

public readonly struct U<TError> : U<TError>.Base
	where TError : notnull 
{
    public interface Base : IUnionInfo<TError>;

    public (Or<Success>?, Or<TError>?) Value { get; }

	[Obsolete(DefaultConstructorException.Attribute, true)]
	public U() => throw new DefaultConstructorException();
	
	public U(Success value) => Value = (value!, null);
	public U(TError value) => Value = (null, value!);
	
	public static implicit operator U<TError>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<U<TError>>();
	public static implicit operator U<TError>(Success value) => new (value);
	public static implicit operator U<TError>(TError value) => new (value);
}

public static class Extensions_U_1_1
{
    public static TError? Error<TError>
	(
	    this U<TError> either
	)
		where TError : struct
	{
	    var (_out_0, _out_1) = either.Value;
		return _out_1?.Out ?? null;
	}
}

public static class Extensions_U_1_2
{
    public static TError? Error<TError>
	(
	    this U<TError> either
	)
		where TError : class
	{
	    var (_out_0, _out_1) = either.Value;
		return _out_1?.Out ?? null;
	}
}

public static class Test
{
    public static U<NotFound> GetNotFound()
    {
        return U.Success;
    }

    public static U<Exception> Get()
    {
        return U.Success;
    }

    public static void Run()
    {
        var error = Get().Error();
        if(error is not null)
        {

        }
        var error2 = GetNotFound().Error();
        if(error2 is not null)
        {

        }
    }
}
