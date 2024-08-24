namespace Definit.Configuration;

public abstract record FeatureToggle
(
    string FeatureName
)
: IConfig<FeatureToggle>
{
    public Func<Task<bool>> Get { get; init; } = null!; 
    
    public static T Create<T>(IServiceProvider provider, IConfiguration configuration) 
        where T : FeatureToggle, new()
    {
        var config = new T();

        return new T()
        {
            Get = () => provider
                .GetRequiredService<IFeatureManager>()
                .IsEnabledAsync(config.FeatureName)
        };
    }

    public static void Register<T>(IServiceCollection services, IConfiguration configuration)
        where T : FeatureToggle, new()
    {
        services.AddFeatureManagement();
        services.AddSingleton<T>(provider => Create<T>(provider, configuration));
    }
}
