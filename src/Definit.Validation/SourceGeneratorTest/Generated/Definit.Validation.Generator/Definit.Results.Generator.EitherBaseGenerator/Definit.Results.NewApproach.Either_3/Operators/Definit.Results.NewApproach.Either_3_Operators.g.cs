namespace Definit.Results.NewApproach;

public readonly partial struct Either<T0, T1, T2> 
{
    public static implicit operator Either<T0, T1, T2>(EitherMatchError error) => throw new EitherMatchException<Either<T0, T1, T2>>();
}
