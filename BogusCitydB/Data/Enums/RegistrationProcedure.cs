using Bogus.DataSets;
using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Data.Enums
{
    public enum RegistrationProcedure

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
