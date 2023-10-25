using ClientAdminSample.AmeriFind.jBASEApi;
using global::ClientAdminSample.AmeriFind.jBASEApi;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace ClientAdminSample.AmeriFind;

public class OnHold : jBASEApiResponse
{
    [JsonProperty(nameof(CompanyName))] public string CompanyName { get; set; }
    [JsonProperty(nameof(InvContactName))] public string InvContactName { get; set; }
    [JsonProperty(nameof(InvContactEmail))] public string InvContactEmail { get; set; }
    [JsonProperty(nameof(RepContactName))] public string RepContactName { get; set; }
    [JsonProperty(nameof(RepContactEmail))] public string RepContactEmail { get; set; }
    [JsonProperty(nameof(PrimaryName))] public string PrimaryName { get; set; }
    [JsonProperty(nameof(PrimaryTitle))] public string PrimaryTitle { get; set; }
    [JsonProperty(nameof(PrimaryEmail))] public string PrimaryEmail { get; set; }
    [JsonProperty(nameof(WebAddress))] public string WebAddress { get; set; }
    [JsonProperty(nameof(PrimaryPhone))] public string PrimaryPhone { get; set; }
    [JsonProperty(nameof(ContactFax))] public string ContactFax { get; set; }
    [JsonProperty(nameof(OfficePhone))] public string OfficePhone { get; set; }
    [JsonProperty(nameof(OfficeFax))] public string OfficeFax { get; set; }
    [JsonProperty(nameof(IndustryType))] public string IndustryType { get; set; }
    [JsonProperty(nameof(BusinessLicense))] public string BusinessLicense { get; set; }
    [JsonProperty(nameof(ProfLicense))] public string ProfLicense { get; set; }
    [JsonProperty(nameof(SESymbol))] public string SESymbol { get; set; }
    [JsonProperty(nameof(FDICNCHA))] public string FDICNCHA { get; set; }
    [JsonProperty(nameof(LicenseState))] public string LicenseState { get; set; }
    [JsonProperty(nameof(BusinessType))] public string BusinessType { get; set; }
    [JsonProperty(nameof(PrincipleName))] public string PrincipleName { get; set; }
    [JsonProperty(nameof(PrincipleTitle))] public string PrincipleTitle { get; set; }
    [JsonProperty(nameof(TaxIDType))] public string TaxIDType { get; set; }
    [JsonProperty(nameof(TaxIDSSN))] public string TaxIDSSN { get; set; }
    [JsonProperty(nameof(TaxEINITIN))] public string TaxEINITIN { get; set; }
    [JsonProperty(nameof(Referrals))] public string Referrals { get; set; }
    [JsonProperty(nameof(RefFullName))] public string RefFullName { get; set; }
    [JsonProperty(nameof(ShowName))] public string ShowName { get; set; }
    [JsonProperty(nameof(RefOther))] public string RefOther { get; set; }
    [JsonProperty(nameof(BusinessUseType))] public string BusinessUseType { get; set; }
    [JsonProperty(nameof(InvoiceEmail))] public string InvoiceEmail { get; set; }
    [JsonProperty(nameof(AgreeType))] public string AgreeType { get; set; }
    [JsonProperty(nameof(UsersName))] public string UsersName { get; set; }
    [JsonProperty(nameof(UserEmail))] public string  UserEmail { get; set; }
    [JsonProperty(nameof(UserPhone))] public string UserPhone { get; set; }
    [JsonProperty(nameof(UserAccessLvl))] public string UserAccessLvl { get; set; }
    [JsonProperty(nameof(UserID))] public string UserID { get; set; }
    [JsonProperty(nameof(DeptCode))] public string DeptCode { get; set; }
    [JsonProperty(nameof(ClientProfile))] public string ClientProfile { get; set; }
    [JsonProperty(nameof(PaymentProfile))] public string PaymentProfile { get; set; }
    [JsonProperty(nameof(PaymentType))] public string PaymentType { get; set; }
    [JsonProperty(nameof(PaymentMode))] public string PaymentMode { get; set; }
    [JsonProperty(nameof(PhysicalAddress))] public string PhysicalAddress { get; set; }
    [JsonProperty(nameof(PhysicalCity))] public string PhysicalCity { get; set; }
    [JsonProperty(nameof(PhysicalST))] public string PhysicalST { get; set; }
    [JsonProperty(nameof(PhysicalZIP))] public string PhysicalZIP { get; set; }
    [JsonProperty(nameof(BillingPhysical))] public string BillingPhysical { get; set; }
    [JsonProperty(nameof(BillingAddress))] public string BillingAddress { get; set; }
    [JsonProperty(nameof(BillingCity))] public string BillingCity { get; set; }
    [JsonProperty(nameof(BillingST))] public string BillingST { get; set; }
    [JsonProperty(nameof(BillingZIP))] public string BillingZIP { get; set; }
    [JsonProperty(nameof(ApplicantName))] public string ApplicantName { get; set; }
    [JsonProperty(nameof(CompanyName2))] public string CompanyName2 { get; set; }
    [JsonProperty(nameof(AgreeDisclaimer))] public string AgreeDisclaimer { get; set; }
    [JsonProperty(nameof(AgreeDisclaimer2))] public string AgreeDisclaimer2 { get; set; }
    [JsonProperty(nameof(ApplicantName2))] public string ApplicantName2 { get; set; }
    [JsonProperty(nameof(ApplicantTitle))] public string ApplicantTitle { get; set; }
    [JsonProperty(nameof(ApplicantDate))] public string ApplicantDate { get; set; }
    [JsonProperty(nameof(AddressType))] public string AddressType { get; set; }
    [JsonProperty(nameof(LicenseAttached))] public string LicenseAttached { get; set; }
    [JsonProperty(nameof(SubscriberNumber))] public string SubscriberNumber { get; set; }
    [JsonProperty(nameof(IndustryOther))] public string IndustryOther { get; set; }
    [JsonProperty(nameof(CorpNumber))] public string CorpNumber { get; set; }
    [JsonProperty(nameof(CorpST))] public string CorpST { get; set; }

    public new static OnHold FromJson(string json)
    {
        return string.IsNullOrEmpty(json)
            ? new OnHold()
            : JsonConvert.DeserializeObject<OnHold>(json, Json.JsonConverter.Settings);
    }
}
