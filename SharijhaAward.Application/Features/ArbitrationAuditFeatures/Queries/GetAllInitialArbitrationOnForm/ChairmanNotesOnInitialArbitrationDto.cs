namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllInitialArbitrationOnForm
{
    public class ChairmanNotesOnInitialArbitrationDto
    {
        public int Id { get; set; }
        public string Note { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public int ChairmanId { get; set; }
        public string ChairmanName { get; set; } = null!;
        public string ChairmanEmail { get; set; } = null!;
    }
}
