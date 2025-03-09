using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetArbitrationAuditByArbitrationId
{
    public class GetArbitrationAuditByArbitrationIdResponse
    {
        public List<ArbitrationAuditMainCriterionDto> MainCriterionDtos { get; set; } = new List<ArbitrationAuditMainCriterionDto>();
        public bool isChairman { get; set; }
        public bool isItHisForm { get; set; }
        public bool isDoneArbitration { get; set; }
        public string? ReasonForRejectingFromArbitrationAudit { get; set; }
        public FormStatus isAcceptedFromChairmanFromArbitrationAudit { get; set; }
        public int? DoneArbitrationUserId { get; set; }
        public string? DoneArbitrationUserName { get; set; }
        public string SubscriberName { get; set; } = null!;
        public List<ChairmanNotesOnInitialArbitrationDto> ChairmanNotesOnArbitrationAuditDtos { get; set; } = new List<ChairmanNotesOnInitialArbitrationDto>();
    }
}
