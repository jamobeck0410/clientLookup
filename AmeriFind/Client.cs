
using ClientAdminSample.AmeriFind.jBASEApi;
using global::ClientAdminSample.AmeriFind.jBASEApi;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ClientAdminSample.AmeriFind;

public class Client : jBASEApiResponse
{
    [Required(ErrorMessage = "Enter an Account Number")]
    [Range(10000, 99999, ErrorMessage = "Client number value is invalid.")]
    [RegularExpression(@"^(10000|([1-9][0-9]{4})|99999)$", ErrorMessage = "Client number must be 5 digits.")]
    [JsonProperty(nameof(Account))] public string? Account { get; set; } = null;

    [Required(ErrorMessage = "Enter a Short Name")]
    [MaxLength(10, ErrorMessage = "Short Name is too long")]
    [JsonProperty(nameof(ShortName))] public string? ShortName { get; set; }

    [Required(ErrorMessage = "Enter a Full Name")]
    [MaxLength(50, ErrorMessage = "Full Name is too long")]
    [JsonProperty(nameof(FullName))] public string? FullName { get; set; }

    [Required(ErrorMessage = "Enter Address1")]
    [RegularExpression(@"^[0-9]+\s[a-zA-Z\s\-']{2,}.\s?[a-zA-Z\s\(\),]{2,}$", ErrorMessage = "Enter a valid address")]
    [JsonProperty(nameof(Address1))] public string? Address1 { get; set; } = null;

    [RegularExpression(@"^[0-9]+\s[a-zA-Z\s\-']{2,}.\s?[a-zA-Z\s\(\),]{2,}$", ErrorMessage = "Enter a valid address")]
    [JsonProperty(nameof(Address2))] public string? Address2 { get; set; } = null;

    [Required(ErrorMessage = "Enter a city")]
    [RegularExpression(@"^([a-zA-Z\u0080-\u024F]+(?:. |-| |'))*[a-zA-Z\u0080-\u024F]*$", ErrorMessage = "Enter a valid city")]
    [JsonProperty(nameof(City))] public string? City { get; set; }

    [Required(ErrorMessage = "Enter a state")]
    [RegularExpression(@"^([a-zA-Z\u0080-\u024F]+(?:. |-| |'))*[a-zA-Z\u0080-\u024F]*$", ErrorMessage = "Enter a valid state")]
    [JsonProperty(nameof(State))] public string? State { get; set; }

    [Required(ErrorMessage = "Enter a ZipCode")]
    [RegularExpression(@"^[0-9]{5}$|^[0-9]{5}-?[0-9]{4}$", ErrorMessage = "Enter a valid ZipCode")]
    [JsonProperty(nameof(Zip))] public string? Zip { get; set; }

    [Required(ErrorMessage = "Enter an Industry")]
    [RegularExpression(@"^[a-zA-Z0-9_]*$", ErrorMessage = "Enter a valid Industry")]
    [JsonProperty(nameof(Industry))] public string? Industry { get; set; }
    [JsonProperty(nameof(TerminationDate))] public string? TerminationDate { get; set; }

    public int ClientCount { get; set; }

    public new static Client FromJson(string json)
    {
        return string.IsNullOrEmpty(json)
            ? new Client()
            : JsonConvert.DeserializeObject<Client>(json, Json.JsonConverter.Settings);
    }
}


