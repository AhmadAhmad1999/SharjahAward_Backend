using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetAllFormsForFinalArbitration
{
    public class GetAllFormsForFinalArbitrationListVM
    {
        public int FormId { get; set; }
        public int? DoneArbitrationUserId { get; set; }
        public string? DoneArbitrationUserName { get; set; }
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public float FinalScore { get; set; }
        public DateTime? DateOfArbitration { get; set; }
        public ArbitrationType Type { get; set; } = 0;
        public FormStatus isAcceptedFromChairman { get; set; }
    }
}
