namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Commands.UpdateArbitrationScale
{
    public class UpdateArbitrationScaleCriterionDto
    {
        public int Id { get; set; }
        public string ArabicDescription { get; set; } = null!;
        public string EnglishDescription { get; set; } = null!;
    }
}
