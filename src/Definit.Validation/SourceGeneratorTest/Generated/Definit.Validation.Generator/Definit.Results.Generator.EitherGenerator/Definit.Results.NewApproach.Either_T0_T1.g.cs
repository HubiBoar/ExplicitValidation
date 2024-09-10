using Definit.Results;
using Definit.Validation;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.NewApproach
{
	readonly partial struct Either<T0, T1> where T0 : notnull
	    where T1 : notnull
	{
		public (Null<T0>?, Null<T1>?) Value { get; }                                                                                              
		                                                                                                                                          
		[Obsolete("Must not be used without parameters", true)]                                                                                   
		public Either() {}                                                                                                                        
		                                                                                                                                          
		public Either([DisallowNull] T0 value) => Value = (value, null);
		public Either([DisallowNull] T1 value) => Value = (null, value);
		                                                                                                                                          
		public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1) => (t0, t1) = Value;
		                                                                                                                                          
		public static implicit operator Either<T0, T1>([DisallowNull] ResultMatchError value) => throw new ResultMatchException<Definit.Results.NewApproach.Either<T0, T1>>(); 
		
		public static implicit operator Either<T0, T1>([DisallowNull] T0 value) => new (value!); 
		public static implicit operator Either<T0, T1>([DisallowNull] Null<T0> value) => new (value); 
		public static implicit operator Either<T0, T1>([DisallowNull] Null<T0>? value) => new (value!.Value); 
		
		public static implicit operator Either<T0, T1>([DisallowNull] T1 value) => new (value!); 
		public static implicit operator Either<T0, T1>([DisallowNull] Null<T1> value) => new (value); 
		public static implicit operator Either<T0, T1>([DisallowNull] Null<T1>? value) => new (value!.Value); 
	}
}