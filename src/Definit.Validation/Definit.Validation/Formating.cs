namespace Definit.Validation;

internal static class Formatting
{
    public static string Rule(string rule, string message)
        => $"[{rule}] :: {message}";

    public static string ValidationError(ValidationError error)
        => string.Join("\n", error.Errors.Select(x => $"{x.Name} => {x.ToString()}"));

    public static string ValidationError(ValidationError.Property property)
        => string.Join(string.Empty, property.Messages.Select(x => $"\n\t -> {x};"));    
}
