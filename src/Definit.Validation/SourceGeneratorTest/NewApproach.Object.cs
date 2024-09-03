using Definit.Results;

namespace NewApproach;

public partial record UserData
(
    string Name,
    Email Email,
    Address Address
)
: IIsValid;

public partial record Address
(
    string PostalCode,
    Email EmailProp
)
: IIsValid;

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
