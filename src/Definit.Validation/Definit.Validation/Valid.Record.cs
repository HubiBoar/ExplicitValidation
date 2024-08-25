namespace Definit.Validation;

public static partial class Valid
{
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
}
