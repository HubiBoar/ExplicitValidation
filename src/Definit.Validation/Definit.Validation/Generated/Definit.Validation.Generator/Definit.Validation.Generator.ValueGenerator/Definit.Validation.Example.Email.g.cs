using Definit.Results;
using Definit.Validation;

namespace Definit.Validation;

partial class Example 
{
	readonly partial struct Email : Definit.Validation.IIsValid<string>
	{
		private readonly static Rule<string> _rule;
		
		static Email()
		{
		    _rule = new();
		    Rule(_rule);
		}
		
		public string Value { get; }
		
		public Email(string value)
		{
		    Value = value;
		}
		
		public static implicit operator Definit.Validation.Example.Email(string value) => new (value);
		
		public static implicit operator string(Definit.Validation.Example.Email value) => value.Value;
		
		public Result Validate() => _rule.Validate(Value);
		
		public Result<Valid> IsValid() => Valid.Create(this);
		
		public readonly struct Valid
		{
		    public Definit.Validation.Example.Email Value { get; }
		
		    private Valid(Definit.Validation.Example.Email value)
		    {
		        Value = value;
		    }
		
		    public static Result<Valid> Create(Definit.Validation.Example.Email value)
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