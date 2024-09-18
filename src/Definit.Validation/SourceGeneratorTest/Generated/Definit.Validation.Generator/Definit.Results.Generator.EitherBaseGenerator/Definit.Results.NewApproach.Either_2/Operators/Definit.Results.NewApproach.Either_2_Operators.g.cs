namespace Definit.Results.NewApproach;

public readonly partial struct Either<T0, T1> 
{
    public static implicit operator Either<T0, T1>(EitherMatchError error) => throw new EitherMatchException<Either<T0, T1>>();
}
