namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Commands.CreateArbitrationScale
{
    public class ArbitrationScaleCriterionDto
    {
        public string ArabicDescription { get; set; } = null!;
        public string EnglishDescription { get; set; } = null!;
        public int? CriterionId { get; set; }
        public int? CriterionItemId { get; set; }
        //public int ArbitrationScaleId { get; set; }
    }
}
