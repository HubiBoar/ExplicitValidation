using Definit.Results;
using Definit.Validation;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.NewApproach
{
	readonly partial struct Result<T0, T1, T2> where T0 : notnull
	    where T1 : notnull
	    where T2 : notnull, IError<T2>
	{
		public readonly struct Value : IEither<T0, T1, T2>
		{
		    public Either<T0, T1, T2> Result { get; }
		
		    (Null<T0>?, Null<T1>?, Null<T2>?) IEither<T0, T1, T2>.Value => Result.Value;
		
		    [Obsolete("Must not be used without parameters", true)]                                                                                   
		    public Value() {}                                                                                                                        
		
		    public Value(Definit.Results.NewApproach.Result<T0, T1, T2> result)
		    {
		        Result = result._value;
		    }
		
		    public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1, out Null<T2>? t2) => (t0, t1, t2) = Result;                                                                                                                                          
		}
		
		private readonly Either<T0, T1, T2> _value;                                                                                              
		                                                                                                                                          
		[Obsolete("Must not be used without parameters", true)]                                                                                   
		public Result() {}                                                                                                                        
		                                                                                                                                          
		public Result(Either<T0, T1, T2> value)
		{
		    _value = value;
		}
		                                                                                                                                          
		public static implicit operator Result<T0, T1, T2>([DisallowNull] ResultMatchError value) => throw new ResultMatchException<Definit.Results.NewApproach.Result<T0, T1, T2>>(); 
		
		public static implicit operator Result<T0, T1, T2>([DisallowNull] T0 value) => new (value!); 
		public static implicit operator Result<T0, T1, T2>([DisallowNull] Null<T0> value) => new (value); 
		public static implicit operator Result<T0, T1, T2>([DisallowNull] Null<T0>? value) => new (value!.Value); 
		
		public static implicit operator Result<T0, T1, T2>([DisallowNull] T1 value) => new (value!); 
		public static implicit operator Result<T0, T1, T2>([DisallowNull] Null<T1> value) => new (value); 
		public static implicit operator Result<T0, T1, T2>([DisallowNull] Null<T1>? value) => new (value!.Value); 
		
		public static implicit operator Result<T0, T1, T2>([DisallowNull] T2 value) => new (value!); 
		public static implicit operator Result<T0, T1, T2>([DisallowNull] Null<T2> value) => new (value); 
		public static implicit operator Result<T0, T1, T2>([DisallowNull] Null<T2>? value) => new (value!.Value); 
	}
}