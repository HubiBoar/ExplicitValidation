using Definit.Results;
using Definit.Validation;
using Definit.Results.NewApproach;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.Examples
{
	readonly partial struct ResultExample2<T> where T : notnull
	{
		private Either<Definit.Results.NewApproach.Either<T, string>, Definit.Results.Examples.NotFound> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public ResultExample2() => throw new DefaultConstructorException();
		
		public ResultExample2(Either<Definit.Results.NewApproach.Either<T, string>, Definit.Results.Examples.NotFound> value) => Either = value;
		
		Either<Definit.Results.NewApproach.Either<T, string>, Definit.Results.Examples.NotFound> IResultBase<Either<Definit.Results.NewApproach.Either<T, string>, Definit.Results.Examples.NotFound>>.Value => Either;
		
		static Either<Definit.Results.NewApproach.Either<T, string>, Definit.Results.Examples.NotFound> IResultBase<Either<Definit.Results.NewApproach.Either<T, string>, Definit.Results.Examples.NotFound>>.FromException(Exception exception)
		{
		   return ErrorHelper.Matches<Definit.Results.Examples.NotFound>(exception).Error;
		}
		
		public static implicit operator ResultExample2<T>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<Definit.Results.NewApproach.Either<T, string>, Definit.Results.Examples.NotFound>>();
		public static implicit operator ResultExample2<T>([DisallowNull] Definit.Results.NewApproach.Either<T, string> value) => new (value);
		public static implicit operator ResultExample2<T>([DisallowNull] Definit.Results.Examples.NotFound value) => new (value);
		
		public ResultExample2(T value) => Either = new Definit.Results.NewApproach.Either<T, string>(value);
		public ResultExample2(string value) => Either = new Definit.Results.NewApproach.Either<T, string>(value);
		
		public static implicit operator ResultExample2<T>(T value) => new (value);
		public static implicit operator ResultExample2<T>(string value) => new (value);
	}
}