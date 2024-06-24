using SharijhaAward.Domain.Constants;

namespace SharijhaAward.Application.Features.WinnersFeatures.Queries.GetWinnersByLevel
{
    public class GetWinnersByLevelListVM
    {
        public int FormId { get; set; }
        public string SubscriberName { get; set; } = null!;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public int CycleNumber { get; set; }
        public string CycleYear { get; set; } = null!;
        public string? EducationalClassName { get; set; }
        public string? EducationalEntityName { get; set; }
        public string? ProfilePhoto { get; set; }
        public Gender Gender { get; set; }
        public int WinningLevel { get; set; }
        public float InitialArbitrationScore { get; set; }
        public float ArbitrationAuditScore { get; set; }
        public float FinalArbitrationScore { get; set; }
    }
}
