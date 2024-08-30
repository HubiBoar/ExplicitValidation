#nullable enable

using Definit.Results;

namespace Examples;

partial class Parent1 
{
	sealed partial record Value1
	{
		public Result<Valid> IsValid => _isValid ??= Valid.IsValid(this);
		
		private Result<Valid>? _isValid = null;
		
		public static implicit operator Value1(string value) => new Value1
		{
		    Value = value,
		};
		
		public static implicit operator string(Value1 value) => value.Value;
		
		public sealed record Valid
		{
			public string Value => Holder.Value;
			
			private Value1 Holder { get; }
			
			private Valid(Value1 holder)
			{
			    Holder = holder;
			}
			
			public static implicit operator Value1(Valid value) => value.Holder;
			
			public static Result<Valid> IsValid(Value1 value)
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