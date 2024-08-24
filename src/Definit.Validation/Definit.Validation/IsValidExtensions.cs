namespace Definit.Validation;

public static class ValidationExtensions
{
    public static IsValid<T> IsValid<T>(this T value)
        where T : IValidate
    {
        return new IsValid<T>(value, v => v.Validate());
    }
}
