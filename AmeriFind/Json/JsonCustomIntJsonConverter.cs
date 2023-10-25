using Newtonsoft.Json;

namespace ClientAdminSample.AmeriFind.Json;

public class JsonCustomIntJsonConverter : Newtonsoft.Json.JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(int);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
        JsonSerializer serializer)
    {
        if (int.TryParse(reader.Value.ToString(), out var intValue)) return intValue;

        return string.IsNullOrEmpty(reader.Value.ToString())
            ? 0
            : new JsonSerializer().Deserialize(reader, objectType);

        // If we reach here, we're pretty much going to throw an error so let's let Json.NET throw it's pretty-fied error message.
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        writer.WriteValue(((int) value).ToString());
    }
}