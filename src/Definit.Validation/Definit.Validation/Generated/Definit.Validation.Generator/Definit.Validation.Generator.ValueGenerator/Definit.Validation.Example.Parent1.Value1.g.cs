#nullable enable

using Definit.Results;
using Definit.Validation;

namespace Definit.Validation;

partial class Example
{
	partial class Parent1
	{
		readonly partial struct Value1: Definit.Validation.IIsValid<string>
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
			
			public static implicit operator Definit.Validation.Example.Parent1.Value1(string value) => new (value);
			
			public static implicit operator string(Definit.Validation.Example.Parent1.Value1 value) => value.Value;
			
			public ValidationError? Validate(string? propertyName = null) => _rule.Validate(Value, propertyName ?? "Value1");
			
			public Either<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this, propertyName);
			
			public readonly struct Valid
			{
			    public Definit.Validation.Example.Parent1.Value1 Value { get; }
			
			    private Valid(Definit.Validation.Example.Parent1.Value1 value)
			    {
			        Value = value;
			    }
			
			    public static Either<Valid, ValidationError> Create(Definit.Validation.Example.Parent1.Value1 value, string? propertyName = null)
			    {
			        var error = value.Validate(propertyName);
			        if(error is not null)
			        {
			            return error;
			        }
			
			        return new Valid(value);
			    }
			}
		}
	}
}