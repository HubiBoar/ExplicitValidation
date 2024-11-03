namespace Definit.Results;

public sealed class DefaultConstructorException : Exception
{
    public const string Attribute = "Dont use parameterless constructor";
}

public readonly struct UnionMatchError;
public sealed class UnionMatchException<T>() : Exception;
