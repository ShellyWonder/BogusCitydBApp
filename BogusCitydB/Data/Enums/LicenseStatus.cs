namespace BogusCitydB.Data.Enums;
using Bogus.DataSets;
using System.ComponentModel.DataAnnotations;    


    public enum LicenseStatus
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

