using Definit.Results;

namespace NewApproach
{
	partial struct Email 
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
		
		public static implicit operator NewApproach.Email(string value) => new (value);
		
		public static implicit operator string(NewApproach.Email value) => value.Value;
		
		public Result Validate() => _rule.Validate(Value);
		
		public Result<Valid> IsValid() => Valid.Create(this);
		
		public readonly struct Valid
		{
		    public NewApproach.Email Value { get; }
		
		    private Valid(NewApproach.Email Value)
		    {
		        this.Value = Value;
		    }
		
		    public static Result<Valid> Create(NewApproach.Email Value)
		    {
		        if(Value.Validate().Is(out Error error))
		        {
		            return error;
		        }
		
		        return new Valid(Value);
		    }
		}
	}
}