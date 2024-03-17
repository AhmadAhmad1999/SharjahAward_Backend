﻿using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel
{
    public class GeneralFrequentlyAskedQuestion : AuditableEntity
    {
        public Guid Id { get; set; }
        public string ArabicQuestion { get; set; } = null!;
        public string EnglishQuestion { get; set; } = null!;
        public string ArabicAnswer { get; set; } = null!;
        public string EnglishAnswer { get; set; } = null!;
        public int GeneralFrequentlyAskedQuestionCategoryId { get; set; }
        public GeneralFrequentlyAskedQuestionCategory? GeneralFrequentlyAskedQuestionCategory { get; set; }
    }
}
