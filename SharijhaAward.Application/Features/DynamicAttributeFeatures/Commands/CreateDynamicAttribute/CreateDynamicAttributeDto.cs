namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.CreateDynamicAttribute
{
    public class CreateDynamicAttributeDto
    {
        public int Id { get; set; }
        public string EnglishLabel { get; set; } = null!;
        public string ArabicLabel { get; set; } = null!;
    }
}
