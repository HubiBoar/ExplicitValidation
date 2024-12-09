using Definit.Results;

namespace Definit.Configuration;

public interface IConfigObject
{
    public static abstract ValidationResult Register(IServiceCollection services, IConfiguration configuration);

    public static abstract ValidationResult ValidateConfiguration(IConfiguration configuration);
}

public interface IConfigObject<TValue> : IConfigObject
    where TValue : IValidate<TValue>
{
    public static abstract IsValid<TValue> Create(IServiceProvider services, IConfiguration configuration);
}

public interface ISectionName
{
    public abstract static string SectionName { get; }
}

public sealed record NotFound(string Property) : IValidationError
{
    private readonly string _message = $"[{Property}] NotFound";

    private readonly ValidationError _error = new (Property, $"[{Property}] NotFound");

    public override string ToString() => _message;

    public ValidationError ToValidationError() => _error;
}

public sealed record Null<T>(string Property) : IValidationError
{
    private static string Type = DefinitType.GetTypeVerboseName<T>();

    private readonly string _message = $"[{Type}::{Property}] Is Null";

    private readonly ValidationError _error = new (Property, $"[{Type}::{Property}] Is Null");

    public override string ToString() => _message;

    public ValidationError ToValidationError() => _error;
}

public static class ConfigHelper
{
    public static U<TValue, NotFound, Null<TValue>, Exception> GetValue<TValue>(IConfiguration configuration, string sectionName)
        where TValue : notnull
    {
        try
        {
            var section = configuration.GetSection(sectionName);
            if(section.Exists() == false)
            {
                return new NotFound($"ConfigSection: {sectionName}");
            }

            var value = section.Get<TValue>();
            if (value is null)
            {
                return new Null<TValue>(sectionName);
            }

            return value;
        }
        catch(Exception exception)
        {
            return exception;
        }
    }

    public static ValidationResult Register<T>(this IServiceCollection services, IConfiguration configuration)
        where T : IConfigObject
    {
        return T.Register(services, configuration);
    }
}
