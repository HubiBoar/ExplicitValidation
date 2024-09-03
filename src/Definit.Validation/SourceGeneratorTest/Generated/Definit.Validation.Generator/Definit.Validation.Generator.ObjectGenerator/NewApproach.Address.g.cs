using Definit.Results;

namespace NewApproach
{
	partial record Address 
	{
		private (string PropertyName, Result Result)[] ValidateProperties() => 
		[
		    ("EmailProp", EmailProp.Validate()),
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
	    public static Valid<Examples.Email> EmailProp(this Valid<Address> valid) => new (valid.Value.EmailProp);
	}
}