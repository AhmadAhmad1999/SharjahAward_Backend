using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllInitialArbitrationOnForm
{
    public class GetAllInitialArbitrationOnFormListVM
    {
        public int Id { get; set; }
        public int ArbitratorId { get; set; }
        public string ArbitratorName { get; set; } = null!;
        public ArbitrationType Type { get; set; } = 0;
        public List<InitialArbitrationDto> InitialArbitrationDtos { get; set; } = new List<InitialArbitrationDto>();
    }
}
