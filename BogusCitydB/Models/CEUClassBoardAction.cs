using Bogus.DataSets;
using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Models
{
    public class CEUClassBoardAction
    {
        public int Id { get; set; }

        //foreign key
        public int CEUClassId { get; set; }
        public int ECEUClassBoardActionId { get; set; }

        [Required]
        [Display(Name = "Class Approval Status")]
        public string? ApprovalStatus { get; set; }

        [Required]
        [Display(Name = "Date Submitted for Approval")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]

        public DateTimeOffset DateSubmitted { get; set; } 

        [Required]
        [Display(Name = "Scheduled To be Considered ")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        // Date the class is scheduled to be considered by the board
        public DateTimeOffset PresentationDate { get; set; }

        [Required]
        [Display(Name = "Date of Board Action ")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        // Date of the decision
        public DateTimeOffset ActionDate { get; set; }

        public string? Comments { get; set; }
    }
}
