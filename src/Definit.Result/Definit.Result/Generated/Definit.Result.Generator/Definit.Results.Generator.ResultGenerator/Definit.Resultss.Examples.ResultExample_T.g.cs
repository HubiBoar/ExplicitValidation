using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Resultss.Examples;

readonly partial struct ResultExample<T> where T : notnull
{
	private Either<T, Definit.Resultss.Examples.NotFound> Either { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public ResultExample() => throw new DefaultConstructorException();
	
	public ResultExample(Either<T, Definit.Resultss.Examples.NotFound> value) => Either = value;
	
	Either<T, Definit.Resultss.Examples.NotFound> IResultBase<Either<T, Definit.Resultss.Examples.NotFound>>.Value => Either;
	
	public static implicit operator ResultExample<T>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T, Definit.Resultss.Examples.NotFound>>();
	public static implicit operator ResultExample<T>(T value) => new (value);
	public static implicit operator ResultExample<T>(Definit.Resultss.Examples.NotFound value) => new (value);
}