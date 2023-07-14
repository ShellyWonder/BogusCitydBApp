using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Models
{
    public class NotificationType
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Notification Category")]
        public string? Name { get; set; }
    }
}
