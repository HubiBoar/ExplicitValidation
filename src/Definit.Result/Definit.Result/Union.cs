namespace Definit.Results;

public readonly struct Async
{
    public static Async Instance { get; } = new ();
}

[AttributeUsage(AttributeTargets.Struct, AllowMultiple = false)]
public sealed class UnionAttribute : Attribute;

public static class Union
{
    public static class Try
    {
        [AttributeUsage(
            AttributeTargets.Class | AttributeTargets.Struct, 
            AllowMultiple = false
        )]
        public sealed class ThisAttribute : Attribute;
    }

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class TryAttribute : Attribute
    {
        public TryAttribute(Type type) {}
    }

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class TryAttribute<T> : Attribute;
}

public interface IUnionBase;

public interface IUnionBase<TValue> : IUnionBase
    where TValue : struct
{
    public TValue Value { get; }
}
