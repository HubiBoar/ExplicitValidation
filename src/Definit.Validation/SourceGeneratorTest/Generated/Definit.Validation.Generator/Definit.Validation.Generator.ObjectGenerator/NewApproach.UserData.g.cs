using Definit.Results;

namespace NewApproach
{
	partial record UserData 
	{
		private (string PropertyName, Result Result)[] ValidateProperties() => 
		[
		    ("Email", Email.Validate()),
			("Address", Address.Validate()),
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
	    public static Valid<Examples.Email> Email(this Valid<UserData> valid) => new (valid.Value.Email);
	
	    public static Valid<NewApproach.Address> Address(this Valid<UserData> valid) => new (valid.Value.Address);
	}
}