using Bogus.DataSets;
using BogusCitydB.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Data.Models
{
    public class CEUser

    {
        [StringLength(20, MinimumLength = 1, ErrorMessage = "First name must be between 1 and 20 characters long.")]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [StringLength(25, MinimumLength = 2, ErrorMessage = "Last name must be between 2 and 25 characters long.")]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [NotMapped]
        [Display(Name = "Full Name")]
        public string? FullName { get { return $"{FirstName} {LastName}"; } set { } }

        [Display(Name = "Street Address")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Street address must be 5 to 50 characters long"),]
        public string? StreetAddress { get; set; } = null;

        [StringLength(20, MinimumLength = 1, ErrorMessage = "City name must be between 1 and 20 characters long.")]
        public string? City { get; set; } = null;

        public State State { get; set; }

        [RegularExpression(@"^\d{5}(?:\d{4})?$", ErrorMessage = "Zip Code should be in 5 or 9 number format. Please try again.")]
        public string? ZipCode { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? LastModified { get; set; } = null;

        [EmailAddress(ErrorMessage = "Please enter a properly formated email. Example: example@yourcompany.com.")]
        [Display(Name = "Email Address")]
        public string? EmailAddress { get; set; }

        [Phone]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must be in the format xxx-xxx-xxxx")]
        public string? Phone { get; set; } = null;
    }
}
