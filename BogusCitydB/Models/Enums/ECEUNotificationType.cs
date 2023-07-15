using Bogus.DataSets;
using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Models.Enums
{
    public enum ECEUNotificationType
    {
        [Display(Name = "Board Action")]
        BoardAction,
        [Display(Name = "License Renewal")]
        CertificationRenewal,
        [Display(Name = "Class Status Change ")] 
        CEUClassStatusChange,
        [Display(Name = "Class Proposal Submission Received  ")] 
        ProposalReceived,
        [Display( Name = "Completed Class Submission Received")] 
        CompletedClassReceived,
        [Display(Name ="Completed Class Accepted")]
        CompletedClassAccepted,
        [Display(Name = "Completed Class Denied")] 
        CompletedClassDenied,
        [Display(Name = "License Status Change")] 
        LicenseStatusChange,
        [Display(Name = "Completed Hours Update")]
        CompleteCEUHoursUpdate,
        [Display(Name = "Provider Status Change")]
        ProviderStatusChange,
        [Display(Name = "Completed Hours Update")]
        CEUHoursNeededToDateUpdate,
        [Display(Name = "Change of License")]
        LicenseTypeChange,
        [Display(Name = "Exempt Status Change")]
        ExemptStatusChange,
        [Display(Name = "Class Added to Calendar")]
        CEUClassAdded,
        [Display(Name = "Notice of Delinquent CEU Hours")]
        CEUHoursDelinquency


    }
}
