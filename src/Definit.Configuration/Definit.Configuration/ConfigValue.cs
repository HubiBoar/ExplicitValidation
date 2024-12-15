namespace Definit.Configuration;

[System.AttributeUsage
(
    System.AttributeTargets.Class,
    AllowMultiple = false
)]
public sealed class ConfigAttribute : Attribute
{
}

[System.AttributeUsage
(
    System.AttributeTargets.Class,
    AllowMultiple = false
)]
public sealed class ConfigAttribute<TValue> : Attribute
    where TValue : notnull
{
}
