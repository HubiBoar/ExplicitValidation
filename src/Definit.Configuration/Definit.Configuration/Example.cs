namespace Definit.Configuration;

internal static partial class Example
{
    public sealed record TestConfig() : Config<Email.Valid>("TestConfig");

    [IsValid]
    public partial struct Email : IsValid<string>
    {
        public static void Rule(Rule<string> rule) => rule.NotNull();
    }

    [IsValid]
    public partial record TestObject
    (
        string Name,
        Email TestValue,
        Email TestValue2
    );

    private class Test
    {
        private readonly TestConfig value;

        public Test(TestConfig value)
        {
            this.value = value;
        }

        private void Run()
        {
            value.Get().Switch
            (
                valid => Logic(valid),
                error => {},
                ex => {}
            ); 
        }

        private void Logic(Email.Valid valid)
        {
            var v = valid.Out;
        }

        private void Logic2(TestObject.Valid valid)
        {
            var v = valid.TestValue;
        }
    }

    public static void Register(IServiceCollection services, IConfiguration configuration)
    {
        TestConfig.Register<TestConfig>(services, configuration);
    }
}
