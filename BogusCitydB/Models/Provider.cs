using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Data.Models
{
    public class Provider : CEUser 
    {
        
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Business name must be between 1 and 50 characters long.")]
        [Display(Name = "Business")]
        public string BusinessName { get; set; } = null!;   

        [Url(ErrorMessage = "Not a valid website URL. Please enter a valid website address.")]
        public string? Website { get; set; }

        public bool IsActive { get; set; } = true;

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTimeOffset BoardCertificationRenewalDate { get; set; }

       
        
        public virtual ICollection<CEUClass>? AllClassesByProvider { get; set; } = new HashSet<CEUClass>();
        public virtual ICollection<Licensee>? LicenseesByProvider { get; set;} = new HashSet<Licensee>();
        public virtual ICollection<CEUClass>? ClassesByLicenseType { get; set; } = new HashSet<CEUClass>();
    }

}
