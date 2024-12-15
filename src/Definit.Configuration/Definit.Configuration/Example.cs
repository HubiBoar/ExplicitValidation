using Definit.Results;

namespace Definit.Configuration;

internal static partial class Example
{
    [Config<string>]
    public partial record TestValue
    {
        public static string SectionName => "Value";

        public static void Rule(Rule<string> rule) => rule.NotNull();
    }

    [Config]
    public partial record TestObject
    (
        string Name,
        TestValue Value
    )
    {
        public static string SectionName => "Value";
    }

    private class Test
    {
        private readonly TestValue.Config value;

        public Test(TestValue.Config value)
        {
            this.value = value;
        }

        private void Run()
        {
            value.IsValid().Switch
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
