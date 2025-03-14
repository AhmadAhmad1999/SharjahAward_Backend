﻿using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Queries.GetAllFormsForArbitrationAudit
{
    public class GetAllFormsForArbitrationAuditListVM
    {
        public int FormId { get; set; }
        public int? DoneArbitrationUserId { get; set; }
        public string? DoneArbitrationUserName { get; set; }
        public string Name { get; set; } = null!;
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public bool ItExceededTheMarginOfDifferenceInArbitrationScores { get; set; }
        public float Average { get; set; }
        public float FullScore { get; set; }
        public bool DoneArbitrationAudit { get; set; }
        public ArbitrationType ArbitrationAuditType { get; set; } = 0;
        public DateTime? DateOfArbitrationAuditing { get; set; }
        public FormStatus isAcceptedFromChairmanFromArbitrationAudit { get; set; }
        public string? ReasonForRejectingFromArbitrationAudit { get; set; }
    }
}
