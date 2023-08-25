using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Models.Enums.NotificationTypeEnums
{
    public enum ECEULicenseeNotificationType
    {
        //change of License Status(Active, Inactive, Retired, )
        [Display(Name = "License Status Change")]
        LicenseStatusChange,
        [Display(Name = "Completed Hours Update")]
        CompleteCEUHoursUpdate,
        [Display(Name = "Hours Needed to Date")]
        CEUHoursNeededToDate,
        //applicable when Journeyman passes exam and becomes Master
        [Display(Name = "Change of License")]
        LicenseTypeChange,
        [Display(Name = "Exempt Status Change")]
        ExemptStatusChange,
        [Display(Name = "Notice of Delinquent CEU Hours")]
        CEUHoursDelinquency
    }
}
