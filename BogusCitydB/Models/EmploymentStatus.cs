using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Models
{
    public class EmploymentStatus
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Employment Status")]
        public string? Status { get; set; }
    }
}
