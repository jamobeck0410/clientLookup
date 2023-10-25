using System.ComponentModel.DataAnnotations;

namespace ClientAdminSample.Models;

public class ClientLookupModel
{
    [MaxLength(50, ErrorMessage = "Full Name is too long")]
    public string?  Name { get; set; }

    [RegularExpression(@"(?<!\d)\d{5}(?!\d)", ErrorMessage = "You entered an invalid Client Number")]
    public string? ClientNumber { get; set; }
}
