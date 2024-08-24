namespace Definit.ConfigurationNewApproach;

public interface IConfig<TConf>
{
    public static abstract T Create<T>(IConfiguration configuration)
        where T : TConf, new();
}

public abstract record ConfigValue<TValue, TValidation>
(
    string ConfigName
)
: IConfig<ConfigValue<TValue, TValidation>>
where TValidation : Primitive<TValue>
{
    public Func<IsValid<TValidation>> GetValue { get; init; } 

    public static T Create<T>(IConfiguration configuration) 
        where T : ConfigValue<TValue, TValidation>, new()
    {
        return new T()
        {
            GetValue = () =>
            {
                var value = configuration.GetSection(config.ConfigName).GetValue<TValue>();
            }
        }
    }
}
