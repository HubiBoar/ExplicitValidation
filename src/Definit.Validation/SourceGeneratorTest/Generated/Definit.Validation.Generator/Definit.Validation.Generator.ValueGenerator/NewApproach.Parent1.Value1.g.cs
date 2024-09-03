using Definit.Results;

namespace NewApproach
{
	partial class Parent1 
	{
		partial struct Value1 
		{
			private readonly static Rule<string> _rule;
			
			static Value1()
			{
			    _rule = new();
			    Rule(_rule);
			}
			
			public string Value { get; }
			
			public Value1(string value)
			{
			    Value = value;
			}
			
			public static implicit operator NewApproach.Parent1.Value1(string value) => new (value);
			
			public static implicit operator string(NewApproach.Parent1.Value1 value) => value.Value;
			
			public Result Validate() => _rule.Validate(Value);
			
			public Result<Valid> IsValid() => Valid.Create(this);
			
			public readonly struct Valid
			{
			    public NewApproach.Parent1.Value1 Value { get; }
			
			    private Valid(NewApproach.Parent1.Value1 Value)
			    {
			        this.Value = Value;
			    }
			
			    public static Result<Valid> Create(NewApproach.Parent1.Value1 Value)
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
}