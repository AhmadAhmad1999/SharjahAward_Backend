using SharijhaAward.Domain.Common;

namespace SharijhaAward.Domain.Entities.GeneralFrequentlyAskedQuestionModel
{
    public class GeneralFAQCategory : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicName { get; set; } = null!;
        public string EnglishName { get; set; } = null!;
    }
}
