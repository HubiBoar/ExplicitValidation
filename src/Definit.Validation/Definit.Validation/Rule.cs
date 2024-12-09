using System.Collections.Immutable;
using Definit.Results;

namespace Definit.Validation;

public sealed record Rule<TValue>()
{
    private readonly List<Func<TValue, (string Rule, string Message)?>> _rules = [];

    public R<ValidationError.Property> ValidateProperty(TValue value, string propertyName)
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
            return new ValidationError.Property(propertyName, errors.Select(x => Formatting.Rule(x.Rule, x.Message)).ToImmutableArray());
        }

        return R.Success;
    }

    public R<ValidationError> Validate(TValue value, string propertyName)
    {
        var (_, error) = Validate(value, propertyName);

        if(error is not null)
        {
            return new ValidationError([error.Value]);  
        }

        return R.Success;
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
