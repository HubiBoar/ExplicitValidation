using Definit.Results;

namespace NewApproach;

public sealed record Validator(Result Result)
{
    public Validator NotNull => this;

    public Validator Min(int size) => this;
}    

public abstract record IsValid<TValue>(Validator Validator)
{
    public required TValue Value { get; init; }

    protected Result Validate()
    {
        return Validator.Result;
    }


    protected static Validator Rule => new Validator(Result.Success);
}
