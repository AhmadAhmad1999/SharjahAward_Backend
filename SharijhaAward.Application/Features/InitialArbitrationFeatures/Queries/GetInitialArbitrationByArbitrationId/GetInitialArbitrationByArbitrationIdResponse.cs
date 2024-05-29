namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId
{
    public class GetInitialArbitrationByArbitrationIdResponse
    {
        public List<MainCriterionDto> MainCriterionDtos { get; set; } = new List<MainCriterionDto>();
        public bool isChairman { get; set; }
        public bool isItHisForm { get; set; }
        public string? ReasonForRejecting { get; set; }
        public bool? isAcceptedFromChairman { get; set; }
    }
}
