using System.ComponentModel;

namespace ClientAdminSample.AmeriFind;

public enum MultifactorPreference
{
    [Description("Mutifactor not set")] NotSet = -1,
    [Description("Mutifactor disabled")] Disabled = 0,
    [Description("Send a code via email")] Email = 20,
    [Description("Send a code via SMS")] Phone = 30,

    [Description("Prompt for a code from an authenticator app")]
    App = 40
}

public enum NeedsMultifactor
{
    [Description("Not Required Client Override")]
    NotRequiredClientOverride = 0,
    [Description("New IP Address")] NewIpAddress = 1,

    [Description("Email or Mobile Change")]
    EmailOrMobileChange = 2,

    [Description("Over X days from Last Login")]
    OverXDaysFromLastLogin = 3,

    [Description("No Last Multifactor Date")]
    NoLastMultifactorDate = 4,

    [Description("Over 14 days from Last MF")]
    Over14DaysFromLastMf = 5,

    [Description("Max Successful Logins Reached, Time to Re Authenticate")]
    MaxSuccessfulLoginsReached = 6,

    [Description("Time Requires MultiFactor")]
    TimeRequiresMultiFactor = 7,
    [Description("Out of Country IP")] OutOfCountryIp = 8,
    [Description("Force Multifactor")] ForceMultifactor = 99
}