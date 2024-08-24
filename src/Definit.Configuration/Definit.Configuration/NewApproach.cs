using Definit.Results;

namespace Definit.ConfigurationNewApproach;

public interface IConfig<TConf>
{
    public static abstract T Create<T>(IConfiguration configuration)
        where T : TConf, new();
}

public abstract record ConfigValue<TValue, TPrimitive>
(
    string SectionName
)
: IConfig<ConfigValue<TValue, TPrimitive>>
where TPrimitive : Primitive<TValue>
where TValue : notnull
{
    public Func<IsValid<TPrimitive>> GetValue { get; init; } = null!; 

    public static T Create<T>(IConfiguration configuration) 
        where T : ConfigValue<TValue, TPrimitive>, new()
    {
        var config = new T();
        return new T()
        {
            GetValue = () =>
            {
                if(ConfigHelper.GetValue<TValue>(configuration, config.SectionName)
                    .Is(out Error error)
                    .Else(out var value))
                {
                    return error;
                }
                return Primitive<TValue>.Create<TPrimitive>(value);
            }
        };
    }
}

public static class ConfigHelper
{
    public static Result<TValue> GetValue<TValue>(IConfiguration configuration, string sectionName)
        where TValue : notnull
    {
        try
        {
            var section = configuration.GetSection(sectionName);
            if(section.Exists() == false)
            {
                return new Error($"Section: [{sectionName}] of type [{DefinitType.GetTypeVerboseName<TValue>()}] Is Missing");
            }

            var value = section.Get<TValue>();
            if (value is null)
            {
                return new Error($"Section: [{sectionName}] of type [{DefinitType.GetTypeVerboseName<TValue>()}] Is Null");
            }

            return value;
        }
        catch(Exception exception)
        {
            return exception;
        }
    }
}
