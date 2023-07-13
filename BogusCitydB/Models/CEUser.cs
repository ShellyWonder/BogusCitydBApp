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

        
        [Display(Name = "Street Address")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The {0} must be at least {2} at most {1} characters long."),]
        public string? StreetAddress { get; set; } = null;

        [StringLength(20, MinimumLength = 1, ErrorMessage = "The {0} must be at least {2} at most {1} characters long.")]
        public string? City { get; set; } = null;

        public State State { get; set; }

        [RegularExpression(@"^\d{5}(?:\d{4})?$", ErrorMessage = "Zip Code should be in 5 or 9 number format. Please try again.")]
        [Display(Name = "Zip Code")]
        public string? ZipCode { get; set; }

        [Display(Name= "Date Last Modified")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? LastModified { get; set; } = null;

        [Required]
        [EmailAddress(ErrorMessage = "Please enter a properly formated email. Example: example@yourcompany.com.")]
        [Display(Name = "Email Address")]
        public string? EmailAddress { get; set; }

        [Required]
        [Phone]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must be in the format xxx-xxx-xxxx")]
        public string? Phone { get; set; } = null;
    }
}
