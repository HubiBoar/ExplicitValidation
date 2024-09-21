using Definit.Results;
using Definit.Validation;

namespace Definit.Validation;

partial class Example 
{
	partial record UserData : Definit.Validation.IIsValid
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
		
		    public static Result<Valid> Create(Definit.Validation.Example.UserData value)
		    {
		        List<(string Error, string PropertyName)> errors = [];
		        
		        if(value.Email.IsValid().Is(out Error error_Email).Else(out var valid_Email))
		        {
		            errors.Add((error_Email.Message, "Email"));
		        }
		
		        if(value.Address.IsValid().Is(out Error error_Address).Else(out var valid_Address))
		        {
		            errors.Add((error_Address.Message, "Address"));
		        }
		
		        if(errors.Count > 0)
		        {
		            return new Error(string.Join(" :: ", errors.Select(x => $"{x.PropertyName} => {x.Error}")));
		        }
		
		        return new Valid(value, valid_Email, valid_Address);
		    }
		
		    public static implicit operator Definit.Validation.Example.UserData(Valid value) => value.Value;
		}
	}
}