namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllInitialArbitrationOnForm
{
    public class EachArbitrationDto
    {
        public int ArbitrationId { get; set; }
        public List<InitialArbitrationDto> InitialArbitrationDtos { get; set; } = new List<InitialArbitrationDto>();
    }
}
