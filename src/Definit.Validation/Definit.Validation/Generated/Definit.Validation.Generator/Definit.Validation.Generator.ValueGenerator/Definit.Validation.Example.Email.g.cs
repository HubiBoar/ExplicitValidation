#nullable enable

using Definit.Results;
using Definit.Validation;

namespace Definit.Validation;

partial class Example
{
	readonly partial struct Email: Definit.Validation.IIsValid<string>
	{
		private readonly static Rule<string> _rule;
		
		static Email()
		{
		    _rule = new();
		    Rule(_rule);
		}
		
		public string Value { get; }
		
		public Email(string value)
		{
		    Value = value;
		}
		
		public static implicit operator Definit.Validation.Example.Email(string value) => new (value);
		
		public static implicit operator string(Definit.Validation.Example.Email value) => value.Value;
		
		public ValidationError? Validate(string? propertyName = null) => _rule.Validate(Value, propertyName);
		
		public Either<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this, propertyName);
		
		public readonly struct Valid
		{
		    public Definit.Validation.Example.Email Value { get; }
		
		    private Valid(Definit.Validation.Example.Email value)
		    {
		        Value = value;
		    }
		
		    public static Either<Valid, ValidationError> Create(Definit.Validation.Example.Email value, string? propertyName = null)
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