using Definit.Results;
using Definit.Validation;

namespace Definit.Validation;

partial class Example 
{
	partial class Parent1 
	{
		readonly partial struct Value1 : Definit.Validation.IIsValid<string>
		{
			private readonly static Rule<string> _rule;
			
			static Value1()
			{
			    _rule = new();
			    Rule(_rule);
			}
			
			public string Value { get; }
			
			public Value1(string value)
			{
			    Value = value;
			}
			
			public static implicit operator Definit.Validation.Parent1.Example.Value1(string value) => new (value);
			
			public static implicit operator string(Definit.Validation.Parent1.Example.Value1 value) => value.Value;
			
			public Result Validate() => _rule.Validate(Value);
			
			public Result<Valid> IsValid() => Valid.Create(this);
			
			public readonly struct Valid
			{
			    public Definit.Validation.Parent1.Example.Value1 Value { get; }
			
			    private Valid(Definit.Validation.Parent1.Example.Value1 value)
			    {
			        Value = value;
			    }
			
			    public static Result<Valid> Create(Definit.Validation.Parent1.Example.Value1 value)
			    {
			        if(value.Validate().Is(out Error error))
			        {
			            return error;
			        }
			
			        return new Valid(value);
			    }
			}
		}
	}
}