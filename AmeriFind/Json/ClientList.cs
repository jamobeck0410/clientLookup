using ClientAdminSample.AmeriFind.jBASEApi;
    using global::ClientAdminSample.AmeriFind.jBASEApi;
    using Newtonsoft.Json;
    using System.ComponentModel.DataAnnotations;

namespace ClientAdminSample.AmeriFind.Json;


public class ClientList : jBASEApiResponse { 

    [JsonProperty(nameof(ClientList))] public IEnumerable<Client>? Clients { get; set; }
    
    public new static ClientList FromJson(string json)
    {
        return string.IsNullOrEmpty(json)
            ? new ClientList()
            : JsonConvert.DeserializeObject<ClientList>(json, Json.JsonConverter.Settings);
    }
}



