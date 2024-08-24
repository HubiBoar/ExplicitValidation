using Definit.Results;

namespace Definit.Configuration;

public abstract record Config<TSection>
(
    string SectionName
)
: IConfig<Config<TSection>>
where TSection : notnull
{
    public Func<IsValid<TSection>> Get { get; init; } = null!; 
    
    public static T Create<T>(IServiceProvider _, IConfiguration configuration) 
        where T : Config<TSection>, new()
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
                return new IsValid<TSection>(value, v => IValidate.DefaultValidate(v, $"{typeof(T).Name}:{config.SectionName}"));
            }
        };
    }

    public static void Register<T>(IServiceCollection services, IConfiguration configuration)
        where T : Config<TSection>, new()
    {
        services.AddSingleton<T>(provider => Create<T>(provider, configuration));
    }
}

