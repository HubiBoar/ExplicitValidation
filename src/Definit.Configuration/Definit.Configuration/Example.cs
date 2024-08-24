namespace Definit.Configuration;

internal static class Example
{
    private sealed record Feature() : FeatureToggle("ExampleFeature");

    private sealed record Value() : Config<string, ConnectionString>("ExampleValue");

    private sealed record Section() : Config<
    (
        ConnectionString ConnectionString,
        string Value
    )>
    ("ExampleSection");

    private static async Task Get(Section section, Value value, Feature feature)
    {
        var sectionValue = section.Get();
        var valueValue   = value.Get();
        var isEnabled = await feature.Get();
    }
   
    private static void Register(IServiceCollection services, IConfiguration configuration)
    {
        services.AddConfig<Section>(configuration);
        services.AddConfig<Value>(configuration);
        services.AddConfig<Feature>(configuration);
    }

    private static async Task Create(IServiceCollection services, IConfiguration configuration)
    {
        var section   = services.GetConfig<Section>(configuration);
        var value     = services.GetConfig<Value>(configuration);
        var isEnabled = await services.GetConfig<Feature>(configuration).Get();
    }
}
