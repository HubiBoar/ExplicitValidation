using Definit.Results;
using Definit.Validation;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.NewApproach
{
	readonly partial struct Either<T0> 
	{
		public (Null<T0>?, Null<string>?) Value { get; }                                                                                              
		                                                                                                                                          
		[Obsolete("Must not be used without parameters", true)]                                                                                   
		public Either() {}                                                                                                                        
		                                                                                                                                          
		public Either([DisallowNull] T0 value) => Value = (value, null);
		public Either([DisallowNull] string value) => Value = (null, value);
		                                                                                                                                          
		public void Deconstruct(out Null<T0>? t0, out Null<string>? t1) => (t0, t1) = Value;
		                                                                                                                                          
		public static implicit operator Either<T0>([DisallowNull] Result.NullError value) => throw new Exception("Definit.Results.NewApproach.Either<T0>"); 
		
		public static implicit operator Either<T0>([DisallowNull] T0 value) => new (value); 
		public static implicit operator Either<T0>([DisallowNull] Null<T0> value) => new (value); 
		public static implicit operator Either<T0>([DisallowNull] Null<T0>? value) => new (value!.Value); 
		
		public static implicit operator Either<T0>([DisallowNull] string value) => new (value); 
		public static implicit operator Either<T0>([DisallowNull] Null<string> value) => new (value); 
		public static implicit operator Either<T0>([DisallowNull] Null<string>? value) => new (value!.Value); 
	}
}