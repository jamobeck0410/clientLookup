﻿using Newtonsoft.Json;

namespace ClientAdminSample.AmeriFind.Json;

public class JsonCustomBooleanJsonConverter : Newtonsoft.Json.JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(bool);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
        JsonSerializer serializer)
    {
        switch (reader.Value.ToString().ToLower().Trim())
        {
            case "true":
            case "yes":
            case "y":
            case "1":
                return true;
            case "false":
            case "no":
            case "n":
            case "0":
            case "":
                return false;
        }

        // If we reach here, we're pretty much going to throw an error so let's let Json.NET throw it's pretty-fied error message.
        return new JsonSerializer().Deserialize(reader, objectType);
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
    }
}