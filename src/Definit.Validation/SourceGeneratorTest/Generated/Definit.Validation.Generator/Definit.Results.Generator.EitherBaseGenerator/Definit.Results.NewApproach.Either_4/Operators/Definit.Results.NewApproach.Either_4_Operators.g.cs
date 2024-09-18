namespace Definit.Results.NewApproach;

public readonly partial struct Either<T0, T1, T2, T3> 
{
    public static implicit operator Either<T0, T1, T2, T3>(EitherMatchError error) => throw new EitherMatchException<Either<T0, T1, T2, T3>>();
}
