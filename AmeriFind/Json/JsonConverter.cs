using Newtonsoft.Json;

namespace ClientAdminSample.AmeriFind.Json;

public static class JsonConverter
{
    public static readonly JsonSerializerSettings Settings = new()
    {
        MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
        DateParseHandling = DateParseHandling.None,
        Converters =
        {
            new JsonCustomDateTimeJsonConverter(),
            new JsonCustomBooleanJsonConverter(),
            new JsonCustomMultifactorPreferenceJsonConverter(),
            new JsonCustomIntJsonConverter()
        }
    };
}