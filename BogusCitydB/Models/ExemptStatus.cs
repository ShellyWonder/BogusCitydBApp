using BogusCitydB.Models.Enums.LicenseeEnums;
using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Data.Models
{
    public class ExemptStatus
    {
        public int Id { get; set; }

        [Display(Name = " CEU Exempt Status")]
        public string? Status { get; set; }
    }
}
