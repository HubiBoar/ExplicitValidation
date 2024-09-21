namespace Definit.Results;

public readonly struct Success;
public readonly struct Null;

public partial struct Result
{
    public static readonly Success Success = new ();
    public static readonly Null Null = new (); 
    public static readonly EitherMatchError MatchError = new (); 

    public static Either<Success, Error> Try(Action func) 
    {
        try
        {
            func();
            return ResultHelper.ToReturn<Definit.Results.Result, Either<Success, Error>>(Success);
        }
        catch (Exception exception)
        {
            return ResultHelper.ToReturn<Definit.Results.Result, Either<Success, Error>>(exception);
        }
    }

    public static Either<T, Error> Try<T>(Func<T> func)
        where T : notnull
    {
        try
        {
            return ResultHelper.ToReturn<Definit.Results.Result<T>, Either<T, Error>>(func());
        }
        catch (Exception exception)
        {
            return ResultHelper.ToReturn<Definit.Results.Result<T>, Either<T, Error>>(exception);
        }
    }
}
