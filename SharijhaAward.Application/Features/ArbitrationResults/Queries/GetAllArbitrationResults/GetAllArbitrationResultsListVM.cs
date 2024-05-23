namespace SharijhaAward.Application.Features.ArbitrationResults.Queries.GetAllArbitrationResults
{
    public class GetAllArbitrationResultsListVM
    {
        public int FormId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public List<InitialArbitrationScoreDto> InitialArbitrationScoreDto { get; set; } = new List<InitialArbitrationScoreDto>();
        public float ArbitrationAuditScore { get; set; }
        public float FinalArbitrationScore { get; set; }
        public ArbitrationResultType ArbitrationResultType { get; set; }
    }
}
