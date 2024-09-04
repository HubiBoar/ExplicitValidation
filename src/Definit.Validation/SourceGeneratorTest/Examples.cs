using Definit.Results;
using Definit.Validation;

namespace Example;

[IsValid<string>]
public readonly partial struct Email
{
    public static void Rule(Rule<string> rule) => rule.NotNull();
}

public static partial class Parent1
{
    [IsValid<string>]
    public readonly partial struct Value1
    {
        public static void Rule(Rule<string> rule) => rule.NotNull();
    }
}

public static partial class Test
{
}

public static partial class Test
{
   static partial void Run();
}

[IsValid]
public partial record UserData
(
    string Name,
    Email Email,
    Address Address
);

[IsValid]
public partial record Address
(
    string PostalCode,
    Email EmailProp
);

public static class ExampleObject
{
    private static async Task<Result> Endpoint(UserData body)
    {
        if(body.IsValid().Is(out Error error).Else(out var valid))
        {
            return error;
        }

        return await Run(valid.Address);
    }

    private static async Task<Result> Run(Address.Valid valid)
    {
        await Task.CompletedTask;
        return Result.Success;
    }
}

public static class ExampleValue
{
    private static async Task<Result> Endpoint(Email body)
    {
        if(body.IsValid().Is(out Error error).Else(out var valid))
        {
            return error;
        }

        return await Run(valid);
    }

    private static async Task<Result> Run(Email.Valid valid)
    {
        await Task.CompletedTask;
        return Result.Success;
    }
}
