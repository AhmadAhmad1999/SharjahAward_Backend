using SharijhaAward.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Domain.Entities.ExplanatoryMessageModel
{
    public class ExplanatoryMessage : AuditableEntity
    {
        public int Id { get; set; }
        [MaxLength]
        public string ArabicText { get; set; } = null!;
        [MaxLength]
        public string EnglishText { get; set; } = null!;
        public TypeOfExplantoryMessage Type { get; set; }
    }
}
