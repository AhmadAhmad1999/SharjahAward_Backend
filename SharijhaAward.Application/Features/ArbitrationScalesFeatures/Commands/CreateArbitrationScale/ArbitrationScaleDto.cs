namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Commands.CreateArbitrationScale
{
    public class ArbitrationScaleDto
    {
        public int Id { get; set; }
        public string DegreeScale { get; set; } = null!;
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public List<ArbitrationScaleCriterionDto> ArbitrationScaleCriterionDto { get; set; } = new List<ArbitrationScaleCriterionDto>();
    }
}
