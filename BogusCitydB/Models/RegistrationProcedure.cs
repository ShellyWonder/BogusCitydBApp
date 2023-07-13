using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Models
{
    public class RegistrationProcedure
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Registration Method")]
        public string? Procedure { get; set; }
    }
}
