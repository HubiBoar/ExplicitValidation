#nullable enable

using Definit.Results;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Resultss.Examples;

readonly partial struct ResultExample2<T>
	where T : notnull
{
	private Definit.Results.Either<T, string, Definit.Resultss.Examples.NotFound> Either { get; }
	
	[Obsolete(DefaultConstructorException.Attribute, true)]
	public ResultExample2() => throw new DefaultConstructorException();
	
	public ResultExample2(Definit.Results.Either<T, string, Definit.Resultss.Examples.NotFound> value) => Either = value;
	
	Definit.Results.Either<T, string, Definit.Resultss.Examples.NotFound> IResultBase<Definit.Results.Either<T, string, Definit.Resultss.Examples.NotFound>>.Value => Either;
	
	public static implicit operator Definit.Resultss.Examples.ResultExample2<T>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Definit.Results.Either<T, string, Definit.Resultss.Examples.NotFound>>();
	
	public static implicit operator Definit.Resultss.Examples.ResultExample2<T>(T value) => new (value);
	public static implicit operator Definit.Resultss.Examples.ResultExample2<T>(string value) => new (value);
	public static implicit operator Definit.Resultss.Examples.ResultExample2<T>(Definit.Resultss.Examples.NotFound value) => new (value);
}