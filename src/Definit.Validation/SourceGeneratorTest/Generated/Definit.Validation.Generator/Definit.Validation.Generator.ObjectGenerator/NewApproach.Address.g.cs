using Definit.Results;

namespace NewApproach
{
	partial record Address 
	{
		private (string PropertyName, Result Result)[] ValidateProperties() => 
		[
		    // NewApproach.Address.Address(string, Examples.Email) :: NewApproach.Address.EqualityContract.get :: NewApproach.Address.EqualityContract :: NewApproach.Address.<PostalCode>k__BackingField :: NewApproach.Address.PostalCode.get :: NewApproach.Address.PostalCode.init :: NewApproach.Address.PostalCode :: NewApproach.Address.<Email>k__BackingField :: NewApproach.Address.Email.get :: NewApproach.Address.Email.init :: NewApproach.Address.Email :: NewApproach.Address.ToString() :: NewApproach.Address.PrintMembers(System.Text.StringBuilder) :: NewApproach.Address.operator !=(NewApproach.Address?, NewApproach.Address?) :: NewApproach.Address.operator ==(NewApproach.Address?, NewApproach.Address?) :: NewApproach.Address.GetHashCode() :: NewApproach.Address.Equals(object?) :: NewApproach.Address.Equals(NewApproach.Address?) :: NewApproach.Address.<Clone>$() :: NewApproach.Address.Address(NewApproach.Address) :: NewApproach.Address.Deconstruct(out string, out Examples.Email) 
		    // ("Email", Email.Validate()),
		    // ("Address", Address.Validate()),
		];
		
		public Result Validate()
		{
		    var errors =
		        ValidateProperties()
		        .Where(x => x.Result.Is(out Error _))
		        .Select(x => 
		        {
		            x.Result.Is(out Error error);
		            return (PropertyName: x.PropertyName, Error: error);
		        })
		        .ToArray();
		
		    if(errors.Length > 0)
		    {
		        return new Error(string.Join(", ", errors.Select(x => $"{x.PropertyName} :: {x.Error.Message}")));
		    }
		
		    return Result.Success;
		}
	}
}

namespace NewApproach
{
	public static class NewApproach_Address
	{
	   // public static Valid<Email> Email(this Valid<UserData> valid)
	   // {
	   //     return new Valid<Email>(valid.Value.Email);
	   // }
	
	   // public static Valid<Address> Address(this Valid<UserData> valid)
	   // {
	   //     return new Valid<Address>(valid.Value.Address);
	   // }
	}
}