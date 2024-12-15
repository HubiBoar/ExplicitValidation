#nullable enable

using Definit.Results;
using Definit.Configuration;
using Definit.Validation;

namespace Definit.Configuration;

partial class Example
{
	sealed partial record TestValue: Definit.Configuration.IConfig<string, TestValue.Config, TestValue.Valid>
	{
		public static U<ValidationError> Register(IServiceCollection services, IConfiguration configuration) => Config.Register(services, configuration);
		
		public sealed class Config : Definit.Configuration.IConfig<string, TestValue.Valid>
		{
		    public static string SectionName => Definit.Configuration.Example.TestValue.SectionName;
		
		    public static void Rule(Rule<string> rule) => Definit.Configuration.Example.TestValue.Rule(rule);
		
		    private Func<U<Valid, ValidationError>> Value { get; init; }
		
		    public Config(Func<U<Valid, ValidationError>> value)
		    {
		        Value = value;
		    }
		
		    public Config(IConfiguration configuration)
		    {
		        Value = () => Valid.Create(configuration);
		    }
		
		    public U<Valid, ValidationError> IsValid(string? propertyName = null) => Value();
		
		    public U<ValidationError> Validate(string? propertyName = null) => Value().ToResult(); 
		
		    public static U<ValidationError> Register(IServiceCollection services, IConfiguration configuration)
		    {
		        services.AddSingleton<Config>(_ => new Config(configuration));
		
		        return new Config(configuration).Validate();
		    }
		}
		
		public readonly struct Valid : Definit.Validation.IValid<string>
		{
		    private readonly static Rule<string> _rule;
		
		    static Valid()
		    {
		        _rule = new();
		        Config.Rule(_rule);
		    }
		
		    public string Value { get; }
		
		    private Valid(string value)
		    {
		        Value = value;
		    }
		
		    public static U<Valid, ValidationError> Create(IConfiguration configuration)
		    {
		        var (value, error) = ConfigHelper.GetValue<string>(configuration, Config.SectionName);  
		        if (error is not null)
		        {
		            return error.Value;
		        }
		
		        (var _, error) = _rule.Validate((string)value!, Config.SectionName);
		        if (error is not null)
		        {
		            return error.Value;
		        }
		
		        return new Valid((string)value!);
		    }
		}
	}
}