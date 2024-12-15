#nullable enable

using System.Collections.Immutable;
using Definit.Results;
using Definit.Validation;

namespace Definit.Validation;

partial class Example
{
	partial record UserData: Definit.Validation.IIsValid
	{
		
		private const string _NAME = "UserData";
		
		public U<ValidationError> Validate(string? propertyName = null)
		{
		    return IsValid(propertyName ?? _NAME).ToResult();
		}
		
		public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this, propertyName);
		
		public readonly struct Valid : Definit.Validation.IValid<Definit.Validation.Example.UserData>
		{
		    public Definit.Validation.Example.UserData Value { get; } 
		
		    public Definit.Validation.Example.Email.Valid Email { get; }
			public Definit.Validation.Example.Address.Valid Address { get; }
		
		    private Valid(Definit.Validation.Example.UserData Value, Definit.Validation.Example.Email.Valid Email, Definit.Validation.Example.Address.Valid Address)
		    {
		        this.Value = Value;
		        this.Email = Email;
				this.Address = Address;
		    }
		
		    public static U<Valid, ValidationError> Create(Definit.Validation.Example.UserData value, string? propertyName = null)
		    {
		        var name = propertyName is null ? _NAME : propertyName; 
		
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
		
		        return new Valid(value, valid_Email!.Value, valid_Address!.Value);
		    }
		
		    public static implicit operator Definit.Validation.Example.UserData(Valid value) => value.Value;
		}
	}
}