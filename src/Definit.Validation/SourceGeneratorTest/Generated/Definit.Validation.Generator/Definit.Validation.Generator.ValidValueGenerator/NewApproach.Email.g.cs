#nullable enable

using Definit.Results;

namespace NewApproach
{
	sealed partial record Email 
	{
		public Result<Valid> IsValid => _isValid ??= Valid.IsValid(this);
		private Result<Valid>? _isValid = null;
		
		public static implicit operator Email(string value) => new Email
		{
		    Value = value,
		};
		
		public static implicit operator string(Email value) => value.Value;
		
		public sealed record Valid
		{
			public string Value => Holder.Value;
			private Email Holder { get; }
			
			private Valid(Email holder)
			{
			    Holder = holder;
			}
			
			public static implicit operator Email(Valid value) => value.Holder;
			
			public static Result<Valid> IsValid(Email value)
			{
			    if(value.Validate().Is(out Error error))
			    {
			        return error;
			    }
			    return new Valid(value);
			}
		}
	}
}