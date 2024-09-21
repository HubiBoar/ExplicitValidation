using Definit.Results;

namespace Definit.Validation;

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
