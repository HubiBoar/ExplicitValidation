#nullable enable

using System.Collections.Immutable;
using Definit.Results;
using Definit.Validation;

namespace Definit.Validation;

partial class Example
{
	partial record Address: Definit.Validation.IIsValid
	{
		public Result Validate() => IsValid();
		
		public Result<Valid> IsValid() => Valid.Create(this);
		
		public readonly struct Valid
		{
		    public Definit.Validation.Example.Address Value { get; } 
		
		    public Definit.Validation.Example.Email.Valid EmailProp { get; }
		
		    private Valid(Definit.Validation.Example.Address Value, Definit.Validation.Example.Email.Valid EmailProp)
		    {
		        this.Value = Value;
		        this.EmailProp = EmailProp;
		    }
		
		    public static Either<Valid, ValidationError> Create(Definit.Validation.Example.Address value, string? propertyName = null)
		    {
		        var name = propertyName is null ? "Definit.Validation.Example.Address" : propertyName; 
		
		Definit.Validation.Example.Email valid_EmailProp = default!;
		
		    (valid_EmailProp, var error_EmailProp) = value.EmailProp.IsValid(EmailProp);
		
		    if(error_EmailProp is not null)
		    {
		        return new ValidationError(Definit.Validation.Example.Address, [EmailProp]);
		    }
		
		        return new Valid(value, valid_EmailProp.Value!);
		    }
		
		    public static implicit operator Definit.Validation.Example.Address(Valid value) => value.Value;
		}
	}
}