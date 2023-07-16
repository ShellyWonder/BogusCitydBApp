using Bogus.DataSets;
using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Models.Enums.LicenseeEnums;


public enum EExemptStatus
{
    [Display(Name = "School Instructor")]
    SchoolInstructor,
    [Display(Name = "Plumbing Inspector")]
    PlumbingInspector,
    [Display(Name = "Retired")]
    Retired,
    [Display(Name = "Board Dispensation")]
    BoardDispensation,
    [Display(Name = "Passed License Exam")]
    PassedLicenseExam,
    [Display(Name = "Non-Exempt")]
    NonExempt,
    [Display(Name = "Other")]
    Other
}