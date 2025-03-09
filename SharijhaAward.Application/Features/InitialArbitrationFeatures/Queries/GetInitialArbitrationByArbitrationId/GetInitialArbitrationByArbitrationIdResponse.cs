using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId
{
    public class GetInitialArbitrationByArbitrationIdResponse
    {
        public List<MainCriterionDto> MainCriterionDtos { get; set; } = new List<MainCriterionDto>();
        public bool isChairman { get; set; }
        public bool isItHisForm { get; set; }
        public string? ReasonForRejecting { get; set; }
        public FormStatus isAcceptedFromChairman { get; set; }
        public bool isDoneArbitration { get; set; }
        public string SubscriberName { get; set; } = null!;
        public List<ChairmanNotesOnInitialArbitrationDto> NotesOnInitialArbitrationDtos { get; set; } = new List<ChairmanNotesOnInitialArbitrationDto>();
    }
}
