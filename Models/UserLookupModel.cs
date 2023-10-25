using System.ComponentModel.DataAnnotations;

namespace ClientAdminSample.Models;

public class UserLookupModel
{
    [Required]
    [Display(Name = "Account Number")]
    [Range(10000, 99999, ErrorMessage = "Account number value is invalid.")]
    [RegularExpression(@"^(10000|([1-9][0-9]{4})|99999)$", ErrorMessage = "Account number must be 5 digits.")]
    public string AccountNumber { get; set; }

    [Required]
    [Display(Name = "User ID")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "User ID format is invalid.")]
    [RegularExpression(@"^[a-zA-Z0-9]{1,50}$", ErrorMessage = "User ID must be only alphanumeric characters.")]
    public string UserId { get; set; }
}