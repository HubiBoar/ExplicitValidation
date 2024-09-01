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
        if(body.IsValid.Is(out Error error).Else(out var valid))
        {
            return error;
        }

        return await Run(valid);
    }

    private static async Task<Result> Run(Valid<UserData> valid)
    {
        await Task.CompletedTask;
        return Result.Success;
    }
}

























































//Auto generated
public sealed partial record UserData
{
    public Result<Valid> IsValid => _idValid ??= Valid.IsValid(this);
    private Result<Valid>? _idValid = null;

    public sealed record Valid
    (
        string Name,
        Email.Valid Email,
        Address.Valid Address
    )
    {
        public static implicit operator UserData(Valid value) => new
        (
            value.Name,
            value.Email,
            value.Address
        );

        public static Result<Valid> IsValid(UserData value)
        {
            List<Error> errors = new();
            if(value.Email.IsValid.Is(out Error error).Else(out var validEmail))
            {
                errors.Add(error);
            }

            if(value.Address.IsValid.Is(out error).Else(out var validAddress))
            {
                errors.Add(error);
            }

            if(errors.Count > 0)
            {
                return new Error(string.Join(", ", errors.Select(x => x.Message)));
            }
            
            return new Valid(value.Name, validEmail, validAddress);
        }
    }
}

public sealed partial record Address
{
    public Result<Valid> IsValid => _idValid ??= Valid.IsValid(this);
    private Result<Valid>? _idValid = null;

    public sealed record Valid
    (
        string PostalCode,
        Email.Valid Email
    )
    {
        public static implicit operator Address(Valid value) => new
        (
            value.PostalCode,
            value.Email
        );

        public static Result<Valid> IsValid(Address value)
        {
            List<Error> errors = new();
            if(value.Email.IsValid.Is(out Error error).Else(out var validEmail))
            {
                errors.Add(error);
            }

            if(errors.Count > 0)
            {
                return new Error(string.Join(", ", errors.Select(x => x.Message)));
            }
            
            return new Valid(value.PostalCode, validEmail);
        }
    }
}
