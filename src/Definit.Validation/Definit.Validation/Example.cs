namespace Definit.Validation;

internal static class ExampleLogic
{
    private sealed record Object1
    (
        Object2.Valid Obj1,
        Value1.Valid Value1,
        string Value2
    )
    : Valid.Record<Object1>;

    private sealed record Object2
    (
        string Value1,
        string Value2
    )
    : Valid.Record<Object2>;

    private sealed record Value1() : Valid.Value<Value1, string>
    (
        Rule().NotNull().Min(5)
    );

    private static Result Test()
    {
        var result = Object1.Create(c => new
        (
            (c, new ("Obj1.Value1", "Obj1.Value2")),
            (c, "Value1"),
            "Value2"
        ));

        if(result.Is(out Error error).Else(out var example))
        {
            return error;
        }

        Method(example);

        return Result.Success;
    }
    
    private static void Method(Object1.Valid obj)
    {
        var object1 = obj.Value;
    }
}

