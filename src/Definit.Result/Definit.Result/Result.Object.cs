namespace Definit.Results;

public static partial class GenerateResult
{
    [System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class ObjectAttribute : Attribute
    {
        public Type Type { get; }

        public ObjectAttribute(Type type)
        {
            Type = type;
        }
    }

    [System.AttributeUsage(System.AttributeTargets.Assembly, AllowMultiple = true)]
    public sealed class ObjectAttribute<T> : Attribute
    {
    };
}
