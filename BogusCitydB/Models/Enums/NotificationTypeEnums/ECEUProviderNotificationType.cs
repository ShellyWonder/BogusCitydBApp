using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Models.Enums.NotificationTypeEnums
{
    public enum ECEUProviderNotificationType
    {
        //provider
        [Display(Name = "Certification Renewal")]
        CertificationRenewal,
        [Display(Name = "Provider Status Change")]
        ProviderStatusChange
    }
}
