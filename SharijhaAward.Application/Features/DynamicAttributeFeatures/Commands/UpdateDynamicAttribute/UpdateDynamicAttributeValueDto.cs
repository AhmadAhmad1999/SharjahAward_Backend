namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.UpdateDynamicAttribute
{
    public class UpdateDynamicAttributeValueDto
    {
        public int Id { get; set; }
        public string ArabicValue { get; set; } = null!;
        public string EnglishValue { get; set; } = null!;
    }
}
