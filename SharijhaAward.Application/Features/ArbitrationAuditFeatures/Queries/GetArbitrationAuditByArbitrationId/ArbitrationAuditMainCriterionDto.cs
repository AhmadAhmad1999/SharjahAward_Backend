namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetArbitrationAuditByArbitrationId
{
    public class ArbitrationAuditMainCriterionDto
    {
        public string Title { get; set; } = null!;
        public List<ArbitrationAuditSubCriterionDto> SubCriterionDtos { get; set; } = new List<ArbitrationAuditSubCriterionDto>();
    }
}
