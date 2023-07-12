using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Data.Models
{
    public class JourneymanLicensee : Licensee
    {
        //When a Journeyman passes the masters exam, their CEU requirement is dismissed
        //for the remainder of the year the exam is passed 
        public bool PassedMastersExam { get; set; } = false;

        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateOnly DatePassedMasters { get; set; }
    }
}
