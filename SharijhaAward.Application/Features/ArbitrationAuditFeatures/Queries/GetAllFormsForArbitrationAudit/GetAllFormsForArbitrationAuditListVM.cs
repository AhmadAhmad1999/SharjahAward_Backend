namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllFormsForArbitrationAudit
{
    public class GetAllFormsForArbitrationAuditListVM
    {
        public int FormId { get; set; }
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public bool ItExceededTheMarginOfDifferenceInArbitrationScores { get; set; }
        public float Average { get; set; }
        public float FullScore { get; set; }
    }
}
