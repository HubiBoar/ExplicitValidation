using Definit.Results;

namespace Examples
{
	partial class Parent1 
	{
		partial struct Value1 
		{
			public string Value { get; }
			
			public Value1(string value)
			{
			    Value = value;
			}
			
			public static implicit operator Value1(string value) => new (value);
			
			public static implicit operator string(Value1 value) => value.Value;
			
			public Result Validate() => NewApproach.IIsValid<string>.DefaultValidate(this);
		}
	}
}