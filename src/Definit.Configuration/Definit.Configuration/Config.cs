using Definit.Results;

namespace Definit.Configuration;

public abstract record Config<TValue>(string SectionName)
    where TValue : IValidBase<TValue>
{
    public Func<U<TValue, ValidationError>> Get { get; init; } = null!;

    public static void Register<TSelf>(IServiceCollection services, IConfiguration configuration)
        where TSelf: Config<TValue>, new()
    {
        services.AddSingleton<TSelf>(_ => Create<TSelf>(configuration)); 
    }

    private static TSelf Create<TSelf>(IConfiguration configuration)
        where TSelf: Config<TValue>, new()
    {
        var sectionName = new TSelf().SectionName;
        
        return new TSelf()
        {
            Get = () => GetValue(configuration, sectionName)
        };
    }

    private static U<TValue, ValidationError> GetValue(IConfiguration configuration, string sectionName)
    {
        var section = configuration.GetSection(sectionName);
        if (section.Exists() is false)
        {
            return new ValidationError(sectionName, $"Config Section: Not Found");
        }

        if (section.Value is null)
        {
            return ValidationError.Null<TValue>(sectionName);
        }

        return TValue.Deserialize(section.Value!);
    }
}
