using Definit.Results;

namespace Definit.Configuration;

public abstract record Config<TValue, TPrimitive>
(
    string SectionName
)
: IConfig<Config<TValue, TPrimitive>>
where TPrimitive : Primitive<TValue>
where TValue : notnull
{
    public Func<IsValid<TPrimitive>> Get { get; init; } = null!; 

    public static T Create<T>(IServiceProvider _, IConfiguration configuration) 
        where T : Config<TValue, TPrimitive>, new()
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
        where T : Config<TValue, TPrimitive>, new()
    {
        services.AddSingleton<T>(provider => Create<T>(provider, configuration));
    }
}

