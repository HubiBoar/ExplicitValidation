namespace Definit.Results.NewApproach;

public sealed class DefaultConstructorException : Exception
{
    public const string Attribute = "Dont use parameterless constructor";
}

public readonly struct EitherMatchError;
public sealed class EitherMatchException<T>() : Exception;
