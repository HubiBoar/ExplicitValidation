using System.Diagnostics.CodeAnalysis;

namespace Definit.Results;

[System.AttributeUsage(System.AttributeTargets.Struct, AllowMultiple = false)]
public sealed class GenerateResultAttribute : Attribute;

public static partial class GenerateResult
{
}

public static class ResultHelper
{
    public static T ToReturn<TResult, T>(TResult result)
        where TResult : struct, IResultBase<T>
    {
        return result.Value;
    }

    public static T ToReturn<TResult, T>(Exception exception)
        where TResult : struct, IResultBase<T>
    {
        return TResult.FromException(exception);
    }

    public static Error? Test()
    {
        return ToReturn<Result, Error?>(Result.Success);
    }
}

public interface IResultBase<TValue>
{
    internal TValue Value { get; }

    internal static abstract TValue FromException(Exception exception);
}
