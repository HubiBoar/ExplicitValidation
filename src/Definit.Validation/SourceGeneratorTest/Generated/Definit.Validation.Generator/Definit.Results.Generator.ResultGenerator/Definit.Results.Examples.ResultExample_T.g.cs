using Definit.Results;
using Definit.Validation;
using Definit.Results.NewApproach;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.Examples
{
	readonly partial struct ResultExample<T> where T : notnull
	{
		
		// Definit.Results.NewApproach.IResult<T, Definit.Results.Examples.NotFound>
		
		private Either<T, Definit.Results.Examples.NotFound> Either { get; }
		
		[Obsolete(DefaultConstructorException.Attribute, true)]
		public ResultExample() => throw new DefaultConstructorException();
		
		public ResultExample(Either<T, Definit.Results.Examples.NotFound> value) => Either = value;
		
		Either<T, Definit.Results.Examples.NotFound> IResultBase<Either<T, Definit.Results.Examples.NotFound>>.Value => Either;
		
		static Either<T, Definit.Results.Examples.NotFound> IResultBase<Either<T, Definit.Results.Examples.NotFound>>.FromException(Exception exception)
		{
		   return ErrorHelper.Matches<Definit.Results.Examples.NotFound>(exception).Error;
		}
		
		public static implicit operator ResultExample<T>([DisallowNull] EitherMatchError _) => throw new EitherMatchException<Either<T, Definit.Results.Examples.NotFound>>();
		public static implicit operator ResultExample<T>([DisallowNull] T value) => new (value);
		public static implicit operator ResultExample<T>([DisallowNull] Definit.Results.Examples.NotFound value) => new (value);
		
	}
}