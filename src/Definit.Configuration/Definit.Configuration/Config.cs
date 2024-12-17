using Definit.Results;

namespace Definit.Configuration;

public interface ISectionName
{
    public abstract static string SectionName { get; }
}

public interface IConfig<TValue>
    where TValue : IValidBase<TValue>
{
    public string SectionName { get; }

    public U<TValue, ValidationError> Get();
}

public sealed class Config<TValue, TSectionName> : IConfig<TValue>
    where TValue : IValidBase<TValue>
    where TSectionName : ISectionName
{
    public string SectionName => TSectionName.SectionName;

    private readonly Func<U<TValue, ValidationError>> _func;

    public Config(Func<U<TValue, ValidationError>> func)
    {
        _func = func;
    }

    public U<TValue, ValidationError> Get()
    {
        return _func();
    }
}




















///DONT WORK ON THIS AND GENERATORS

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

public interface IConfig : IIsValid
{
    abstract static string SectionName { get; }

    abstract static U<ValidationError> Register(IServiceCollection services, IConfiguration configuration);
}

public interface IConfig<TValue, TConfig, TValid> 
    where TValue : notnull
    where TConfig : IConfig<TValue, TValid>
    where TValid : IValid<TValue>
{
    abstract static string SectionName { get; }

    abstract static U<ValidationError> Register(IServiceCollection services, IConfiguration configuration);

    abstract static void Rule(Rule<TValue> rule);
}

public interface IConfig<TValue, TValid> : IConfig, IIsValid<TValue, TValid>
    where TValue : notnull
    where TValid : IValid<TValue>
{
}
