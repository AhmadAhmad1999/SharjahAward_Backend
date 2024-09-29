namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.UpdateAdvancedFormBuilder
{
    public class UpdateAdvancedFormBuilderValueDto
    {
        public int Id { get; set; }
        public string ArabicValue { get; set; } = null!;
        public string EnglishValue { get; set; } = null!;
    }
}
