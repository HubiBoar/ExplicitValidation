#nullable enable

using Definit.Results;
using Definit.Configuration;
using Definit.Validation;

namespace Definit.Configuration;

partial class Example
{
	sealed partial record TestIntValue: Definit.Configuration.IConfig<int, TestIntValue.Config, TestIntValue.Valid>
	{
		public static U<ValidationError> Register(IServiceCollection services, IConfiguration configuration) => Config.Register(services, configuration);
		
		public sealed class Config : Definit.Configuration.IConfig<int, TestIntValue.Valid>
		{
		    public static string SectionName => Definit.Configuration.Example.TestIntValue.SectionName;
		
		    public static void Rule(Rule<int> rule) => Definit.Configuration.Example.TestIntValue.Rule(rule);
		
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
		
		public readonly struct Valid : Definit.Validation.IValid<int>
		{
		    private readonly static Rule<int> _rule;
		
		    static Valid()
		    {
		        _rule = new();
		        Config.Rule(_rule);
		    }
		
		    public int Value { get; }
		
		    private Valid(int value)
		    {
		        Value = value;
		    }
		
		    public static U<Valid, ValidationError> Create(IConfiguration configuration)
		    {
		        var (value, error) = ConfigHelper.GetValue<int>(configuration, Config.SectionName);  
		        if (error is not null)
		        {
		            return error.Value;
		        }
		
		        (var _, error) = _rule.Validate((int)value!, Config.SectionName);
		        if (error is not null)
		        {
		            return error.Value;
		        }
		
		        return new Valid((int)value!);
		    }
		}
	}
}