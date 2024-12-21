#nullable enable

using Definit.Results;
using Definit.Validation;
using System.Text.Json;

namespace Definit.Validation;

partial class Example
{
	partial struct Email: Definit.Validation.IIsValid<string>, Definit.Validation.IIsValid<Email, Email.Valid>
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
		
		public static Definit.Validation.Example.Email Deserialize(string json) => new Definit.Validation.Example.Email(JsonSerializer.Deserialize<string>(json)!);  
		public static string Serialize(Definit.Validation.Example.Email value) => JsonSerializer.Serialize(value.Value); 
		
		public static U<Valid, ValidationError> Create(Definit.Validation.Example.Email value, string? propertyName = null) => Valid.Create(value, propertyName); 
		
		public readonly struct Valid : Definit.Validation.IValid<Definit.Validation.Example.Email>, Definit.Validation.IValidBase<Definit.Validation.Example.Email.Valid>
		{
		    private const string _NAME = "Email";
		
		    Definit.Validation.Example.Email Definit.Validation.IValid<Definit.Validation.Example.Email>.Value => this.Parent;
		
		    public string Value => Parent.Value;
		
		    public Definit.Validation.Example.Email Parent { get; }
		
		    private Valid(Definit.Validation.Example.Email parent)
		    {
		        this.Parent = parent;
		    }
		
		    public static U<Valid, ValidationError> Deserialize(string json) => Create(Definit.Validation.Example.Email.Deserialize(json));
		    public static string Serialize(Valid valid) => Definit.Validation.Example.Email.Serialize(valid.Parent);
		
		    public static U<Valid, ValidationError> Create(Definit.Validation.Example.Email value, string? propertyName = null)
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