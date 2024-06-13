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
        public bool EligibleForCertification { get; set; }
        public bool EligibleForAStatement { get; set; }
        public bool EligibleToWin { get; set; }
        public bool GotCertification { get; set; }
        public bool GotStatement { get; set; }
        public bool Winner { get; set; }
        public DateTime? DateOfObtainingTheCertificate { get; set; }
        public DateTime? DateOfObtainingTheStatement { get; set; }
        public DateTime? WinningDate { get; set; }
    }
}
