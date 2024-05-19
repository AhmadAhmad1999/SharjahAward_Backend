﻿using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.ArbitratorModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;

namespace SharijhaAward.Domain.Entities.FinalArbitrationModel
{
    public class FinalArbitration : AuditableEntity
    {
        public int Id { get; set; }
        public float FinalScore { get; set; }
        public int ProvidedFormId { get; set; }
        public ProvidedForm? ProvidedForm { get; set; }
        public int ArbitratorId { get; set; }
        public Arbitrator? Arbitrator { get; set; }
        public int? ParentId { get; set; }
        public FinalArbitration? Parent { get; set; }
        public bool? isAcceptedFromChairman { get; set; }
        public string? ReasonForRejecting { get; set; }
    }
}
