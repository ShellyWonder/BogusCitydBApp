using Bogus.DataSets;
using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Models
{
    public class CEUClassBoardApprovalStatus
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Class Approval Status")]
        public string? Status { get; set; }
    }
}
