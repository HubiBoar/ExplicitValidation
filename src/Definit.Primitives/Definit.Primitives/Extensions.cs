using Definit.Results;
using Error = Definit.Results.Error;

namespace Definit.Primitives;

public static class ValidationOptionsExtensions
{
    public static Primitive<TValue>.Options NotNull<TValue>(this Primitive<TValue>.Options opts)
    {
        return opts.Add(value =>
        {
            if(value is null)
            {
                return new Error($"was null but was expected to be {nameof(NotNull)}");
            }
            return Result.Success;
        });
    }

    public static Primitive<string>.Options Min(this Primitive<string>.Options opts, int size)
    {
        return opts.Add(value =>
        {
            if(value.Length < size)
            {
                return new Error($"length was {value.Length} but was expected to be {nameof(Min)} of {size}");
            }
            return Result.Success;
        });
    }

    public static Primitive<string>.Options Max(this Primitive<string>.Options opts, int size)
    {
        return opts.Add(value =>
        {
            if(value.Length > size)
            {
                return new Error($"length was {value.Length} but was expected to be {nameof(Max)} of {size}");
            }
            return Result.Success;
        });
    }
}
