namespace Definit.Results;

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
