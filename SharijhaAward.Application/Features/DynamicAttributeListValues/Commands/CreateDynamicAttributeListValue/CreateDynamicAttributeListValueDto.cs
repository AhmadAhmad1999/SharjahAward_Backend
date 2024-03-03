namespace SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.CreateDynamicAttributeListValue
{
    public class CreateDynamicAttributeListValueDto
    {
        public int Id { get; set; }
        public string Value { get; set; } = null!;
        public int DynamicAttributeId { get; set; }
    }
}
