namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetAllArbitrationScales
{
    public class ArbitrationScaleDto
    {
        public int Id { get; set; }
        public string DegreeScale { get; set; } = null!;
        public string ArabicTitle { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
    }
}
