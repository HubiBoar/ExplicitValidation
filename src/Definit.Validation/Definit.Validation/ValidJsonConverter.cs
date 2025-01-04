using System.Text.Json;
using System.Text.Json.Serialization;

namespace Definit.Validation;

public interface ISerializable<TValue>
{
    public abstract static TValue Deserialize(string json);
    public abstract static string Serialize(TValue value);
}

public sealed class ValidJsonConverter<T> : JsonConverter<T>
    where T : ISerializable<T>
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var json = JsonDocument.ParseValue(ref reader).RootElement.GetString();

        if (string.IsNullOrEmpty(json))
        {
            json = JsonDocument.ParseValue(ref reader).RootElement.GetRawText();
        }

        return T.Deserialize(json);
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        var json = T.Serialize(value);

        writer.WriteStringValue(json);
    }
}
