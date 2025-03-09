using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllInitialArbitrationOnForm
{
    public class GetAllInitialArbitrationOnFormListVM
    {
        public int ArbitratorId { get; set; }
        public string ArbitratorName { get; set; } = null!;
        public ArbitrationType Type { get; set; } = 0;
        public List<EachArbitrationDto> AllinitialArbitrationDtos = new List<EachArbitrationDto>();
    }
}
