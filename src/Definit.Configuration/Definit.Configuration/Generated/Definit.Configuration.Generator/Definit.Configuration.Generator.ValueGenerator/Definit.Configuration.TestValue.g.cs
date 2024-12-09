#nullable enable

using Definit.Results;
using Definit.Configuration;
using Definit.Validation;

namespace Definit.Configuration;

sealed partial record TestValue: Definit.Configuration.IConfig<string, TestValue.Valid>
{
	private readonly static Rule<string> _rule;
	
	static TestValue()
	{
	    _rule = new();
	    Rule(_rule);
	}
	
	public Func<U<Valid, ValidationError>> Value { get; init; }
	
	public TestValue(Func<U<Valid, ValidationError>> value)
	{
	    Value = value;
	}
	
	public TestValue(IConfiguration configuration)
	{
	    Value = () => Valid.Create(configuration);
	}
	
	public U<Valid, ValidationError> IsValid(string? propertyName = null) => Value();
	
	public R<ValidationError> Validate(string? propertyName = null) => Value().ToResult(); 
	
	public static R<ValidationError> Register(IServiceCollection services, IConfiguration configuration)
	{
	    services.AddSingleton<Definit.Configuration.TestValue>(_ => new Definit.Configuration.TestValue(configuration));
	
	    return new Definit.Configuration.TestValue(configuration).Validate();
	}
	
	public readonly struct Valid : Definit.Validation.IValid<string>
	{
	    public string Value { get; }
	
	    private Valid(string value)
	    {
	        Value = value;
	    }
	
	    public static U<Valid, ValidationError> Create(IConfiguration configuration)
	    {
	        var (value, error) = ConfigHelper.GetValue<string>(configuration, Definit.Configuration.TestValue.SectionName);  
	        if (error is not null)
	        {
	            return error.Value;
	        }
	
	        (var _, error) = _rule.Validate((string)value!, SectionName);
	        if (error is not null)
	        {
	            return error.Value;
	        }
	
	        return new Valid((string)value!);
	    }
	}
}