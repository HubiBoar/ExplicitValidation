namespace Definit.Results.NewApproach;

public readonly partial struct Either<T0, T1, T2, T3, T4> 
{
    public static implicit operator Either<T0, T1, T2, T3, T4>(EitherMatchError error) => throw new EitherMatchException<Either<T0, T1, T2, T3, T4>>();
}
