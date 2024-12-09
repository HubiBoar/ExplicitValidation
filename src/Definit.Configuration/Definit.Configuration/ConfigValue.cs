namespace Definit.Configuration;

[System.AttributeUsage
(
    System.AttributeTargets.Class,
    AllowMultiple = false
)]
public sealed class ConfigAttribute : Attribute
{
}

[System.AttributeUsage
(
    System.AttributeTargets.Class,
    AllowMultiple = false
)]
public sealed class ConfigAttribute<TValue> : Attribute
    where TValue : notnull
{
}

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
