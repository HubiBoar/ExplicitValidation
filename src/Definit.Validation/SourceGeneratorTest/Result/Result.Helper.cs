namespace Definit.Results.NewApproach;

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
            return ResultHelper.ToReturn<Result<Success, Error>, Either<Success, Error>>(Success);
        }
        catch (Exception exception)
        {
            return ResultHelper.ToReturn<Result<Success, Error>, Either<Success, Error>>(exception);
        }
    }

    public static Either<T, Error> Try<T>(Func<T> func)
        where T : notnull
    {
        try
        {
            return ResultHelper.ToReturn<Result<T, Error>, Either<T, Error>>(func());
        }
        catch (Exception exception)
        {
            return ResultHelper.ToReturn<Result<T, Error>, Either<T, Error>>(exception);
        }
    }
}
