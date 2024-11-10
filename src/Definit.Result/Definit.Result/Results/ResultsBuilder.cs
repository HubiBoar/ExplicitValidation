namespace Definit.Results;

public interface IResultBase;

public interface IResult<TSelf, TUnion> : IResultBase
    where TSelf : IResult<TSelf, TUnion>
{
    public static abstract TSelf Create(TUnion value);
}

public readonly struct R : IResult<R, Success>
{
    public static Success Success { get; } = Success.Instance;

    public System.Exception? Error { get; } 

    public static R Create(Success value)
    {
        return value;
    }
    
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public R() => throw new DefaultConstructorException();
	
	public R(Definit.Results.Success value) => Error = null;
	public R(System.Exception value) => Error = value;
	
	public static implicit operator R(Definit.Results.Success value) => new (value);
	public static implicit operator R(System.Exception value) => new (value);
}

//[GenerateUnion]
public readonly partial struct R<T> : U<T, System.Exception>.Base, IResult<R<T>, T>
    where T : notnull
{
    public static R<T> Create(T value)
    {
        return value;
    }
}

//[GenerateUnion]
public readonly partial struct R<T0, T1> : U<T0, T1, System.Exception>.Base, IResult<R<T0, T1>, U<T0, T1>>
    where T0 : notnull
    where T1 : notnull
{
    public static R<T0, T1> Create(U<T0, T1> value)
    {
        var (t0, t1) = value.Value;

        if(t0 is not null)
        {
            return t0.Value.Out;
        }

        if(t1 is not null)
        {
            return t1.Value.Out;
        }

        return new UnionMatchError();
    }
}

//[GenerateUnion]
public readonly partial struct R<T0, T1, T2> : U<T0, T1, T2, System.Exception>.Base, IResult<R<T0, T1, T2>, U<T0, T1, T2>>
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull
{
    public static R<T0, T1, T2> Create(U<T0, T1, T2> value)
    {
        var (t0, t1, t2) = value.Value;

        if(t0 is not null)
        {
            return t0.Value.Out;
        }

        if(t1 is not null)
        {
            return t1.Value.Out;
        }

        if(t2 is not null)
        {
            return t2.Value.Out;
        }

        return new UnionMatchError();
    }
}

//[GenerateUnion]
public readonly partial struct R<T0, T1, T2, T3> : U<T0, T1, T2, T3, System.Exception>.Base, IResult<R<T0, T1, T2, T3>, U<T0, T1, T2, T3>>
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
{
    public static R<T0, T1, T2, T3> Create(U<T0, T1, T2, T3> value)
    {
        var (t0, t1, t2, t3) = value.Value;

        if(t0 is not null)
        {
            return t0.Value.Out;
        }

        if(t1 is not null)
        {
            return t1.Value.Out;
        }

        if(t2 is not null)
        {
            return t2.Value.Out;
        }

        if(t3 is not null)
        {
            return t3.Value.Out;
        }

        return new UnionMatchError();
    }
}

//[GenerateUnion]
public readonly partial struct R<T0, T1, T2, T3, T4> : U<T0, T1, T2, T3, T4, System.Exception>.Base, IResult<R<T0, T1, T2, T3, T4>, U<T0, T1, T2, T3, T4>>
    where T0 : notnull
    where T1 : notnull
    where T2 : notnull
    where T3 : notnull
    where T4 : notnull
{
    public static R<T0, T1, T2, T3, T4> Create(U<T0, T1, T2, T3, T4> value)
    {
        var (t0, t1, t2, t3, t4) = value.Value;

        if(t0 is not null)
        {
            return t0.Value.Out;
        }

        if(t1 is not null)
        {
            return t1.Value.Out;
        }

        if(t2 is not null)
        {
            return t2.Value.Out;
        }

        if(t3 is not null)
        {
            return t3.Value.Out;
        }

        if(t4 is not null)
        {
            return t4.Value.Out;
        }

        return new UnionMatchError();
    }
}

public record struct Success
{
    public static Success Instance { get; } = new ();
}
