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

    private static async Task<R<ValidationError>> Endpoint(UserData body)
    {
        var (valid, error) = body.IsValid();

        if(error is not null)
        {
            return error.Value;
        }

        return await Run(valid!.Value.Address);
    }

    private static async Task<R<ValidationError>> Run(Address.Valid valid)
    {
        await Task.CompletedTask;
        return R.Success;
    }

    private static async Task<R<ValidationError>> Endpoint(Email body)
    {
        var (valid, error) = body.IsValid();

        if(error is not null)
        {
            return error.Value;
        }

        return await Run(valid!.Value);
    }

    private static async Task<R<ValidationError>> Run(Email.Valid valid)
    {
        await Task.CompletedTask;
        return R.Success;
    }
}

partial class Example
{
    partial class Parent1
    {

    }
}

