namespace Definit.Results;

public interface IError<TSelf>
    where TSelf : IError<TSelf>, new()
{
    public ErrorPayload Payload { get; init; }

    public virtual static TSelf Create(ErrorPayload payload)
    {
        return new TSelf()
        {
            Payload = payload
        };
    }
}

public readonly record struct ErrorPayload(string Message, string StackTrace)
{
    public ErrorPayload(string message) : this (message, Environment.StackTrace) {}
    public ErrorPayload(Exception ex) : this (ex.Message, ex.StackTrace ?? Environment.StackTrace) {}

    public static implicit operator ErrorPayload(Exception ex) => new (ex);

    public ErrorPayload WithContext(string context)
    {
        return this with
        {
            Message = $"{context} :: {this.Message}",
        };
    }
}

public readonly record struct Error(ErrorPayload Payload) : IError<Error>
{
    public Error(Exception exception) : this(new ErrorPayload(exception)) {} 
    public Error(string message) : this(new ErrorPayload(message)) {} 

    public T ToError<T>(string context)
        where T : IError<T>, new()
    {
        var payload = Payload.WithContext(context);
        return T.Create(payload);
    }

    public static Error Create(ErrorPayload payload) => new Error(payload);

    public static implicit operator Error(Exception ex) => new Error(ex);
    public static implicit operator Error(ErrorPayload ex) => new Error(ex);
}

public static class ErrorExtension
{
    public static T WithContext<T>(this T error, string context)
        where T : IError<T>, new()
    {
        var payload = error.Payload.WithContext(context);

        return T.Create(payload);
    }
}
