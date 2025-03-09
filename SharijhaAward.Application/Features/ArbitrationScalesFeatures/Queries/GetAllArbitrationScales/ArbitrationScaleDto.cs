namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetAllArbitrationScales
{
    public class ArbitrationScaleDto
    {
        public int Id { get; set; }
        public string DegreeScale { get; set; } = null!;
        public string ArabicTitle { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string EnglishTitle { get; set; } = null!;
        public string ArabicDescription { get; set; } = null!;
        public string EnglishDescription { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
