namespace Definit.Results.NewApproach;

[System.AttributeUsage(System.AttributeTargets.Struct, AllowMultiple = false)]
public sealed class GenerateResultAttribute : Attribute;

public static partial class GenerateResult
{
    [System.AttributeUsage(System.AttributeTargets.Module, AllowMultiple = true)]
    public sealed class ObjectAttribute : Attribute
    {
        public bool AllowUnsafe { get; set; }

        public Type Type { get; }

        public ObjectAttribute(Type type)
        {
            Type = type;
        }
    }

    [System.AttributeUsage(System.AttributeTargets.Module, AllowMultiple = true)]
    public sealed class ObjectAttribute<T> : Attribute
    {
        public bool AllowUnsafe { get; set; }
    };
}
