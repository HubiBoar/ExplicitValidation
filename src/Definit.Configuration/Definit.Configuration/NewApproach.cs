using System.Reflection;
using Definit.Results;

namespace Definit.ConfigurationNewApproach;

public interface IConfig
{
}

public interface IConfig<TConfig> : IConfig
{
    public static abstract T Create<T>(IConfiguration configuration)
        where T : TConfig, new();

    public static abstract void Register<T>(IServiceCollection services, IConfiguration configuration)
        where T : TConfig, new();
}

public sealed record ConfigValueExample() : ConfigValue<string, ConnectionString>("ExampleValue");

public sealed record ConfigSectionExample() : ConfigSection<
(
    ConnectionString ConnectionString,
    string Value
)>
("ExampleSection");

public abstract record ConfigSection<TSection>
(
    string SectionName
)
: IConfig<ConfigSection<TSection>>
where TSection : notnull
{
    public Func<IsValid<Holder>> Get { get; init; } = null!; 
    
    public sealed record Holder(TSection Section)
        : IValidate
    {
        Result IValidate.Validate(string? propertyName)
        {
            return IValidate.DefaultValidate(Section, propertyName);
        }
    }

    public static T Create<T>(IConfiguration configuration) 
        where T : ConfigSection<TSection>, new()
    {
        var config = new T();
        return new T()
        {
            Get = () =>
            {
                if(ConfigHelper.GetValue<TSection>(configuration, config.SectionName)
                    .Is(out Error error)
                    .Else(out var value))
                {
                    return error;
                }
                return new Holder(value).IsValid();
            }
        };
    }

    public static void Register<T>(IServiceCollection services, IConfiguration configuration)
        where T : ConfigSection<TSection>, new()
    {
        services.AddSingleton<T>(_ => Create<T>(configuration));
    }
}

public abstract record ConfigValue<TValue, TPrimitive>
(
    string SectionName
)
: IConfig<ConfigValue<TValue, TPrimitive>>
where TPrimitive : Primitive<TValue>
where TValue : notnull
{
    public Func<IsValid<TPrimitive>> Get { get; init; } = null!; 

    public static T Create<T>(IConfiguration configuration) 
        where T : ConfigValue<TValue, TPrimitive>, new()
    {
        var config = new T();
        return new T()
        {
            Get = () =>
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

    public static void Register<T>(IServiceCollection services, IConfiguration configuration)
        where T : ConfigValue<TValue, TPrimitive>, new()
    {
        services.AddSingleton<T>(_ => Create<T>(configuration));
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

    public static void AddConfig<T>(this IServiceCollection services, IConfiguration configuration)
        where T : class, IConfig, new()
    {
        var type = typeof(T);

        var method = type.GetMethod("Register", BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)!;
        var genericMethod = method.MakeGenericMethod(typeof(T));

        genericMethod.Invoke(null, [services]);
    }
}
