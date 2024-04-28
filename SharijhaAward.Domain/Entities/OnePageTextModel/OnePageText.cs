using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.OnePageText;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Domain.Entities.OnePageTextModel
{
    public class OnePageText : AuditableEntity
    {
        public int Id { get; set; }
        [MaxLength]
        public string? ArabicText { get; set; }
        [MaxLength]
        public string? EnglishText { get; set; }
        public OnePageTextType Type { get; set; }
        public string Slug { get; set; } = null!;
    }
}
