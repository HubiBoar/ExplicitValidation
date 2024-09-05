namespace Definit.NewApproach;

file static class Test
{
    private static int Run()
    {
        return Try.Catch(c =>
        {
            var (str, error) = NewResult().Get(c);

            return NewResult2(str);
        },
        error => throw new Exception());
    }

    private static Result<string> NewResult() => Try.Catch<string>(c => 
    {
        return new Error(""); 
    });

    private static Result<int> NewResult2(string str) => Try.Catch<int>(c =>
    {
        var (s, error) = NewResult().Get(c); 
        return new Error(s); 
    });

    private sealed record Error(string Message);


    private static class Try
    {
        public sealed record Context();

        public static TResult Catch<TResult>(Func<Context, Result<TResult>> func, Func<Error, TResult> onError)
        {
            try
            {
                return func(new Context());
            }
            catch(Exception ex)
            {
                return onError(new Error(ex.Message));
            }
        }

        public static TResult Catch<TResult>(Func<Context, Result<TResult>.Builder> func, Func<Error, TResult> onError)
        {
            try
            {
                return func(new Context());
            }
            catch(Exception ex)
            {
                return onError(new Error(ex.Message));
            }
        }

        public static Result<TResult> Catch<TResult>(Func<Context, Result<TResult>.Builder> func)
        {
            try
            {
                return func(new Context()).Result;
            }
            catch(Exception ex)
            {
                return new Result<TResult>.Builder(new Error(ex.Message)).Result;
            }
        }
    }

    private sealed class Result<T>
    {
        private (T? Value, Error? Error) Value { get; }
        
        private Result(T value)
        {
            Value = (value, null);
        }

        private Result(Error error)
        {
            Value = (default(T), error);
        }

        public (T? Value, Error? Error) Get(Try.Context context)
        {
           return Value; 
        }

        public sealed class Builder
        {
            internal Result<T> Result { get; }

            public Builder(Result<T> result)
            {
                Result = result;
            }

            public Builder(T value)
            {
                Result = new (value);
            }

            public Builder(Error error)
            {
                Result = new (error);
            }

            public static implicit operator Builder(Result<T> value) => new (value);
            public static implicit operator Builder(T value) => new (value);
            public static implicit operator Builder(Error error) => new (error);
        }
        
    }
}
