using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetArbitrationAuditByArbitrationId
{
    public class GetArbitrationAuditByArbitrationIdResponse
    {
        public List<ArbitrationAuditMainCriterionDto> MainCriterionDtos { get; set; } = new List<ArbitrationAuditMainCriterionDto>();
        public bool isChairman { get; set; }
        public bool isItHisForm { get; set; }
        public string? ReasonForRejecting { get; set; }
        public FormStatus isAcceptedFromChairman { get; set; }
    }
}
