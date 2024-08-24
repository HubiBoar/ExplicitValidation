using Definit.Json;
using Definit.Results;
using Newtonsoft.Json;

namespace Definit.Primitives;

[SystemJsonStaticConverter]
public abstract record Primitive<TValue> 
(
    TValue Value,
    Primitive<TValue>.Options Opts
) 
: IValidate, IJsonStaticConvertable<Primitive<TValue>>
where TValue : notnull
{
    public sealed record Options
    {
        public IReadOnlyList<Func<TValue, Result>> Results => _results;

        private readonly List<Func<TValue, Result>> _results = [];

        public Options Add(Func<TValue, Result> result)
        {
            _results.Add(result);
            return this;
        }
    }

    public static T Create<T>(TValue value)
        where T : Primitive<TValue>
    {
        return (T)System.Activator.CreateInstance(typeof(T), value)!;
    }

    protected static Options Rule()
    {
        return new Options();
    }

    Result IValidate.Validate(string? propertyName)
    {
        return Opts.Results.Select(func => func(Value)).Merge().Match<Result>
        (
            success => success,
            error  =>
            {
                var name = string.IsNullOrEmpty(propertyName) ? this.GetType().Name : $"{this.GetType().Name}:{propertyName}";

                return new Error($"ValidationError: [{name}] :: {error.Message}");
            }
        );
    }

    public static string ToJson(Primitive<TValue> value) => JsonConvert.SerializeObject(value!.Value);
    public override string? ToString()                   => JsonConvert.SerializeObject(Value);
    public static bool CanConvert(Type type)             => type.IsAssignableFrom(typeof(Primitive<TValue>));

    public static T FromJson<T>(string json)
        where T : Primitive<TValue>
    {
        var value = JsonConvert.DeserializeObject<TValue>(json)!;
        
        return Create<T>(value);
    }
}
