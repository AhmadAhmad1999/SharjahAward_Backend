namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetAllFinalArbitration
{
    public class GetAllFinalArbitrationListVM
    {
        public int FormId { get; set; }
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public float ArbitrationAuditScore { get; set; }
        public float FinalScore { get; set; }
    }
}
