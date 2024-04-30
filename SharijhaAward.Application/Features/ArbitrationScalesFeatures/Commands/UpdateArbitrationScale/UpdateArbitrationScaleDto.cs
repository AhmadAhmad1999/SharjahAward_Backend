namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Commands.UpdateArbitrationScale
{
    public class UpdateArbitrationScaleDto
    {
        public int Id { get; set; }
        public string DegreeScale { get; set; } = null!;
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public List<UpdateArbitrationScaleCriterionDto> ArbitrationScaleCriterionDto { get; set; } = new List<UpdateArbitrationScaleCriterionDto>();
    }
}
