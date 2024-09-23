#nullable enable

using System.Collections.Immutable;
using Definit.Results;
using Definit.Validation;

namespace Definit.Validation;

partial class Example
{
	partial record Address: Definit.Validation.IIsValid
	{
		public ValidationError? Validate(string? propertyName = null)
		{
		    if(IsValid(propertyName).IsError(out var error))
		    {
		        return error;
		    }
		
		    return null;
		}
		
		public Either<Valid, ValidationError> IsValid(string? propertyName = null) => Valid.Create(this, propertyName);
		
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
		        var name = propertyName is null ? "Address" : propertyName; 
		
		        Definit.Validation.Example.Email valid_EmailProp = default!;
		
		        List<ValidationError> errors = [];
		
		        var (valid_EmailProp, error_EmailProp) = value.EmailProp.IsValid(EmailProp);
		
		        if(error_EmailProp is not null)
		        {
		            errors.Add(error_EmailProp.GetNotNullValue());
		        }
		 
		        if(errors.Count > 0)
		        {
		            return new ValidationError(name, errors.ToImmutableArray());
		        }
		
		        return new Valid(value, valid_EmailProp.Value!.GetNotNullValue());
		    }
		
		    public static implicit operator Definit.Validation.Example.Address(Valid value) => value.Value;
		}
	}
}