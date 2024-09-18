
namespace Definit.Results.NewApproach;

public interface IEither<T0, T1, T2> : IEitherBase<(Or<T0>?, Or<T1>?, Or<T2>?)>
    where T0 : notnull
	where T1 : notnull
	where T2 : notnull;

public readonly partial struct Either<T0, T1, T2> : IEither<T0, T1, T2> 
    where T0 : notnull
	where T1 : notnull
	where T2 : notnull
{
    public (Or<T0>?, Or<T1>?, Or<T2>?) Value { get; }
}