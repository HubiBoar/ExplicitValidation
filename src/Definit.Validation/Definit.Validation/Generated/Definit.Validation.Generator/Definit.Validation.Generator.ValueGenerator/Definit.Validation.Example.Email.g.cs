#nullable enable

using Definit.Results;
using Definit.Validation;

namespace Definit.Validation;

partial class Example
{
	partial struct Email: Definit.Validation.IIsValid<string, Email.Valid>
	{
		private readonly static Rule<string> _rule;
		
		private const string _NAME = "Email";
		
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
		
		public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this.Value, propertyName);
		
		public U<ValidationError> Validate(string? propertyName = null) => _rule.Validate(this.Value, propertyName ?? _NAME); 
		
		public readonly struct Valid : Definit.Validation.IValid<string>
		{
		    private const string _NAME = "Email";
		
		    public string Value { get; }
		
		    private Valid(string value)
		    {
		        Value = value;
		    }
		
		    public static U<Valid, ValidationError> Create(Definit.Validation.Example.Email value, string? propertyName = null)
		    {
		        var (_, error) = value.Validate(propertyName ?? _NAME);
		        if(error is not null)
		        {
		            return error.Value;
		        }
		
		        return new Valid(value.Value);
		    }
		}
	}
}