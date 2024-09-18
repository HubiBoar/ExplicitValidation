using Definit.Results.NewApproach;

// [assembly: GenerateResult.Base(6)]

namespace Definit.Results.NewApproach;

[System.AttributeUsage(System.AttributeTargets.Struct, AllowMultiple = false)]
public sealed class GenerateResultAttribute : Attribute;

public static partial class GenerateResult
{
    [System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = false)]
    internal sealed class BaseAttribute : Attribute
    {
        public int MaxCount { get; }

        public BaseAttribute(int maxCount)
        {
            MaxCount = maxCount;
        }
    }
}

public static class ResultHelper
{
    public static T ToReturn<TResult, T>(TResult result)
        where T : struct, IEitherBase 
        where TResult : IResultBase<T>
    {
        return result.Value;
    }

    public static T ToReturn<TResult, T>(Exception exception)
        where T : struct, IEitherBase 
        where TResult : IResultBase<T>
    {
        return TResult.FromException(exception);
    }
}

public interface IResultBase<TValue>
    where TValue : struct, IEitherBase
{
    internal TValue Value { get; }

    internal static abstract TValue FromException(Exception exception);
}
