using Definit.Results;

namespace NewApproach;

public sealed partial record Email() : IsValid<string>(Rule.NotNull.Min(5));

public static class ExampleValue
{
    private static async Task<Result> Endpoint(Email body)
    {
        if(body.IsValid.Is(out Error error).Else(out var valid))
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





































































//Logic
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


//Auto generated
//public sealed partial record Email
//{
//    public Result<Valid> IsValid => _idValid ??= Valid.IsValid(this);
//    private Result<Valid>? _idValid = null;
//
//    public static implicit operator Email(string value) => new Email
//    {
//        Value = value,
//    };
//
//    public static implicit operator string(Email value) => value.Value;
//
//    public sealed record Valid
//    {
//        public string Value => Holder.Value;
//        private Email Holder { get; }
//
//        private Valid(Email holder)
//        {
//            Holder = holder;
//        }
//
//        public static implicit operator Email(Valid value) => value.Holder;
//
//        public static Result<Valid> IsValid(Email value)
//        {
//            if(value.Validate().Is(out Error error))
//            {
//                return error;
//            }
//            return new Valid(value);
//        }
//    }
//}
