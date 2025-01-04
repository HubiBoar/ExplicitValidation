using System.Text.Json;
using System.Text.Json.Serialization;
using Definit.Results;
using Microsoft.Extensions.Configuration.Memory;

namespace Definit.Configuration;

internal sealed class ConfigurationConverter : JsonConverter<IConfiguration>
{
    public override IConfiguration Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var root = new ConfigurationRoot(new List<IConfigurationProvider>(new[] { new MemoryConfigurationProvider(new MemoryConfigurationSource()) }));

        var pathParts = new Stack<string>();
        string? currentProperty = null;
        string? currentPath = null;
        while (reader.Read() && (reader.TokenType != JsonTokenType.EndObject || pathParts.Count > 0))
        {
            switch (reader.TokenType)
            {
                case JsonTokenType.PropertyName:
                    currentProperty = reader.GetString();
                    break;
                case JsonTokenType.String:
                    if (pathParts.Count == 0)
                    {
                        root[currentProperty!] = reader.GetString();
                    }
                    else
                    {
                        root[ConfigurationPath.Combine(currentPath!, currentProperty!)] = reader.GetString();
                    }
                    break;
                case JsonTokenType.StartObject:
                    pathParts.Push(currentProperty!);
                    currentPath = ConfigurationPath.Combine(pathParts);
                    break;
                case JsonTokenType.EndObject:
                    pathParts.Pop();
                    currentPath = ConfigurationPath.Combine(pathParts);
                    break;
            }
        }
        return root;
    }

    public override void Write(Utf8JsonWriter writer, IConfiguration value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        foreach (var child in value.GetChildren())
        {
            writer.WritePropertyName(child.Key);
            if (child.Value is null)
            {
                Write(writer, child, options);
            }
            else
            {
                writer.WriteStringValue(child.Value);
            }   
        }

        writer.WriteEndObject();
    }
}

public abstract record Config<TValue>(string SectionName)
    where TValue : IValidBase<TValue>
{
    public Func<U<TValue, ValidationError>> Get { get; init; } = null!;

    public static void Register<TSelf>(IServiceCollection services, IConfiguration configuration)
        where TSelf: Config<TValue>, new()
    {
        services.AddSingleton<TSelf>(_ => Create<TSelf>(configuration)); 
    }

    public static TSelf Create<TSelf>(IConfiguration configuration)
        where TSelf: Config<TValue>, new()
    {
        var sectionName = new TSelf().SectionName;
        
        return new TSelf()
        {
            Get = () => GetValue(configuration, sectionName)
        };
    }
    
    private static U<TValue, ValidationError> GetValue(IConfiguration configuration, string sectionName)
    {
        var section = configuration.GetSection(sectionName);
        if (section.Exists() is false)
        {
            return new ValidationError(sectionName, $"Config Section: Not Found");
        }

        if (string.IsNullOrEmpty(section.Value) is false)
        {
            return TValue.Deserialize(section.Value!);
        }

        var json = JsonSerializer.Serialize((IConfiguration)section, new JsonSerializerOptions
        {
            Converters = { new ConfigurationConverter() },
            WriteIndented = true
        });

        if (string.IsNullOrEmpty(json))
        {
            return ValidationError.Null<TValue>(sectionName);
        }

        var serialized = TValue.Deserialize(json);

        return serialized;
    }
}
