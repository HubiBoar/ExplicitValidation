using Definit.Results;

namespace NewApproach;

public sealed record Validator(Result Result)
{
    public Validator NotNull => this;

    public Validator Min(int size) => this;
}    

public abstract class IsValid<TValue>(Validator _validator)
{
    public required TValue Value { get; init; }

    protected Result Validate()
    {
        return _validator.Result;
    }


    protected static Validator Rule => new Validator(Result.Success);
}

public sealed partial class ConnectionString() : IsValid<string>(Rule.NotNull.Min(5));

public static class Example
{
    private static async Task<Result> Endpoint(ConnectionString body)
    {
        if(body.IsValid.Is(out Error error).Else(out var valid))
        {
            return error;
        }

        return await Run(valid);
    }

    private static async Task<Result> Run(ConnectionString.Valid connectionString)
    {
        await Task.CompletedTask;
        return Result.Success;
    }
}

//Auto generated
public sealed partial class ConnectionString
{
    public required Result<Valid> IsValid { get; init; }

    public static implicit operator ConnectionString(string value) => new ConnectionString
    {
        Value   = value,
        IsValid = Valid.IsValid(value)
    };

    public static implicit operator string(ConnectionString value) => value.Value;

    public sealed record Valid
    {
        public string Value => Holder.Value;
        public ConnectionString Holder { get; }

        private Valid(ConnectionString holder)
        {
            Holder = holder;
        }

        public static Result<Valid> IsValid(ConnectionString value)
        {
            if(value.Validate().Is(out Error error))
            {
                return error;
            }
            return new Valid(value);
        }
    }
}
