namespace Definit.NewApproach;

file static class Test
{
    private static int Run()
    {
        return Try.Catch(NewResult)
            .Match(s => NewResult2(s))
            .Match((s, i) => i, error => throw new Exception());
    }

    private static Result<string> NewResult()
    {
        return new Error(""); 
    }

    private static Result<int> NewResult2(string str)
    {
        return new Error(""); 
    }

    private sealed record Error(string Message);


    private static class Try
    {
        public static Result<TResult>.Builder Catch<TResult>(Func<Result<TResult>> func)
        {
            try
            {
                return new (func());
            }
            catch(Exception ex)
            {
                return new (new Error(ex.Message));
            }
        }
    }

    private sealed class Result<T>
    {
        private (T? Value, Error? Error) Value { get; }
        
        public Result(T value)
        {
            Value = (value, null);
        }

        public Result(Error error)
        {
            Value = (default(T), error);
        }

        //public void Deconstruct(out T? value, out Error? error) => (value, error) = Value;  

        public static implicit operator Result<T>(T value) => new Result<T>(value);
        public static implicit operator Result<T>(Error error) => new Result<T>(error);

        private TResult Match<TResult>(Func<T, TResult> result, Func<Error, TResult> error)
        {
            if(Value.Value is not null)
            {
                return result(Value.Value);
            }
            else  
            {
                return error(Value.Error!);
            }
        }

        public sealed class Builder
        {
            private Result<T> Value { get; }

            internal Builder(Result<T> value)
            {
                Value = value;
            }

            public Result<TResult>.Builder<T> Match<TResult>(Func<T, Result<TResult>> match)
            {
                return Value.Match<Result<TResult>.Builder<T>>(x => new (x, match(x)), e => new (default(T)!, e)); 
            }

            public TResult Match<TResult>(Func<T, TResult> match, Func<Error, TResult> error)
            {
                return Value.Match(match, error); 
            }
        }

        public sealed class Builder<TPrevious>
        {
            private TPrevious Previous { get; }
            private Result<T> Value { get; }

            internal Builder(TPrevious previous, Result<T> value)
            {
                Previous = previous;
                Value = value;
            }

            public Result<TResult>.Builder<TPrevious> Match<TResult>(Func<TPrevious, T, Result<TResult>> match)
            {
                return Value.Match<Result<TResult>.Builder<TPrevious>>(x => new (Previous, match(Previous, x)), e => new (Previous, e)); 
            }

            public Result<TResult>.Builder<TPrevious> Match<TResult>(Func<T, Result<TResult>> match)
            {
                return Value.Match<Result<TResult>.Builder<TPrevious>>(x => new (Previous, match(x)), e => new (Previous, e)); 
            }

            public TResult Match<TResult>(Func<T, TResult> match, Func<Error, TResult> error)
            {
                return Value.Match(match, error); 
            }

            public TResult Match<TResult>(Func<TPrevious, T, TResult> match, Func<Error, TResult> error)
            {
                return Value.Match(x => match(Previous, x), error); 
            }
        }
    }
}
