﻿namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.CreateFinalArbitrationScore
{
    public class CreateFinalArbitrationScoreMainCommand
    {
        public int FinalArbitrationScoreId { get; set; }
        public int? CriterionId { get; set; }
        public int? CriterionItemId { get; set; }
        public string? StrengthPoint { get; set; }
        public string? ImprovementAreas { get; set; }
        public int ArbitrationScore { get; set; }
    }
}
