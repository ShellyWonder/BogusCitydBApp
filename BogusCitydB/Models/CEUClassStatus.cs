using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Models
{
    public class CEUClassStatus
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Class Status")]
        public string? Status { get; set; }
    }
}
