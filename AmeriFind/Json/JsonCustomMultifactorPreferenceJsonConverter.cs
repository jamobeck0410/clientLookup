using Newtonsoft.Json;

namespace ClientAdminSample.AmeriFind.Json;

public class JsonCustomMultifactorPreferenceJsonConverter : Newtonsoft.Json.JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(MultifactorPreference);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
        JsonSerializer serializer)
    {
        return string.IsNullOrEmpty(reader.Value.ToString())
            ? -1
            : new JsonSerializer().Deserialize(reader, objectType);
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
    }
}