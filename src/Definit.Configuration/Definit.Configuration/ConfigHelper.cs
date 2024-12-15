using Definit.Results;

namespace Definit.Configuration;

public interface IConfig : IIsValid
{
    abstract static string SectionName { get; }

    abstract static U<ValidationError> Register(IServiceCollection services, IConfiguration configuration);
}

public interface IConfig<TValue, TConfig, TValid> 
    where TValue : notnull
    where TConfig : IConfig<TValue, TValid>
    where TValid : IValid<TValue>
{
    abstract static string SectionName { get; }

    abstract static U<ValidationError> Register(IServiceCollection services, IConfiguration configuration);

    abstract static void Rule(Rule<TValue> rule);
}

public interface IConfig<TValue, TValid> : IConfig, IIsValid<TValue, TValid>
    where TValue : notnull
    where TValid : IValid<TValue>
{
}

public sealed record NotFound(string Property) : IValidationError
{
    private readonly string _message = $"[{Property}] NotFound";

    private readonly ValidationError _error = new (Property, $"[{Property}] NotFound");

    public override string ToString() => _message;

    public ValidationError ToValidationError() => _error;
}

public sealed record Null<T>(string Property) : IValidationError
{
    private static string Type = DefinitType.GetTypeVerboseName<T>();

    private readonly string _message = $"[{Type}::{Property}] Is Null";

    private readonly ValidationError _error = new (Property, $"[{Type}::{Property}] Is Null");

    public override string ToString() => _message;

    public ValidationError ToValidationError() => _error;
}

public static class ConfigHelper
{
    public static U<TValue, ValidationError> GetValue<TValue>(IConfiguration configuration, string sectionName)
        where TValue : notnull
    {
        try
        {
            var section = configuration.GetSection(sectionName);
            if (section.Exists() is false)
            {
                return new ValidationError(sectionName, $"Config Section: Not Found");
            }

            var value = section.Get<TValue>();
            if (value is null)
            {
                return ValidationError.Null<TValue>(sectionName);
            }

            return value;
        }
        catch (Exception exception)
        {
            return ValidationError.Exception(exception);
        }
    }

    public static U<ValidationError> Register<T>(this IServiceCollection services, IConfiguration configuration)
        where T : IConfig
    {
        return T.Register(services, configuration);
    }
}
