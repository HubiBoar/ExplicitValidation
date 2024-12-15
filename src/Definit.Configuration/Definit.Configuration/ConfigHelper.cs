using Definit.Results;

namespace Definit.Configuration;

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
