#nullable enable

using System.Collections.Immutable;
using Definit.Results;
using Definit.Validation;
using System.Text.Json;

namespace Definit.Validation;

partial class Example
{
	partial record Address : Definit.Validation.IIsValid<Definit.Validation.Example.Address, Definit.Validation.Example.Address.Valid>
	{
		private const string _NAME = "Address";
		
		
		// Validate
		
		public U<ValidationError> Validate(string? propertyName = null) => IsValid(propertyName ?? _NAME).ToResult();
		
		public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this, propertyName);
		
		
		// Factory
		
		public static U<Valid, ValidationError> Create(Definit.Validation.Example.Address value, string? propertyName = null) => Valid.Create(value, propertyName); 
		
		
		// JSON
		
		public static Definit.Validation.Example.Address Deserialize(string json) => JsonSerializer.Deserialize<Definit.Validation.Example.Address>(json)!;  
		
		public static string Serialize(Definit.Validation.Example.Address value) => JsonSerializer.Serialize(value); 
		
		
		// Valid
		
		public readonly struct Valid : Definit.Validation.IValid<Definit.Validation.Example.Address>, Definit.Validation.IValidBase<Definit.Validation.Example.Address.Valid> 
		{
		    public Definit.Validation.Example.Address _Parent { get; } 
		
		    Definit.Validation.Example.Address Definit.Validation.IValid<Definit.Validation.Example.Address>.Value => this._Parent;
		
		    public string PostalCode { get; }
			public Definit.Validation.Example.Email.Valid EmailProp { get; }
		
		    private Valid(Definit.Validation.Example.Address _parent, string PostalCode, Definit.Validation.Example.Email.Valid EmailProp)
		    {
		        this._Parent = _parent;
		        this.PostalCode = PostalCode;
				this.EmailProp = EmailProp;
		    }
		
		    public static implicit operator Definit.Validation.Example.Address(Valid value) => value._Parent;
		
		    // Factory
		
		    public static U<Valid, ValidationError> Create(Definit.Validation.Example.Address value, string? propertyName = null)
		    {
		        var name = propertyName is null ? Definit.Validation.Example.Address._NAME : propertyName; 
		
		        List<ValidationError> errors = [];
		
		        var (valid_EmailProp, error_EmailProp) = value.EmailProp.IsValid("EmailProp");
		
		        if(error_EmailProp is not null)
		        {
		            errors.Add(error_EmailProp.Value);
		        }
		 
		        if(errors.Count > 0)
		        {
		            return new ValidationError(name, errors.ToImmutableArray());
		        }
		
		        return new Valid(value, value.PostalCode, valid_EmailProp!.Value);
		    }
		
		
		    // JSON
		    
		    public static U<Valid, ValidationError> Deserialize(string json) => Create(Definit.Validation.Example.Address.Deserialize(json));
		
		    public static string Serialize(Valid valid) => Definit.Validation.Example.Address.Serialize(valid._Parent);
		}
	}
}