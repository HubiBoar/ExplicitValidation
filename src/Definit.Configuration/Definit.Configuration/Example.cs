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

    [Config<int>]
    public partial record TestIntValue
    {
        public static string SectionName => "Value";

        public static void Rule(Rule<int> rule) => rule.NotNull();
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
            var (x, error) = value.IsValid(); 
            
            if (x is not null)
            {
            }
        }

        private void Logic(TestValue.Valid valid)
        {
            var v = valid.Value;
        }
    }
}
