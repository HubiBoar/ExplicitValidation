namespace Definit.Configuration.Tests.Unit;

public sealed record TestValueConfig() : Config<TestValue.Valid>("TestValue");
public sealed record TestSectionConfig() : Config<TestSection.Valid>("TestValue");

[IsValid<string>]
public partial struct TestValue
{
    public static void Rule(Rule<string> rule) => rule.NotNull();
}

[IsValid]
public partial record TestSection
(
    string Name,
    TestValue TestValue
);
