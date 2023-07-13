namespace BogusCitydB.Models.Enums.LicenseeEnums;
using Bogus.DataSets;
using System.ComponentModel.DataAnnotations;


public enum ELicenseStatus
{
    [Display(Name = "Active")]
    Active,
    [Display(Name = "Inactive")]
    Inactive,
    [Display(Name = "Suspended")]
    Suspended,
    [Display(Name = "Revoked")]
    Revoked,
    [Display(Name = "Expired")]
    Expired
}

