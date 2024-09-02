using Definit.Results;

namespace Examples
{
	partial struct Email 
	{
		public string Value { get; }
		
		public Email(string value)
		{
		    Value = value;
		}
		
		public static implicit operator Email(string value) => new (value);
		
		public static implicit operator string(Email value) => value.Value;
		
		public Result Validate() => NewApproach.IIsValid<string>.DefaultValidate(this);
	}
}