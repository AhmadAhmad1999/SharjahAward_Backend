using SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetAllArbitrationScales;

namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Queries.GetArbitrationScaleById
{
    public class GetArbitrationScaleByIdListVM
    {
        public List<ArbitrationScaleDto> ArbitrationScaleDto { get; set; } = new List<ArbitrationScaleDto>();
    }
}
