using Bogus.DataSets;
using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Models.Enums.CEUClassEnums
{
    public enum ERegistrationProcedure

    {
        [Display(Name = "Website")]
        ProviderWebsite,
        [Display(Name = "Email")]
        ProviderEmail,
        [Display(Name = "Phone")]
        ProviderPhone,
        [Display(Name = "Mail")]
        ProviderMail,
        [Display(Name = "Register at the Door")]
        ProviderInPerson,
        [Display(Name = "Contact Provider")]
        ProviderOther
    }
}
