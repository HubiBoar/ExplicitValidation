namespace Definit.Configuration;

internal static class Example
{
    private sealed class Feature : IFeatureName
    {
        public static string FeatureName => "Test";
    }

    private sealed record Value() : Config<string, ConnectionString>("ExampleValue");

    private sealed record Section() : Config<
    (
        ConnectionString ConnectionString,
        string Value
    )>
    ("ExampleSection");



    private static async Task Get(Section section, Value value, FeatureToggle<Feature>.Get featureGetter)
    {
        var section = section.Get();
        var value = valueGetter();
        var isEnabled = await featureGetter();
    }
   
    private static void Register(IServiceCollection services, IConfiguration configuration)
    {
        services.Register<Section>(configuration);
        Value.Register(services, configuration);
        FeatureToggle<Feature>.Register(services, configuration);
    }

    private static async Task Create(IServiceCollection services, IConfiguration configuration)
    {
        var section = Section.Create(configuration);
        var value = Value.Create(configuration);
        var isEnabled = await FeatureToggle<Feature>.Create(services);
    }
}
