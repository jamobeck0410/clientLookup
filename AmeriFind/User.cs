using ClientAdminSample.AmeriFind.jBASEApi;
using Newtonsoft.Json;

namespace ClientAdminSample.AmeriFind;

public class User : jBASEApiResponse
{
    [JsonProperty(nameof(Account))] public string Account { get; set; }

    [JsonProperty(nameof(User))] public string Id { get; set; }

    [JsonProperty(nameof(Password))] public string Password { get; set; }

    [JsonProperty(nameof(IsValidated))] public bool IsValidated { get; set; }

    [JsonProperty(nameof(IsActive))] public bool IsActive { get; set; }

    [JsonProperty(nameof(IsTerminated))] public bool IsTerminated { get; set; }

    [JsonProperty(nameof(NeedsMultifactor))]
    public NeedsMultifactor? NeedsMultifactor { get; set; }

    [JsonProperty(nameof(MultifactorDescription))]
    public string MultifactorDescription { get; set; }

    [JsonProperty(nameof(Name))] public string Name { get; set; }

    [JsonProperty(nameof(ClientName))] public string ClientName { get; set; }

    [JsonProperty(nameof(DefaultInquiryCode))]
    public string DefaultInquiryCode { get; set; }

    [JsonProperty(nameof(NavigationOptions))]
    public string NavigationOptions { get; set; }

    [JsonProperty(nameof(LastMultifactorSuccess))]
    public DateTime? LastMultifactorSuccess { get; set; }

    [JsonProperty("VerifyWS")] public bool VerifyWs { get; set; }

    [JsonProperty("VerifyIP")] public bool VerifyIp { get; set; }

    [JsonProperty(nameof(MultifactorPreference))]
    public MultifactorPreference MultifactorPreference { get; set; }

    [JsonProperty(nameof(MobileNumber))] public string MobileNumber { get; set; }

    [JsonProperty(nameof(MobileNumberValidationDate))]
    public DateTime? MobileNumberValidationDate { get; set; }

    [JsonProperty("EmailAddress")] public string EmailAddress { get; set; }

    [JsonProperty("EmailAddressValidationDate")]
    public DateTime? EmailAddressValidationDate { get; set; }

    [JsonProperty("MultifactorAppSecret")] public string MultifactorAppSecret { get; set; }

    [JsonProperty(nameof(MultifactorOverride))]
    public bool MultifactorOverride { get; set; }

    [JsonProperty(nameof(MultifactorToken))]
    public string MultifactorToken { get; set; }

    [JsonProperty(nameof(MultifactorTokenDateTimeStamp))]
    public DateTime? MultifactorTokenDateTimeStamp { get; set; }

    [JsonProperty(nameof(PasswordLastChangeDate))]
    public DateTime? PasswordLastChangeDate { get; set; }

    [JsonProperty(nameof(PasswordResetToken))]
    public string PasswordResetToken { get; set; }

    [JsonProperty(nameof(PasswordResetTokenDateTimeStamp))]
    public DateTime? PasswordResetTokenDateTimeStamp { get; set; }

    [JsonProperty(nameof(PasswordOverrideDateTimeStamp))]
    public DateTime? PasswordOverrideDateTimeStamp { get; set; }

    [JsonProperty(nameof(EmailValidationToken))]
    public string EmailValidationToken { get; set; }

    [JsonProperty(nameof(EmailValidationTokenDateTimeStamp))]
    public DateTime? EmailValidationTokenDateTimeStamp { get; set; }

    [JsonProperty(nameof(MultifactorBypassCookieMaxAge))]
    public int MultifactorBypassCookieMaxAge { get; set; }

    public new static User FromJson(string json)
    {
        return string.IsNullOrEmpty(json)
            ? new User()
            : JsonConvert.DeserializeObject<User>(json, Json.JsonConverter.Settings);
    }
}