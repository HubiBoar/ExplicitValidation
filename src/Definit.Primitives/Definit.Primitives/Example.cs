namespace Definit.Primitives;

public sealed record ConnectionString(string Value) : Primitive<string>
(
    Value,
    Rule().Min(5).Max(10)
);

internal sealed class TestObject : IValidate
{
    public required ConnectionString DbConnectionString { get; init; }
}
