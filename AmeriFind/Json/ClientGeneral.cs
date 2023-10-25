
using ClientAdminSample.AmeriFind.jBASEApi;
using global::ClientAdminSample.AmeriFind.jBASEApi;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ClientAdminSample.AmeriFind;

    public class ClientGeneral : jBASEApiResponse
    {
    [Required(ErrorMessage = "Enter an Account Number")]
    [Range(10000, 99999, ErrorMessage = "Client number value is invalid.")]
    [RegularExpression(@"^(10000|([1-9][0-9]{4})|99999)$", ErrorMessage = "Client number must be 5 digits.")]
    [JsonProperty(nameof(Account))] public string? Account { get; set; } = null;
    [JsonProperty(nameof(PaymentProfile))] public string PaymentProfile { get; set; } 

    [Required(ErrorMessage = "Must have start date")]
        [JsonProperty(nameof(StarsDate))] public string? StarsDate { get; set; } 
        [JsonProperty(nameof(CaseDescription))] public string? CaseDescription { get; set; } 
        [JsonProperty(nameof(CaseFormat))] public string? CaseFormat { get; set; } 
        [JsonProperty(nameof(Referral))] public string? Referral { get; set; } 


        [JsonProperty(nameof(SystemCode))] public string? SystemCode { get; set; } 

        [JsonProperty(nameof(CompanyID))] public string? CompanyID { get; set; }

        [JsonProperty(nameof(SuppressPrice))] public string? SuppressPrice { get; set; } 
        [JsonProperty(nameof(ProfessionalLicense))] public string? ProfessionalLicense { get; set; }  

        [Required(ErrorMessage = "Must have a permissible purspose")]
        [JsonProperty(nameof(PermissablePurpose))] public string? PermissablePurpose { get; set; } 

    public new static ClientGeneral FromJson(string json)
        {
            return string.IsNullOrEmpty(json)
                ? new ClientGeneral()
                : JsonConvert.DeserializeObject<ClientGeneral>(json, Json.JsonConverter.Settings);
        }
    }


