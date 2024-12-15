#nullable enable

using Definit.Results;
using Definit.Configuration;
using Definit.Validation;

namespace Definit.Configuration;

partial class Example
{
	sealed partial record TestIntValue: Definit.Configuration.IConfig<int, TestIntValue.Valid>
	{
		private readonly static Rule<int> _rule;
		
		static TestIntValue()
		{
		    _rule = new();
		    Rule(_rule);
		}
		
		private Func<U<Valid, ValidationError>> Value { get; init; }
		
		public TestIntValue(Func<U<Valid, ValidationError>> value)
		{
		    Value = value;
		}
		
		public TestIntValue(IConfiguration configuration)
		{
		    Value = () => Valid.Create(configuration);
		}
		
		public U<Valid, ValidationError> IsValid(string? propertyName = null) => Value();
		
		public U<ValidationError> Validate(string? propertyName = null) => Value().ToResult(); 
		
		public static U<ValidationError> Register(IServiceCollection services, IConfiguration configuration)
		{
		    services.AddSingleton<Definit.Configuration.Example.TestIntValue>(_ => new Definit.Configuration.Example.TestIntValue(configuration));
		
		    return new Definit.Configuration.Example.TestIntValue(configuration).Validate();
		}
		
		public readonly struct Valid : Definit.Validation.IValid<int>
		{
		    public int Value { get; }
		
		    private Valid(int value)
		    {
		        Value = value;
		    }
		
		    public static U<Valid, ValidationError> Create(IConfiguration configuration)
		    {
		        var (value, error) = ConfigHelper.GetValue<int>(configuration, Definit.Configuration.Example.TestIntValue.SectionName);  
		        if (error is not null)
		        {
		            return error.Value;
		        }
		
		        (var _, error) = _rule.Validate((int)value!, SectionName);
		        if (error is not null)
		        {
		            return error.Value;
		        }
		
		        return new Valid((int)value!);
		    }
		}
	}
}