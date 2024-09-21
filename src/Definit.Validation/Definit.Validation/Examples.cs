using Definit.Results;

namespace Definit.Validation;

internal static partial class Example
{
    [IsValid<string>]
    private partial struct Email
    {
        public static void Rule(Rule<string> rule) => rule.NotNull();
    }

    private static partial class Parent1
    {
        [IsValid<string>]
        public partial struct Value1
        {
            public static void Rule(Rule<string> rule) => rule.NotNull();
        }
    }

    [IsValid]
    private partial record UserData
    (
        string Name,
        Email Email,
        Address Address
    );

    [IsValid]
    private partial record Address
    (
        string PostalCode,
        Email EmailProp
    );

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

partial class Example
{
    partial class Parent1
    {

    }
}

