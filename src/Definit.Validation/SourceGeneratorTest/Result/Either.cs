using Definit.Results.NewApproach;

// [assembly: GenerateEither.Base(6)]

namespace Definit.Results.NewApproach;

[System.AttributeUsage(System.AttributeTargets.Struct, AllowMultiple = false)]
public sealed class GenerateEitherAttribute : Attribute;

public static class GenerateEither
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

public interface IEitherBase;

public interface IEitherBase<TValue> : IEitherBase
    where TValue : struct
{
    public TValue Value { get; }
}
