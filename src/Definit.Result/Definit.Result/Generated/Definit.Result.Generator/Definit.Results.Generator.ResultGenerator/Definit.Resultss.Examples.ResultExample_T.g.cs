#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Resultss.Examples;

readonly partial struct ResultExample<T>
	where T : notnull
{
	private Definit.Results.Either<T, Definit.Resultss.Examples.NotFound> Either { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public ResultExample() => throw new DefaultConstructorException();
	
	public ResultExample(Definit.Results.Either<T, Definit.Resultss.Examples.NotFound> value) => Either = value;
	
	Definit.Results.Either<T, Definit.Resultss.Examples.NotFound> IResultBase<Definit.Results.Either<T, Definit.Resultss.Examples.NotFound>>.Value => Either;
	
	public static implicit operator Definit.Resultss.Examples.ResultExample<T>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Definit.Results.Either<T, Definit.Resultss.Examples.NotFound>>();
	
	public static implicit operator Definit.Resultss.Examples.ResultExample<T>(T value) => new (value);
}