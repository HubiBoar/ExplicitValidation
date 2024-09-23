#nullable enable

using System.Collections.Immutable;
using Definit.Results;
using Definit.Validation;

namespace Definit.Validation;

partial class Example
{
	partial record UserData: Definit.Validation.IIsValid
	{
		public Result Validate() => IsValid();
		
		public Result<Valid> IsValid() => Valid.Create(this);
		
		public readonly struct Valid
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
		
		    public static Either<Valid, ValidationError> Create(Definit.Validation.Example.UserData value, string? propertyName = null)
		    {
		        var name = propertyName is null ? "Definit.Validation.Example.UserData" : propertyName; 
		
		Definit.Validation.Example.Email valid_Email = default!;, Definit.Validation.Example.Address valid_Address = default!;
		
		    (valid_Email, var error_Email) = value.Email.IsValid(Email);
		
		    if(error_Email is not null)
		    {
		            (valid_Address, var error_Address) = value.Address.IsValid(Address);
			
			    if(error_Address is not null)
			    {
			        return new ValidationError(Definit.Validation.Example.UserData, [Email, Address]);
			    }return new ValidationError(Definit.Validation.Example.UserData, [Email]);
		    }
		
		        return new Valid(value, valid_Email.Value!, valid_Address.Value!);
		    }
		
		    public static implicit operator Definit.Validation.Example.UserData(Valid value) => value.Value;
		}
	}
}