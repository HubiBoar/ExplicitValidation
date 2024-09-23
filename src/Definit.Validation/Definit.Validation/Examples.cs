using Definit.Results;

namespace Definit.Validation;

internal static partial class Example
{
    [IsValid<string>]
    private partial struct Email
    {
        public static void Rule(Rule<string> rule) => rule.NotNull();
    }

    public static partial class Parent1
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

    private static async Task<Result.Error<ValidationError>> Endpoint(UserData body)
    {
        if(body.IsValid().IsError(out var error, out var valid))
        {
            return error.Value;
        }

        return await Run(valid.NotNull().Address);
    }

    private static async Task<Result.Error<ValidationError>> Run(Address.Valid valid)
    {
        await Task.CompletedTask;
        return Result.Success;
    }

    private static async Task<Result.Error<ValidationError>> Endpoint(Email body)
    {
        if(body.IsValid().IsError(out var error, out var valid))
        {
            return error.Value;
        }

        return await Run(valid.NotNull());
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

