namespace BogusCitydB.Data.Enums
{
    public enum CEUClassStatus

    {
            //CEUClass has received board approval and placed on the calendar        
            Upcoming,
            //CEUClass has been completed, submitted and awaiting checkin approval by the board secretary
            Completed,

            Cancelled,
            //CEUClass has been completed, approved by the board secretary and credited to  licensee participants
            Past

            
    }
}
