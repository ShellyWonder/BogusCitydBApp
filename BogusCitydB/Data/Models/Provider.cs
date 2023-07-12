using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Data.Models
{
    public class Provider : CEUser
    {
        public int Id { get; set; }

        [Url(ErrorMessage = "Not a valid website URL. Please enter a valid website address.")]
        public string? Website { get; set; }

        public bool IsActive { get; set; } = false;

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateOnly BoardCertificationRenewalDate { get; set; }
    }
}
