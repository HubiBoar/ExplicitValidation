using Definit.Results;

namespace Definit.Configuration;

internal static partial class Example
{
    public sealed class TestConfig : ISectionName
    {
        public static string SectionName => "TestConfig";
    }

    [IsValid<string>]
    public partial struct TestValue
    {
        public static void Rule(Rule<string> rule) => rule.NotNull();
    }

    [IsValid]
    public partial record TestObject
    (
        string Name,
        TestValue TestValue
    );

    private class Test
    {
        private readonly Config<TestValue, TestConfig> value;

        public Test(Config<TestValue, TestConfig> value)
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

        private void Logic(TestValue.Valid valid)
        {
            var v = valid.Value;
        }
    }
}
