namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.CreateArbitrationAudit
{
    public class ArbitrationAuditMainCommand
    {
        public int ArbitrationAuditId { get; set; }
        public int? CriterionId { get; set; }
        public int? CriterionItemId { get; set; }
        public string? StrengthPoint { get; set; }
        public string? ImprovementAreas { get; set; }
        public int? ArbitrationScore { get; set; }
    }
}
