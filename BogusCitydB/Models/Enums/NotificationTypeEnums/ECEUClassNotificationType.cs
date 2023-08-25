using System.ComponentModel.DataAnnotations;

namespace BogusCitydB.Models.Enums.NotificationTypeEnums
{
    public enum ECEUClassNotificationType
    {
        [Display(Name = "Class Proposal Submission Received  ")]
        ProposalReceived,
        [Display(Name = "Class Status Change ")]
        CEUClassStatusChange,
        [Display(Name = "Class Added to Calendar")]
        CEUClassAdded,
        [Display(Name = "Class Check in Due Now")]
        CheckInDue,
        [Display(Name = "Completed Class Submission Received")]
        CompletedClassReceived,
        [Display(Name = "Class Check In Complete ")]
        CheckedIn
    }
}
