namespace Definit.Results.NewApproach;

public static partial class GenerateResult
{
    [System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class ObjectAttribute : Attribute
    {
        public bool AllowUnsafe { get; set; } = true;

        public Type Type { get; }

        public ObjectAttribute(Type type)
        {
            Type = type;
        }
    }

    [System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class ObjectAttribute<T> : Attribute
    {
        public bool AllowUnsafe { get; set; } = true;
    };
}
