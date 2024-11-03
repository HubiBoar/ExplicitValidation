namespace Definit.Results;

[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
public sealed class GenerateUnionAttribute : Attribute;

public static class GenerateUnion
{
    [AttributeUsage(
        AttributeTargets.Class | AttributeTargets.Struct, 
        AllowMultiple = false
    )]
    public sealed class ThisAttribute : Attribute;

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class ObjectAttribute : Attribute
    {
        public ObjectAttribute(Type type) {}
    }

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class ObjectAttribute<T> : Attribute;
}

public interface IUnionBase;

public interface IUnionBase<TValue> : IUnionBase
    where TValue : struct
{
    public TValue Value { get; }
}

public record struct Success();
