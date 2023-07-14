using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using BogusCitydB.Models.Enums;
using BogusCitydB.Data.Models;

namespace BogusCitydB.Models
{
    public class Notification
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Title")]
        public string? Title { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string? Message { get; set; }

        [Display(Name = "Created Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTimeOffset? CreatedDate { get; set; }

        [Required]
        [Display(Name="Sender")]
        public string? SenderId { get; set; }

        [Display(Name="Has Been Viewed")]
        public bool? Viewed { get; set; }

        [Required]
        public int NotificationTypeId { get; set; }

        public virtual CEUNotificationType? NotificationType { get; set; }

        public virtual CEUser? Sender { get; set; }
        public virtual CEUser? Recipient { get; set; }

    }
}
