using Bogus.DataSets;
using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Data.Enums;


public enum ExemptStatus
{
    [Display(Name = "School Instructor")]
    SchoolInstructor,
    [Display(Name = "Plumbing Inspector")]
    PlumbingInspector,
    [Display(Name = "Retired")]
    Retired,
    [Display(Name = "Board Dispensation")]
    BoardDispensation,
    [Display(Name = "Non-Exempt")]
    NonExempt,
    [Display(Name = "Other")]
    Other
}