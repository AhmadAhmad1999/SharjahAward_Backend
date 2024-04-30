namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetAllArbitrationScales
{
    public class ArbitrationScaleCriterionDto
    {
        public int Id { get; set; }
        public string ArabicDescription { get; set; } = null!;
        public string EnglishDescription { get; set; } = null!;
        public int? CriterionId { get; set; }
        public int? CriterionItemId { get; set; }
        public int ArbitrationScaleId { get; set; }
    }
}
