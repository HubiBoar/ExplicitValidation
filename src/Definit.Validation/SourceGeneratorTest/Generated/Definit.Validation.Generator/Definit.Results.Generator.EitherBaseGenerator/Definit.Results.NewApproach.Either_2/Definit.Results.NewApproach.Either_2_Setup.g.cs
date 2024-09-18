
namespace Definit.Results.NewApproach;

public interface IEither<T0, T1> : IEitherBase<(Or<T0>?, Or<T1>?)>
    where T0 : notnull
	where T1 : notnull;

public readonly partial struct Either<T0, T1> : IEither<T0, T1> 
    where T0 : notnull
	where T1 : notnull
{
    public (Or<T0>?, Or<T1>?) Value { get; }
}