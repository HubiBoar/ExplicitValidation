using static Definit.NewApproach.Result;

namespace Definit.NewApproach;

file static partial class Test
{
    private static int Run()
    {
        var (str, notFound) = NewResult();

        if(str is null)
        {
            return 0;
        }

        var (i, not) = NewResult(str);

        if(i is null)
        {
            return 0;
        }

        return i.Value;
    }

    [Method<Private>]
    private static CustomResult _NewResult()  
    {
        var (j, not) = NewResult("test");

        if(j is null) return new NotFound(); 

        return j.Value.ToString();
    } 

    [Method<Public>]
    private static Result<int, Not> _NewResult(string str)  
    {
        return 5;
    } 

    //Auto generated
    public static CustomResult.Value NewResult()  
    {
        try
        {
            return new (_NewResult());
        }
        catch(Exception ex)
        {
            return new (new CustomResult(NotFound.Create(ex)));
        }
    } 
    //
    //Auto generated
    public static Result<int, Not>.Value NewResult(string str)  
    {
        try
        {
            return new (_NewResult(str));
        }
        catch(Exception ex)
        {
            return new (new Result<int, Not>(Not.Create(ex)));
        }
    } 
}

public readonly struct NotFound() : IError<NotFound>
{
    public static NotFound Create(Exception exception) => new NotFound();
}

public readonly struct Not() : IError<Not>
{
    public static Not Create(Exception exception) => new Not();
}

[Result<string, NotFound>]
public readonly partial struct CustomResult;


//Auto generated
public readonly partial struct CustomResult : IResult<string, NotFound>
{
    public readonly struct Value
    {
        public Either<string, NotFound> Result { get; }

        [Obsolete("Must not be used without parameters", true)]
        public Value() {}

        internal Value(CustomResult result)
        {
            Result = result._value;
        }

        public void Deconstruct(out Null<string>? t0, out Null<NotFound>? t1) => (t0, t1) = Result;
    }

    private readonly Either<string, NotFound> _value;

    internal CustomResult(Either<string, NotFound> value)
    {
        _value = value;
    }

    public static implicit operator CustomResult([DisallowNull] Result.NullError value) => new (value);
    public static implicit operator CustomResult([DisallowNull] string value) => new (value);
    public static implicit operator CustomResult([DisallowNull] NotFound value) => new (value);
    public static implicit operator CustomResult([DisallowNull] Null<string> value) => new (value);
    public static implicit operator CustomResult([DisallowNull] Null<NotFound> value) => new (value);
    public static implicit operator CustomResult([DisallowNull] Null<string>? value) => new (value!.Value);
    public static implicit operator CustomResult([DisallowNull] Null<NotFound>? value) => new (value!.Value);
}
