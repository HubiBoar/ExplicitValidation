using Definit.Results;
using Definit.Validation;

namespace Example;

partial record Address : Definit.Validation.IIsValid
{
	public Result Validate() => IsValid();
	
	public Result<Valid> IsValid() => Valid.Create(this);
	
	public readonly struct Valid
	{
	    public Example.Address Value { get; } 
	
	    public Example.Email.Valid EmailProp { get; }
	
	    private Valid(Example.Address Value, Example.Email.Valid EmailProp)
	    {
	        this.Value = Value;
	        this.EmailProp = EmailProp;
	    }
	
	    public static Result<Valid> Create(Example.Address value)
	    {
	        List<(string Error, string PropertyName)> errors = [];
	        
	        if(value.EmailProp.IsValid().Is(out Error error_EmailProp).Else(out var valid_EmailProp))
	        {
	            errors.Add((error_EmailProp.Message, "EmailProp"));
	        }
	
	        if(errors.Count > 0)
	        {
	            return new Error(string.Join(" :: ", errors.Select(x => $"{x.PropertyName} => {x.Error}")));
	        }
	
	        return new Valid(value, valid_EmailProp);
	    }
	
	    public static implicit operator Example.Address(Valid value) => value.Value;
	}
}