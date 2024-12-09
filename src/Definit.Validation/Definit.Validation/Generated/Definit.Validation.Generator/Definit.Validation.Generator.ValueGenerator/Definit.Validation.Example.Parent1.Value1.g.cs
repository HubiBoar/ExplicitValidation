#nullable enable

using Definit.Results;
using Definit.Validation;

namespace Definit.Validation;

partial class Example
{
	partial class Parent1
	{
		readonly partial struct Value1: Definit.Validation.IIsValid<string, Value1.Valid>
		{
			private readonly static Rule<string> _rule;
			
			private const string _NAME = "Value1";
			
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
			
			public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this, propertyName);
			
			public R<ValidationError> Validate(string? propertyName = null) => _rule.Validate(this.Value, propertyName ?? _NAME); 
			
			public readonly struct Valid
			{
			    private const string _NAME = "Value1";
			
			    public Definit.Validation.Example.Parent1.Value1 Value { get; }
			
			    private Valid(Definit.Validation.Example.Parent1.Value1 value)
			    {
			        Value = value;
			    }
			
			    public static U<Valid, ValidationError> Create(Definit.Validation.Example.Parent1.Value1 value, string? propertyName = null)
			    {
			        var (_, error) = value.Validate(propertyName ?? _NAME);
			        if(error is not null)
			        {
			            return error.Value;
			        }
			
			        return new Valid(value);
			    }
			}
		}
	}
}