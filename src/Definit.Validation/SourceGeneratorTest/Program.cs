using SampleSourceGenerator;
using NewApproach;

Console.WriteLine(ClassNames.TypesList);

public partial record TestClass : IsValid
{
    public string? StringInTestClass { get; set; } 
}

public partial record TestRecord
(
    TestClass TestClassInTestRecord,
    string StringInTestRecord
);

partial record TestRecord
{
}

namespace Test
{
    public partial class TestClass
    {
        public string? StringInTestClass { get; set; } 
    }

    public partial record TestRecord
    (
        TestClass TestClassInTestRecord,
        string StringInTestRecord
    );

    partial record TestRecord
    {
    }
}

namespace Test2
{
    public partial class TestHolder
    {
        public partial class TestClass
        {
            public string? StringInTestClass { get; set; } 
        }

        public partial record TestRecord
        (
            TestClass TestClassInTestRecord,
            string StringInTestRecord
        );

        partial record TestRecord
        {
        }
    }
}
