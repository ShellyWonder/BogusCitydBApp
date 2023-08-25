using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Data.Models
{
    public partial class ProviderUser : CEUser
    {
        
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Business name must be between 1 and 50 characters long.")]
        [Display(Name = "Business")]
        public string BusinessName { get; set; } = null!;   

        [Url(ErrorMessage = "Not a valid website URL. Please enter a valid website address.")]
        public string? Website { get; set; }

        public bool IsActive { get; set; } = true;
 
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [Display(Name = "Date of Board Certification")]
        //initial date of board certification; used to determine when to renew
        public DateTimeOffset DateOfBoardCertification { get; set; }
        public int InterimRenewalPeriod { get; set; } = 0;

       
        
        public virtual ICollection<CEUClass>? AllClassesByProvider { get; set; } = new HashSet<CEUClass>();
        public virtual ICollection<LicenseeUser>? LicenseesByProvider { get; set;} = new HashSet<LicenseeUser>();
        public virtual ICollection<CEUClass>? ClassesByLicenseType { get; set; } = new HashSet<CEUClass>();
    }

}
