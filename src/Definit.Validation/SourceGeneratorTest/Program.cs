using SampleSourceGenerator;
using Definit.Validation.Generator;

Console.WriteLine(ClassNames.Output);

[Valid]
public class TestClass
{
}

[Valid]
public partial record TestRecord;
