using Definit.Results;
using Definit.Validation;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.NewApproach
{
	readonly partial struct Result<T0, T1> where T1 : notnull, IError<T1>
	{
		public readonly struct Value : IEither<T0, T1>
		{
		    public Either<T0, T1> Result { get; }
		
		    (Null<T0>?, Null<T1>?) IEither<T0, T1>.Value => Result.Value;
		
		    [Obsolete("Must not be used without parameters", true)]                                                                                   
		    public Value() {}                                                                                                                        
		
		    public Value(Definit.Results.NewApproach.Result<T0, T1> result)
		    {
		        Result = result._value;
		    }
		
		    public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1) => (t0, t1) = Result;                                                                                                                                          
		}
		
		private readonly Either<T0, T1> _value;                                                                                              
		                                                                                                                                          
		[Obsolete("Must not be used without parameters", true)]                                                                                   
		public Result() {}                                                                                                                        
		                                                                                                                                          
		public Result(Either<T0, T1> value)
		{
		    _value = value;
		}
		                                                                                                                                          
		public static implicit operator Result<T0, T1>([DisallowNull] Result.NullError value) => throw new Exception("Definit.Results.NewApproach.Result<T0, T1>"); 
		
		public static implicit operator Result<T0, T1>([DisallowNull] T0 value) => new (value); 
		public static implicit operator Result<T0, T1>([DisallowNull] Null<T0> value) => new (value); 
		public static implicit operator Result<T0, T1>([DisallowNull] Null<T0>? value) => new (value!.Value); 
		
		public static implicit operator Result<T0, T1>([DisallowNull] T1 value) => new (value); 
		public static implicit operator Result<T0, T1>([DisallowNull] Null<T1> value) => new (value); 
		public static implicit operator Result<T0, T1>([DisallowNull] Null<T1>? value) => new (value!.Value); 
	}
}