using Definit.Results;
using Definit.Validation;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.NewApproach
{
	readonly partial struct Result<T0, T1, T2, T3> where T0 : notnull
	    where T1 : notnull
	    where T2 : notnull
	    where T3 : notnull, IError<T3>
	{
		public readonly struct Value : IEither<T0, T1, T2, T3>
		{
		    public Either<T0, T1, T2, T3> Result { get; }
		
		    (Null<T0>?, Null<T1>?, Null<T2>?, Null<T3>?) IEither<T0, T1, T2, T3>.Value => Result.Value;
		
		    [Obsolete("Must not be used without parameters", true)]                                                                                   
		    public Value() {}                                                                                                                        
		
		    public Value(Definit.Results.NewApproach.Result<T0, T1, T2, T3> result)
		    {
		        Result = result._value;
		    }
		
		    public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1, out Null<T2>? t2, out Null<T3>? t3) => (t0, t1, t2, t3) = Result;                                                                                                                                          
		}
		
		private readonly Either<T0, T1, T2, T3> _value;                                                                                              
		                                                                                                                                          
		[Obsolete("Must not be used without parameters", true)]                                                                                   
		public Result() {}                                                                                                                        
		                                                                                                                                          
		public Result(Either<T0, T1, T2, T3> value)
		{
		    _value = value;
		}
		                                                                                                                                          
		public static implicit operator Result<T0, T1, T2, T3>([DisallowNull] ResultMatchError value) => throw new ResultMatchException<Definit.Results.NewApproach.Result<T0, T1, T2, T3>>(); 
		
		public static implicit operator Result<T0, T1, T2, T3>([DisallowNull] T0 value) => new (value!); 
		public static implicit operator Result<T0, T1, T2, T3>([DisallowNull] Null<T0> value) => new (value); 
		public static implicit operator Result<T0, T1, T2, T3>([DisallowNull] Null<T0>? value) => new (value!.Value); 
		
		public static implicit operator Result<T0, T1, T2, T3>([DisallowNull] T1 value) => new (value!); 
		public static implicit operator Result<T0, T1, T2, T3>([DisallowNull] Null<T1> value) => new (value); 
		public static implicit operator Result<T0, T1, T2, T3>([DisallowNull] Null<T1>? value) => new (value!.Value); 
		
		public static implicit operator Result<T0, T1, T2, T3>([DisallowNull] T2 value) => new (value!); 
		public static implicit operator Result<T0, T1, T2, T3>([DisallowNull] Null<T2> value) => new (value); 
		public static implicit operator Result<T0, T1, T2, T3>([DisallowNull] Null<T2>? value) => new (value!.Value); 
		
		public static implicit operator Result<T0, T1, T2, T3>([DisallowNull] T3 value) => new (value!); 
		public static implicit operator Result<T0, T1, T2, T3>([DisallowNull] Null<T3> value) => new (value); 
		public static implicit operator Result<T0, T1, T2, T3>([DisallowNull] Null<T3>? value) => new (value!.Value); 
	}
}