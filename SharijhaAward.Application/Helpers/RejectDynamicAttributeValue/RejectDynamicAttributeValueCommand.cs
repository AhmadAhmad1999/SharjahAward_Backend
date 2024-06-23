namespace SharijhaAward.Application.Helpers.RejectDynamicAttributeValue
{
    public class RejectDynamicAttributeValueCommand 
    {
        public int DynamicAttributesId { get; set; }
        public int FormId { get; set; }
        public int? RowId { get; set; }
        public bool isAccepted { get; set; }
        public string? ReasonForRejecting { get; set; }
    }
}
