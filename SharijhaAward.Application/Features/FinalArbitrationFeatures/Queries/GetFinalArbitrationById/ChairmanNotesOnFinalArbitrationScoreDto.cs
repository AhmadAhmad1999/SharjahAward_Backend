namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Queries.GetFinalArbitrationById
{
    public class ChairmanNotesOnFinalArbitrationScoreDto
    {
        public int Id { get; set; }
        public bool isFromArbitrationAudit { get; set; }
        public string Note { get; set; } = null!;
    }
}
