using Definit.Results;

namespace NewApproach
{
	partial record UserData 
	{
		public Result Validate() => IsValid();
		
		public Result<Valid> IsValid() => Valid.Create(this);
		
		public readonly struct Valid
		{
		    public NewApproach.UserData Value { get; } 
		
		    public NewApproach.Email.Valid Email { get; }
			public NewApproach.Address.Valid Address { get; }
		
		    private Valid(NewApproach.UserData Value, NewApproach.Email.Valid Email, NewApproach.Address.Valid Address)
		    {
		        this.Value = Value;
		        this.Email = Email;
				this.Address = Address;
		    }
		
		    public static Result<Valid> Create(NewApproach.UserData value)
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
		
		    public static implicit operator NewApproach.UserData(Valid value) => value.Value;
		}
	}
}