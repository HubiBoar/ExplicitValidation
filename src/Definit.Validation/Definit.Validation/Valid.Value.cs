namespace Definit.Validation;

public static partial class Valid
{
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
}
