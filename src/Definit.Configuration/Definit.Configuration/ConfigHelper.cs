using System.Reflection;
using Definit.Results;

namespace Definit.Configuration;

public interface IConfig
{
}

public interface IConfig<TConfig> : IConfig
{
    public static abstract T Create<T>(IServiceProvider provider, IConfiguration configuration)
        where T : TConfig, new();

    public static abstract void Register<T>(IServiceCollection services, IConfiguration configuration)
        where T : TConfig, new();
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

    public static void AddConfig<T>(this IServiceCollection services, IConfiguration configuration)
        where T : class, IConfig, new()
    {
        var type = typeof(T);

        var method = type.GetMethod("Register", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)!;
        var genericMethod = method.MakeGenericMethod(typeof(T));

        genericMethod.Invoke(null, [services]);
    }
}
