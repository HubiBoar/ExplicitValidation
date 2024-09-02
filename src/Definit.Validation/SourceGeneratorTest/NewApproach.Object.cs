using Definit.Results;
using Examples;

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
    Email Email
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

        return await Run(valid.Address());
    }

    private static async Task<Result> Run(Valid<Address> valid)
    {
        await Task.CompletedTask;
        return Result.Success;
    }
}

























































//Auto generated
partial record UserData
{
    private (string PropertyName, Result Result)[] ValidateProperties() => 
    [
        ("Email", Email.Validate()),
        ("Address", Address.Validate()),
    ];

    public Result Validate()
    {
        var errors =
            ValidateProperties()
            .Where(x => x.Result.Is(out Error _))
            .Select(x => 
            {
                x.Result.Is(out Error error);
                return (PropertyName: x.PropertyName, Error: error);
            })
            .ToArray();
    
        if(errors.Length > 0)
        {
            return new Error(string.Join(", ", errors.Select(x => $"{x.PropertyName} :: {x.Error.Message}")));
        }

        return Result.Success;
    }
}

public static class NewApproach_UserData_Valid
{
    public static Valid<Email> Email(this Valid<UserData> valid)
    {
        return new Valid<Email>(valid.Value.Email);
    }

    public static Valid<Address> Address(this Valid<UserData> valid)
    {
        return new Valid<Address>(valid.Value.Address);
    }
}

public sealed partial record Address
{
    private (string PropertyName, Result Result)[] ValidateProperties() => 
    [
        ("Email", Email.Validate()),
    ];

    public Result Validate()
    {
        var errors =
            ValidateProperties()
            .Where(x => x.Result.Is(out Error _))
            .Select(x => 
            {
                x.Result.Is(out Error error);
                return (PropertyName: x.PropertyName, Error: error);
            })
            .ToArray();
    
        if(errors.Length > 0)
        {
            return new Error(string.Join(", ", errors.Select(x => $"{x.PropertyName} :: {x.Error.Message}")));
        }

        return Result.Success;
    }
}

public static class NewApproach_Address_Valid
{
    public static Valid<Examples.Email> Email(this Valid<Address> valid)
    {
        return new Valid<Examples.Email>(valid.Value.Email);
    }
}
