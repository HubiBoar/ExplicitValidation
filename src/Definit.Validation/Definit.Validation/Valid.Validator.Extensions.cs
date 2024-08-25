namespace Definit.Validation;

public static class ValidationOptionsExtensions
{
    public static Valid.Validator<TValue> NotNull<TValue>(this Valid.Validator<TValue> opts)
        where TValue : notnull
    {
        return opts.AddRule(value =>
        {
            if(value is null)
            {
                return new Error($"was null but was expected to be {nameof(NotNull)}");
            }
            return Result.Success;
        });
    }

    public static Valid.Validator<string> Min(this Valid.Validator<string> opts, int size)
    {
        return opts.AddRule(value =>
        {
            if(value.Length < size)
            {
                return new Error($"length was {value.Length} but was expected to be {nameof(Min)} of {size}");
            }
            return Result.Success;
        });
    }

    public static Valid.Validator<string> Max(this Valid.Validator<string> opts, int size)
    {
        return opts.AddRule(value =>
        {
            if(value.Length > size)
            {
                return new Error($"length was {value.Length} but was expected to be {nameof(Max)} of {size}");
            }
            return Result.Success;
        });
    }
}
