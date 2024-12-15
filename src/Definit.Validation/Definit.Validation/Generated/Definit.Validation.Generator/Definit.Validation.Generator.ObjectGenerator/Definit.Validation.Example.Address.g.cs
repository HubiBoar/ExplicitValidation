#nullable enable

using System.Collections.Immutable;
using Definit.Results;
using Definit.Validation;

namespace Definit.Validation;

partial class Example
{
	partial record Address: Definit.Validation.IIsValid<Definit.Validation.Example.Address, Definit.Validation.Example.Address.Valid>
	{
		
		private const string _NAME = "Address";
		
		public U<ValidationError> Validate(string? propertyName = null)
		{
		    return IsValid(propertyName ?? _NAME).ToResult();
		}
		
		public U<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this, propertyName);
		
		public static U<Valid, ValidationError> Create(Definit.Validation.Example.Address value, string? propertyName = null) => Valid.Create(value, propertyName); 
		
		public readonly struct Valid : Definit.Validation.IValid<Definit.Validation.Example.Address>
		{
		    public Definit.Validation.Example.Address Value { get; } 
		
		    public Definit.Validation.Example.Email.Valid EmailProp { get; }
		
		    private Valid(Definit.Validation.Example.Address Value, Definit.Validation.Example.Email.Valid EmailProp)
		    {
		        this.Value = Value;
		        this.EmailProp = EmailProp;
		    }
		
		    public static U<Valid, ValidationError> Create(Definit.Validation.Example.Address value, string? propertyName = null)
		    {
		        var name = propertyName is null ? _NAME : propertyName; 
		
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
		
		        return new Valid(value, valid_EmailProp!.Value);
		    }
		
		    public static implicit operator Definit.Validation.Example.Address(Valid value) => value.Value;
		}
	}
}