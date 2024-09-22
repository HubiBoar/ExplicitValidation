using System.Collections.Immutable;

namespace Definit.Validation;

public sealed record Rule<TValue>()
{
    private readonly List<Func<TValue, (string Rule, string Message)?>> _rules = [];

    public ValidationErrors.Property? Validate(TValue value)
    {
        List<(string Rule, string Message)> errors = [];
        foreach(var rule in _rules)
        {
            var error = rule(value);
            if(error is not null)
            {
                errors.Add((error.Value.Rule, error.Value.Message));
            }
        }

        if(errors.Count > 0)
        {
            return new (errors.ToImmutableArray());
        }

        return null;
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
