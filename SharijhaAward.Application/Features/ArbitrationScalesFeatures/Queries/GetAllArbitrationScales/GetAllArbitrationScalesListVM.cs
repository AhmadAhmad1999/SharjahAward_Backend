namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetAllArbitrationScales
{
    public class GetAllArbitrationScalesListVM
    {
        public List<MainCriterionDto> MainCriterionDto { get; set; } = new List<MainCriterionDto>();
        public List<ArbitrationScaleDto> ArbitrationScaleDto { get; set; } = new List<ArbitrationScaleDto>();
    }
}
