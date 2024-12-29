#nullable enable

using System.Text.Json.Serialization;
using Definit.Results;
using Definit.Validation;
using System.Text.Json;

namespace Definit.Configuration;

partial class Example
{
	[JsonConverter(typeof(ValidJsonConverter<Email>))]
	partial struct Email : Definit.Validation.IIsValid<string>, Definit.Validation.IIsValid<Email, Email.Valid>
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
		
		public static implicit operator Definit.Configuration.Example.Email(string value) => new (value);
		
		public static implicit operator string(Definit.Configuration.Example.Email value) => value.Value;
		
		
		// Validate
		
		public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this.Value, propertyName);
		
		public U<ValidationError> Validate(string? propertyName = null) => _rule.Validate(this.Value, propertyName ?? _NAME); 
		
		
		// Factory
		
		public static U<Valid, ValidationError> Create(Definit.Configuration.Example.Email value, string? propertyName = null) => Valid.Create(value, propertyName); 
		
		
		// JSON
		
		public static Definit.Configuration.Example.Email Deserialize(string json)
		{
		    var value = (string)Convert.ChangeType(json, typeof(string));
		
		    return new Definit.Configuration.Example.Email(value);
		}
		
		public static string Serialize(Definit.Configuration.Example.Email value) => JsonSerializer.Serialize(value.Value); 
		
		// Valid
		
		public readonly struct Valid : Definit.Validation.IValid<Definit.Configuration.Example.Email>, Definit.Validation.IValidBase<Definit.Configuration.Example.Email.Valid>
		{
		    Definit.Configuration.Example.Email Definit.Validation.IValid<Definit.Configuration.Example.Email>.Value => this._Parent;
		
		    public string Out => _Parent.Value;
		
		    public Definit.Configuration.Example.Email _Parent { get; }
		
		    private Valid(Definit.Configuration.Example.Email parent)
		    {
		        this._Parent = parent;
		    }
		
		    public static implicit operator Definit.Configuration.Example.Email(Valid value) => value.Out;
		
		
		    // Factory
		
		    public static U<Valid, ValidationError> Create(Definit.Configuration.Example.Email value, string? propertyName = null)
		    {
		        var (_, error) = value.Validate(propertyName);
		        if(error is not null)
		        {
		            return error.Value;
		        }
		
		        return new Valid(value);
		    }
		
		
		    // JSON
		    
		    public static U<Valid, ValidationError> Deserialize(string json) => Create(Definit.Configuration.Example.Email.Deserialize(json));
		
		    public static string Serialize(Valid valid) => Definit.Configuration.Example.Email.Serialize(valid._Parent);
		}
	}
}