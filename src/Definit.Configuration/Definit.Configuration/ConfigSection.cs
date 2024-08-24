using Definit.Results;

namespace Definit.Configuration;

public abstract record Config<TSection>
(
    string SectionName
)
: IConfig<Config<TSection>>
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
                return new Holder(value).IsValid();
            }
        };
    }

    public static void Register<T>(IServiceCollection services, IConfiguration configuration)
        where T : Config<TSection>, new()
    {
        services.AddSingleton<T>(_ => Create<T>(configuration));
    }
}

