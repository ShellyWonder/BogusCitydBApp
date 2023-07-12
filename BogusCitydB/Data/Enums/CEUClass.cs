namespace BogusCitydB.Data.Enums
{
    public class CEUClass
    {
        public string NameClass { get; set; }
        public string Description { get; set; }
        public int CEUHoursAssigned { get; set; }
        public CEUClassBoardApprovalStatus BoardApprovalStatus { get; set; }
        public CEUClassStatus Status { get; set; }
    }
}
