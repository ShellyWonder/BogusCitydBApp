using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Data.Models
{
    public class LicenseType
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "License Type")]
        public string? Name { get; set; }
    }
}
