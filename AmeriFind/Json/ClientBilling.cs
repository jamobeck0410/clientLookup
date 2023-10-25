using ClientAdminSample.AmeriFind.jBASEApi;
using global::ClientAdminSample.AmeriFind.jBASEApi;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ClientAdminSample.AmeriFind;

    public class ClientBilling : jBASEApiResponse
    {
        [Required(ErrorMessage = "Enter an Account Number")]
        [Range(10000, 99999, ErrorMessage = "Client number value is invalid.")]
        [RegularExpression(@"^(10000|([1-9][0-9]{4})|99999)$", ErrorMessage = "Client number must be 5 digits.")]
        [JsonProperty(nameof(Account))] public string? Account { get; set; } = null;
        [JsonProperty(nameof(BillNameZip))] public string? BillNameZip { get; set; }

        [JsonProperty(nameof(ClientProfile))] public string ClientProfile { get; set; }

        [Required(ErrorMessage = "Enter Billing Address1")]
        [RegularExpression(@"^[0-9]+\s[a-zA-Z\s\-']{2,}.\s?[a-zA-Z\s\(\),]{2,}$", ErrorMessage = "Enter a valid billing address")]
        [JsonProperty(nameof(BillAddress1))] public string BillAddress1 { get; set; }

        [Required(ErrorMessage = "Enter a Payment Profile")]
        [JsonProperty(nameof(PaymentProfile))] public string PaymentProfile { get; set; }


        [RegularExpression(@"^[0-9]+\s[a-zA-Z\s\-']{2,}.\s?[a-zA-Z\s\(\),]{2,}$", ErrorMessage = "Enter a valid billing address")]
        [JsonProperty(nameof(BillAddress2))] public string BillAddress2 { get; set; }

        [Required(ErrorMessage = "Enter an billing City")]
        [RegularExpression(@"^([a-zA-Z\u0080-\u024F]+(?:. |-| |'))*[a-zA-Z\u0080-\u024F]*$", ErrorMessage = "Enter a valid city")]
        [JsonProperty(nameof(BillCity))] public string? BillCity { get; set; }

        [Required(ErrorMessage = "Enter a billing ZipCode")]
        [RegularExpression(@"^[0-9]{5}$|^[0-9]{5}-?[0-9]{4}$", ErrorMessage = "Enter a valid billing Zip")]
        [JsonProperty(nameof(BillZip))] public string? BillZip { get; set; }

        [Required(ErrorMessage = "Enter a billing state")]
        [RegularExpression(@"^([a-zA-Z\u0080-\u024F]+(?:. |-| |'))*[a-zA-Z\u0080-\u024F]*$", ErrorMessage = "Enter a valid billing state")]
        [JsonProperty(nameof(BillState))] public string? BillState { get; set; }

        [JsonProperty(nameof(LastPaymentDate))] public string? LastPaymentDate { get; set; } 

        [JsonProperty(nameof(CurrentBalance))] public string? CurrentBalance { get; set; } 

        [JsonProperty(nameof(SetUpFee))] public string? SetUpFee { get; set; }

        [JsonProperty(nameof(PastDueStatus))] public string? PastDueStatus { get; set; }

        [Required(ErrorMessage = "Select an billing cycle option")]
        [JsonProperty(nameof(BillingCycle))] public string? BillingCycle { get; set; }

        [JsonProperty(nameof(InvoiceEmail))] public string? InvoiceEmail { get; set; } 

        [JsonProperty(nameof(DetailEmail))] public string? DetailEmail { get; set; } 
        [JsonProperty(nameof(PurchaseOrder))] public string? PurchaseOrder { get; set; } 

        public new static ClientBilling FromJson(string json)
        {
            return string.IsNullOrEmpty(json)
                ? new ClientBilling()
                : JsonConvert.DeserializeObject<ClientBilling>(json, Json.JsonConverter.Settings);
        }
    }


