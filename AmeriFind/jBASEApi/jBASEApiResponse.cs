using Newtonsoft.Json;
using JsonConverter = ClientAdminSample.AmeriFind.Json.JsonConverter;

namespace ClientAdminSample.AmeriFind.jBASEApi;

/// <summary>
/// Summary description for jBASEApiResponse
/// </summary>
// ReSharper disable once InconsistentNaming
[Serializable]
public class jBASEApiResponse
{
    [JsonProperty("ApiStatus")] public bool ApiStatus { get; set; } = true;
    //TODO: Default value above should be set to false
    //Note, the above to do is long leftover code that hasn't been refactored to not expect this to be true.

    [JsonProperty("ApiStatusMessage")] public string ApiStatusMessage { get; set; }

    [JsonProperty("Status")]
    [Obsolete("ApiStatus should be used instead")]
    public int Status { get; set; }

    [JsonProperty("ResponseCode")]
    [Obsolete]
    public int ResponseCode { get; set; }

    [JsonProperty("ErrorCode")] [Obsolete] public int ErrorCode { get; set; }

    [JsonProperty("Message")]
    [Obsolete("ApiStatusMessage should be used instead")]
    public string Message { get; set; }

    [JsonProperty("ErrorMsg")]
    [Obsolete("ApiStatusMessage should be used instead")]
    public string ErrorMsg { get; set; }

    public static jBASEApiResponse FromJson(string json)
    {
        return string.IsNullOrEmpty(json)
            ? new jBASEApiResponse()
            : JsonConvert.DeserializeObject<jBASEApiResponse>(json, JsonConverter.Settings);
    }

    public static string ToJson(jBASEApiResponse self)
    {
        return JsonConvert.SerializeObject(self, JsonConverter.Settings);
    }
}