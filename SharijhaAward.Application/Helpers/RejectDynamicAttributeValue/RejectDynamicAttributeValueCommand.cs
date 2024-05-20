namespace SharijhaAward.Application.Helpers.RejectDynamicAttributeValue
{
    public class RejectDynamicAttributeValueCommand 
    {
        public int DynamicAttributesId { get; set; }
        public string ReasonForRejecting { get; set; } = null!;
    }
}
