namespace Definit.Results;

[System.AttributeUsage(System.AttributeTargets.Struct, AllowMultiple = false)]
public sealed class GenerateEitherAttribute : Attribute;

public static class GenerateEither
{
}

public interface IEitherBase;

public interface IEitherBase<TValue> : IEitherBase
    where TValue : struct
{
    public TValue Value { get; }
}
