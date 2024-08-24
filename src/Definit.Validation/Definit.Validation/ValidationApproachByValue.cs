using Definit.Results;

namespace Validation.ByValue;

public sealed class IsValid<T>
    where T : IValidable
{
    public Result<Valid<T>> Value { get; }

    public IsValid(T validate)
    {
        if(validate.Validate().Is(out Error error))
        {
            Value = error;
        }
        else
        {
            Value = new Valid<T>(validate);
        }
    }
}

public sealed class Valid<T>
    where T : IValidable
{
    public T ValidValue { get; }

    internal Valid(T value)
    {
        ValidValue = value;
    }
}

public static class ValidationExtensions
{
    public static IsValid<T> IsValid<T>(this T value)
        where T : IValidable
    {
        return new IsValid<T>(value);
    }
}

public interface IValidable
{
    internal virtual Result Validate(string? propertyName = null)
    {
        return GetType()
            .GetProperties()
            .Where(x => x.PropertyType.IsAssignableFrom(typeof(IValidable)))
            .Select(x => 
            {
                var value  = x.GetValue(this);
                var casted = (IValidable)value!;
                var result = casted.Validate(x.Name);

                return result;
            })
            .Merge();
    }
}

public static class ResultExtensions
{
    public static Result Merge(this IEnumerable<Result> results, string? prefix = null)
    {
        List<Error> errors = [];

        foreach(var result in results)
        {
            if(result.Is(out Error error))
            {
                errors.Add(error);
            }
        }

        var messages = string.Join(", ", errors.Select(x => x.Message));

        var message  = string.IsNullOrEmpty(prefix) ? messages : $"{prefix} :: {messages}"; 

        return new Error(message);
    }
}

public sealed record ConnectionString(string Value) : Validate<string>
(
    Value,
    Rule().Min(5).Max(10)
);


public abstract record Validate<TValue>
(
    TValue Value,
    Validate<TValue>.Options Opts
) 
: IValidable
{
    public sealed record Options(List<string> Errors);

    public static Options Rule()
    {
        return new Options([]);
    }

    Result IValidable.Validate(string? propertyName)
    {
        if(Opts.Errors.Count > 0)
        {
            var messages = string.Join(", ", Opts.Errors);
            var name     = string.IsNullOrEmpty(propertyName) ? this.GetType().Name : $"{this.GetType().Name}:{propertyName}";
            return new Error($"ValidationError: [{name}] :: {messages}");
        }
        return Result.Success;
    }
}

public static class ValidationOptionsExtensions
{
    public static Validate<TValue>.Options NotNull<TValue>(this Validate<TValue>.Options opts)
    {
        return opts;
    }

    public static Validate<string>.Options Min(this Validate<string>.Options opts, int size)
    {
        return opts;
    }

    public static Validate<string>.Options Max(this Validate<string>.Options opts, int size)
    {
        return opts;
    }
}

public sealed class TestObject : IValidable
{
    public required ConnectionString DbConnectionString { get; init; }
}

