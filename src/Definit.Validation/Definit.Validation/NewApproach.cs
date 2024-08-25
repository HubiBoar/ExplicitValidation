using Definit.Results;

namespace Definit.ValidationNewApproach;

public static class ExampleLogic
{
    private static Result Test()
    {
        var result = ExampleObject1.Create(c => new
        (
            (c, new ("Obj1.Value1", "Obj1.Value2")),
            (c, "Value1"),
            "Value2"
        ));

        if(result.Is(out Error error).Else(out var example))
        {
            return error;
        }

        Method(example);

        return Result.Success;
    }
    
    private static void Method(ExampleObject1.Valid obj)
    {

    }
}

public sealed record ExampleObject1
(
    ExampleObject2.Valid Obj1,
    ExampleValue1.Valid Value1,
    string Value2
)
: Valid.Record<ExampleObject1>;

public sealed record ExampleObject2
(
    string Value1,
    string Value2
)
: Valid.Record<ExampleObject2>;

public sealed record ExampleValue1() : Valid.Value<ExampleValue1, string>
(
    Rule().NotNull().Min(5)
);

public static class Valid
{
    public interface IValidate
    {
        public virtual Result Validate(string? propertyName = null)
        {
            return DefaultValidate(this, propertyName);
        }

        public static Result DefaultValidate(object obj, string? propertyName = null)
        {
            return obj.GetType()
                .GetProperties()
                .Where(x => x.PropertyType.IsAssignableFrom(typeof(IValidate)))
                .Select(x => 
                {
                    var value  = x.GetValue(obj);
                    var casted = (IValidate)value!;
                    var result = casted.Validate(x.Name);

                    return result;
                })
                .Merge(propertyName);
        }
    }

    public sealed class Context
    {
        internal Context()
        {
        }
    }

    public abstract record Record<T>
        where T : notnull, Record<T>
    {
        public sealed class Valid : IValidate
        {
            public T Value { get; }  

            internal Valid(T value)
            {
                Value = value;
            }

            public static implicit operator Valid((Context Context, T Value) v) => Create(v.Context, v.Value); 
        }

        public static Valid Create(Context context, T value)
        {
            return new Valid(value);
        }

        public static Result<Valid> Create(Func<Context, T> factory)
        {
            try
            {
                var value = factory(new Context());
                var valid = new Valid(value);

                if(((IValidate)valid).Validate()
                    .Is(out Error error))
                {
                    return error;
                }

                return new Valid(value); 
            }
            catch(Exception exception)
            {
                return exception;
            }
        }
    }

    public abstract class Class<T>
        where T : notnull, Class<T>
    {
        public sealed class Valid : IValidate
        {
            public T Value { get; }  

            internal Valid(T value)
            {
                Value = value;
            }

            public static implicit operator Valid((Context Context, T Value) v) => Create(v.Context, v.Value); 
        }

        public static Valid Create(Context context, T value)
        {
            return new Valid(value);
        }

        public static Result<Valid> Create(Func<Context, T> factory)
        {
            try
            {
                var value = factory(new Context());
                var valid = new Valid(value);

                if(((IValidate)valid).Validate()
                    .Is(out Error error))
                {
                    return error;
                }

                return new Valid(value); 
            }
            catch(Exception exception)
            {
                return exception;
            }
        }
    }

    public abstract record Value<TSelf, T>
    (
        Validator<T> Validator
    )
        where TSelf : Value<TSelf, T>, new()
        where T : notnull
    {
        public sealed class Valid : IValidate
        {
            public T Value { get; }  

            internal Valid(T value)
            {
                Value = value;
            }

            public static implicit operator Valid((Context Context, T Value) v) => Create(v.Context, v.Value); 

            Result IValidate.Validate(string? propertyName)
            {
                var rules = new TSelf().Validator;
                return rules.Rules.Select(func => func(Value)).Merge().Match<Result>
                (
                    success => success,
                    error  =>
                    {
                        var name = string.IsNullOrEmpty(propertyName) ? this.GetType().Name : $"{this.GetType().Name}:{propertyName}";

                        return new Error($"ValidationError: [{name}] :: {error.Message}");
                    }
                );
            }
        }

        public static Validator<T> Rule()
        {
            return new Validator<T>();
        }

        public static Valid Create(Context context, T value)
        {
            return new Valid(value);
        }

        public static Result<Valid> Create(T value)
        {
            try
            {
                var valid = new Valid(value);

                if(((IValidate)valid).Validate()
                    .Is(out Error error))
                {
                    return error;
                }

                return new Valid(value); 
            }
            catch(Exception exception)
            {
                return exception;
            }
        }
    }

    public sealed class Validator<T>
        where T : notnull
    {
        public IReadOnlyCollection<Func<T, Result>> Rules => _rules;

        private readonly List<Func<T, Result>> _rules;

        public Validator()
        {
            _rules = [];
        }

        public Validator<T> AddRule(Func<T, Result> rule)
        {
            _rules.Add(rule);
            return this;
        }
    }
}

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
