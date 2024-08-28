using Definit.Validation.Generator;
using SampleSourceGenerator;

Console.WriteLine(ClassNames.TypesList);

[Valid]
public partial class TestClass
{
    public string? StringInTestClass { get; set; } 
}

[Valid]
public partial record TestRecord
(
    TestClass TestClassInTestRecord,
    string StringInTestRecord
);
