using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BogusCitydB.Data.Models
{
    public class RequiredHoursbyLicenseType

    {
        public int Id { get; set; }

        //add foreign key attribute to relate to the enum values
        [ForeignKey(nameof(LicenseTypeId))]
        public int LicenseTypeId { get; set; }
        public int RequiredHours { get; set; }

        public int TotalHoursToDate { get; set; }
        public int RemainingHours { get; set; }

        // hours remaining from the previous year
        public int CarryOverHours { get; set; }

        public int PenaltyHours { get; set; }

        //hours foregiven by the board
        public int foregivenHours { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateOnly HoursResetDate { get; set; }//Date hours reset to O(currently 01/01 every year) if Total hours to date => required hours

    }
}
