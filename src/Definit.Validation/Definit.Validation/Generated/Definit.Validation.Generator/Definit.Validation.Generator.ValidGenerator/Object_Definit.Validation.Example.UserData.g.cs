#nullable enable

using System.Collections.Immutable;
using Definit.Results;
using Definit.Validation;
using System.Text.Json;

namespace Definit.Validation;

partial class Example
{
	partial record UserData : Definit.Validation.IIsValid<Definit.Validation.Example.UserData, Definit.Validation.Example.UserData.Valid>
	{
		private const string _NAME = "UserData";
		
		
		// Validate
		
		public U<ValidationError> Validate(string? propertyName = null) => IsValid(propertyName ?? _NAME).ToResult();
		
		public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this, propertyName);
		
		
		// Factory
		
		public static U<Valid, ValidationError> Create(Definit.Validation.Example.UserData value, string? propertyName = null) => Valid.Create(value, propertyName); 
		
		
		// JSON
		
		public static Definit.Validation.Example.UserData Deserialize(string json) => JsonSerializer.Deserialize<Definit.Validation.Example.UserData>(json)!;  
		
		public static string Serialize(Definit.Validation.Example.UserData value) => JsonSerializer.Serialize(value); 
		
		
		// Valid
		
		public readonly struct Valid : Definit.Validation.IValid<Definit.Validation.Example.UserData>, Definit.Validation.IValidBase<Definit.Validation.Example.UserData.Valid> 
		{
		    public Definit.Validation.Example.UserData _Parent { get; } 
		
		    Definit.Validation.Example.UserData Definit.Validation.IValid<Definit.Validation.Example.UserData>.Value => this._Parent;
		
		    public string Name { get; }
			public Definit.Validation.Example.Email.Valid Email { get; }
			public Definit.Validation.Example.Address.Valid Address { get; }
		
		    private Valid(Definit.Validation.Example.UserData _parent, string Name, Definit.Validation.Example.Email.Valid Email, Definit.Validation.Example.Address.Valid Address)
		    {
		        this._Parent = _parent;
		        this.Name = Name;
				this.Email = Email;
				this.Address = Address;
		    }
		
		    public static implicit operator Definit.Validation.Example.UserData(Valid value) => value._Parent;
		
		    // Factory
		
		    public static U<Valid, ValidationError> Create(Definit.Validation.Example.UserData value, string? propertyName = null)
		    {
		        var name = propertyName is null ? Definit.Validation.Example.UserData._NAME : propertyName; 
		
		        List<ValidationError> errors = [];
		
		        var (valid_Email, error_Email) = value.Email.IsValid("Email");
		
		        if(error_Email is not null)
		        {
		            errors.Add(error_Email.Value);
		        }
		
		        var (valid_Address, error_Address) = value.Address.IsValid("Address");
		
		        if(error_Address is not null)
		        {
		            errors.Add(error_Address.Value);
		        }
		 
		        if(errors.Count > 0)
		        {
		            return new ValidationError(name, errors.ToImmutableArray());
		        }
		
		        return new Valid(value, value.Name, valid_Email!.Value, valid_Address!.Value);
		    }
		
		
		    // JSON
		    
		    public static U<Valid, ValidationError> Deserialize(string json) => Create(Definit.Validation.Example.UserData.Deserialize(json));
		
		    public static string Serialize(Valid valid) => Definit.Validation.Example.UserData.Serialize(valid._Parent);
		}
	}
}