namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Commands.CreateArbitrationScale
{
    public class ArbitrationScaleCriterionDto
    {
        public int Id { get; set; }
        public string ArabicDescription { get; set; } = null!;
        public string? EnglishDescription { get; set; } = "No Value";
        public int? CriterionId { get; set; }
        public int? CriterionItemId { get; set; }
        //public int ArbitrationScaleId { get; set; }
    }
}
