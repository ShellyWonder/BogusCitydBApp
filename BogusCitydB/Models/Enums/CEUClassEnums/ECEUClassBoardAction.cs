using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Models.Enums.CEUClassEnums
{
    public enum ECEUClassBoardAction
    {
        Pending,
        Approved,
        Denied,
        [Display(Name = "More Information Requested")]
        InformationRequested
    };
}
