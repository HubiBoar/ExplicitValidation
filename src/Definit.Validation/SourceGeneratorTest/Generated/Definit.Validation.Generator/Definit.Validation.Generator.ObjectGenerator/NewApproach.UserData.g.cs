using Definit.Results;

namespace NewApproach
{
	partial record UserData 
	{
		private (string PropertyName, Result Result)[] ValidateProperties() => 
		[
		    // NewApproach.UserData.UserData(string, Examples.Email, NewApproach.Address) :: NewApproach.UserData.EqualityContract.get :: NewApproach.UserData.EqualityContract :: NewApproach.UserData.<Name>k__BackingField :: NewApproach.UserData.Name.get :: NewApproach.UserData.Name.init :: NewApproach.UserData.Name :: NewApproach.UserData.<Email>k__BackingField :: NewApproach.UserData.Email.get :: NewApproach.UserData.Email.init :: NewApproach.UserData.Email :: NewApproach.UserData.<Address>k__BackingField :: NewApproach.UserData.Address.get :: NewApproach.UserData.Address.init :: NewApproach.UserData.Address :: NewApproach.UserData.ToString() :: NewApproach.UserData.PrintMembers(System.Text.StringBuilder) :: NewApproach.UserData.operator !=(NewApproach.UserData?, NewApproach.UserData?) :: NewApproach.UserData.operator ==(NewApproach.UserData?, NewApproach.UserData?) :: NewApproach.UserData.GetHashCode() :: NewApproach.UserData.Equals(object?) :: NewApproach.UserData.Equals(NewApproach.UserData?) :: NewApproach.UserData.<Clone>$() :: NewApproach.UserData.UserData(NewApproach.UserData) :: NewApproach.UserData.Deconstruct(out string, out Examples.Email, out NewApproach.Address) 
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
	public static class NewApproach_UserData
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