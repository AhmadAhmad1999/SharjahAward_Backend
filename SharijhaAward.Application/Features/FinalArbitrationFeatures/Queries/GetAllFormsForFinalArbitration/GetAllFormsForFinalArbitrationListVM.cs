namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetAllFormsForFinalArbitration
{
    public class GetAllFormsForFinalArbitrationListVM
    {
        public int FormId { get; set; }
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public float FinalScore { get; set; }
    }
}
