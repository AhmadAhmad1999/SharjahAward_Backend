namespace SharijhaAward.Application.Features.ArbitrationResults.Queries.GetAllArbitrationResults
{
    public class GetAllArbitrationResultsListVM
    {
        public int FormId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public bool CategoryContainStatement1 { get; set; }
        public bool CategoryContainStatement2 { get; set; }
        public bool CategoryContainCertificate { get; set; }
        public string SubscriberName { get; set; } = null!;
        public int CycleNumber { get; set; }
        public string CycleYear { get; set; } = string.Empty;
        public List<InitialArbitrationScoreDto> InitialArbitrationScoreDto { get; set; } = new List<InitialArbitrationScoreDto>();
        public float ArbitrationAuditScore { get; set; }
        public float FinalArbitrationScore { get; set; }
        public bool EligibleForCertification { get; set; }
        public bool EligibleForAStatement1 { get; set; }
        public bool EligibleForAStatement2 { get; set; }
        public bool EligibleToWin { get; set; }
        public bool GotCertification { get; set; }
        public bool GotStatement1 { get; set; }
        public bool GotStatement2 { get; set; }
        public bool Winner { get; set; }
        public DateTime? DateOfObtainingTheCertificate { get; set; }
        public DateTime? DateOfObtainingTheStatement1 { get; set; }
        public DateTime? DateOfObtainingTheStatement2 { get; set; }
        public DateTime? WinningDate { get; set; }
    }
}
