#nullable enable

using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

public readonly struct Success;
public readonly struct NotFound;

public static class R
{
    public static Success Success { get; } = new Success();
}

//[Union]
public partial struct R<TError> : U<Success, TError>.Base
    where TError : notnull;


readonly partial struct R<TError>
	where TError : notnull
{
	public (Or<Definit.Results.Success>?, Or<TError>?) Value { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public R() => throw new DefaultConstructorException();
	
	public R(Definit.Results.Success value) => Value = (value!, null);
	public R(TError value) => Value = (null, value!);
	
	public static implicit operator Definit.Results.R<TError>([DisallowNull] Definit.Results.UnionMatchError _) => throw new Definit.Results.UnionMatchException<U<Definit.Results.Success, TError>>();
	public static implicit operator Definit.Results.R<TError>(Definit.Results.Success value) => new (value);
	public static implicit operator Definit.Results.R<TError>(TError value) => new (value);
}

public static partial class R_Extensions_U
{
    public static void Deconstruct<TError>
	(
	    this Definit.Results.R<TError> either,
	    out Definit.Results.Success? _arg_0,
		out TError? _arg_1
	)
		where TError : struct
	{
	    var (_out_0, _out_1) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct<TError>
	(
	    this Definit.Results.R<TError>? either,
	    out Definit.Results.Success? _arg_0,
		out TError? _arg_1
	)
		where TError : struct
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null;
	        return;
	    }
	
	    var (_out_0, _out_1) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct<TError>
	(
	    this Definit.Results.R<TError> either,
	    out Definit.Results.Success? _arg_0,
		out TError? _arg_1
	)
		where TError : class
	{
	    var (_out_0, _out_1) = either.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
	
	public static void Deconstruct<TError>
	(
	    this Definit.Results.R<TError>? either,
	    out Definit.Results.Success? _arg_0,
		out TError? _arg_1
	)
		where TError : class
	{
	    if(either is null)
	    {
	        _arg_0 = null; _arg_1 = null;
	        return;
	    }
	
	    var (_out_0, _out_1) = either.Value.Value;
	    _arg_0 = _out_0?.Out ?? null;
		_arg_1 = _out_1?.Out ?? null;
	}
}


public static class Extensions_R_1_1
{
    public static TError? Error<TError>
	(
	    this R<TError> either
	)
		where TError : struct
	{
	    var (_out_0, _out_1) = either.Value;
		return _out_1?.Out ?? null;
	}
}

public static class Extensions_R_1_2
{
    public static TError? Error<TError>
	(
	    this R<TError> either
	)
		where TError : class
	{
	    var (_out_0, _out_1) = either.Value;
		return _out_1?.Out ?? null;
	}
}

public static class Test
{
    public static R<NotFound> GetNotFound()
    {
        return R.Success;
    }

    public static R<Exception> Get()
    {
        return R.Success;
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
