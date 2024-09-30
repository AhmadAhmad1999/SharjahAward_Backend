namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Queries.GetInitialArbitrationByArbitrationId
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
