using Definit.Results;

namespace NewApproach;

public interface IIsValid
{
    Result Validate();
}

public sealed record Rule<TValue>()
{
    private readonly List<Func<TValue, Result>> _rules = [];

    public Result Validate(TValue value)
    {
        List<string> errors = [];
        foreach(var rule in _rules)
        {
            if(rule(value).Is(out Error error))
            {
                errors.Add(error.Message);
            }
        }

        if(errors.Count > 0)
        {
            return new Error(string.Join("; ", errors));
        }

        return Result.Success;
    }
}

public static class Rule
{
    public static Rule<TValue> Get<TValue>()
    {
        return new Rule<TValue>();
    }
}

public static class RuleExtensions
{
    public static Rule<TValue> NotNull<TValue>(this Rule<TValue> rule)
    {
        return rule;
    }

    public static Rule<string> Min(this Rule<string> rule)
    {
        return rule;
    }
}

public interface IIsValid<TValue> : IIsValid
{
    public TValue Value { get; }

    abstract static void Rule(Rule<TValue> rule);
}

public readonly partial struct Email : IIsValid<string>
{
    public static void Rule(Rule<string> rule) => rule.NotNull();
}

public static partial class Parent1
{
    public readonly partial struct Value1 : IIsValid<string>
    {
        public static void Rule(Rule<string> rule) => rule.NotNull();
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


//Auto generated
//partial struct Email
//{
//    private readonly static Rule<string> _rule;
//
//    static Email()
//    {
//        _rule = new();
//        Rule(_rule);
//    }
//
//    public string Value { get; }
//    
//    public Email(string value)
//    {
//        Value = value;
//    }
//    
//    public static implicit operator Email(string value) => new (value);
//    
//    public static implicit operator string(Email value) => value.Value;
//
//    public Result Validate() => _rule.Validate(Value);
//    public Result<Valid> IsValid() => Valid.Create(this);
//
//    public readonly struct Valid
//    {
//        public Email Value { get; }
//
//        private Valid(Email Value)
//        {
//            this.Value = Value;
//        }
//
//        public static Result<Valid> Create(Email Value)
//        {
//            if(Value.Validate().Is(out Error error))
//            {
//                return error;
//            }
//
//            return new Valid(Value);
//        }
//    }
//}
