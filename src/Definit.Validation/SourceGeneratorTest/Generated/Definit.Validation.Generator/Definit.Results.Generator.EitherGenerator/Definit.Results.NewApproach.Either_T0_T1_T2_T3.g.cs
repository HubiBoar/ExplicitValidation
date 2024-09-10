using Definit.Results;
using Definit.Validation;
using System.Diagnostics.CodeAnalysis;

namespace Definit.Results.NewApproach
{
	readonly partial struct Either<T0, T1, T2, T3> where T0 : notnull
	    where T1 : notnull
	    where T2 : notnull
	    where T3 : notnull
	{
		public (Null<T0>?, Null<T1>?, Null<T2>?, Null<T3>?) Value { get; }                                                                                              
		                                                                                                                                          
		[Obsolete("Must not be used without parameters", true)]                                                                                   
		public Either() {}                                                                                                                        
		                                                                                                                                          
		public Either([DisallowNull] T0 value) => Value = (value, null, null, null);
		public Either([DisallowNull] T1 value) => Value = (null, value, null, null);
		public Either([DisallowNull] T2 value) => Value = (null, null, value, null);
		public Either([DisallowNull] T3 value) => Value = (null, null, null, value);
		                                                                                                                                          
		public void Deconstruct(out Null<T0>? t0, out Null<T1>? t1, out Null<T2>? t2, out Null<T3>? t3) => (t0, t1, t2, t3) = Value;
		                                                                                                                                          
		public static implicit operator Either<T0, T1, T2, T3>([DisallowNull] ResultMatchError value) => throw new ResultMatchException<Definit.Results.NewApproach.Either<T0, T1, T2, T3>>(); 
		
		public static implicit operator Either<T0, T1, T2, T3>([DisallowNull] T0 value) => new (value!); 
		public static implicit operator Either<T0, T1, T2, T3>([DisallowNull] Null<T0> value) => new (value); 
		public static implicit operator Either<T0, T1, T2, T3>([DisallowNull] Null<T0>? value) => new (value!.Value); 
		
		public static implicit operator Either<T0, T1, T2, T3>([DisallowNull] T1 value) => new (value!); 
		public static implicit operator Either<T0, T1, T2, T3>([DisallowNull] Null<T1> value) => new (value); 
		public static implicit operator Either<T0, T1, T2, T3>([DisallowNull] Null<T1>? value) => new (value!.Value); 
		
		public static implicit operator Either<T0, T1, T2, T3>([DisallowNull] T2 value) => new (value!); 
		public static implicit operator Either<T0, T1, T2, T3>([DisallowNull] Null<T2> value) => new (value); 
		public static implicit operator Either<T0, T1, T2, T3>([DisallowNull] Null<T2>? value) => new (value!.Value); 
		
		public static implicit operator Either<T0, T1, T2, T3>([DisallowNull] T3 value) => new (value!); 
		public static implicit operator Either<T0, T1, T2, T3>([DisallowNull] Null<T3> value) => new (value); 
		public static implicit operator Either<T0, T1, T2, T3>([DisallowNull] Null<T3>? value) => new (value!.Value); 
	}
}