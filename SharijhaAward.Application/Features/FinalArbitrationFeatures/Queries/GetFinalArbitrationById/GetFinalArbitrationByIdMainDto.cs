using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetFinalArbitrationById
{
    public class GetFinalArbitrationByIdMainDto
    {
        public int FinalArbitrationId { get; set; }
        public bool isChairman { get; set; }
        public bool isDoneArbitration { get; set; }
        public string? ReasonForRejecting { get; set; }
        public FormStatus isAcceptedFromChairman { get; set; }
        public int? DoneArbitrationUserId { get; set; }
        public string? DoneArbitrationUserName { get; set; }
        public string SubscriberName { get; set; } = null!;
        public List<MainCriterionForFinalArbitrationScoreDto> MainCriterions { get; set; } = new List<MainCriterionForFinalArbitrationScoreDto>();
        public List<ChairmanNotesOnFinalArbitrationScoreDto> ChairmanNotesOnFinalArbitrationScoreDtos { get; set; } = new List<ChairmanNotesOnFinalArbitrationScoreDto>();
    }
}
