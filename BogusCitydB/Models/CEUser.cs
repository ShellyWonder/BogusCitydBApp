using Bogus.DataSets;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BogusCitydB.Models.Enums;

namespace BogusCitydB.Data.Models
{
    public class CEUser : IdentityUser

    {
        [Required]
        [StringLength(20, MinimumLength = 1, ErrorMessage = "\"The {0} must be at least {2} at most {1} characters long.\"")]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "\"The {0} must be at least {2} at most {1} characters long.\"")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [NotMapped]
        [Display(Name = "Full Name")]
        public string? FullName { get { return $"{FirstName} {LastName}"; } }

        [Display(Name= "Date Last Modified")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTimeOffset? DateModified { get; set; } = null;

        [Display(Name = "Date Created")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTimeOffset? DateCreated { get; set; } = null;

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a properly formatted email. Example: example@yourcompany.com.")]
        [Display(Name = "Email Address")]
        public string? EmailAddress { get; set; }

        [Required]
        [Phone]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must be in the format xxx-xxx-xxxx")]
        public string? Phone { get; set; } = null;
    }
}
