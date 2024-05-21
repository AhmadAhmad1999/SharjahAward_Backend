namespace SharijhaAward.Application.Helpers.RejectDynamicAttributeValue
{
    public class RejectDynamicAttributeValueCommand 
    {
        public int DynamicAttributesId { get; set; }
        public bool isAccepted { get; set; }
        public string? ReasonForRejecting { get; set; }
    }
}
