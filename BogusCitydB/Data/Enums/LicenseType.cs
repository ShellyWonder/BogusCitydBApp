using Bogus.DataSets;
using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Data.Enums;

public enum LicenseType
{
    [Display(Name = "Sewer Layer")]
    SewerLayer,
    [Display(Name = "Journeyman Plumber")]
    JourneymanPlumber,
    [Display(Name = "Master Plumber")]
    MasterPlumber,
    [Display(Name = "Water Conditioner")]
    WaterConditioner,
    [Display(Name = "Lawn Sprinklers")]
    LawnSprinklers
}

