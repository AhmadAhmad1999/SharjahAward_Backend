using SharijhaAward.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.CircularModel
{
    public class CircularAttachment : AuditableEntity
    {
        public int Id { get; set; }
        public string FileName { get; set; } = null!;
        public string AttachementPath { get; set; } = string.Empty;
        public Circular Circular { get; set; } = null!;
        [ForeignKey(nameof(Circular))]
        public int CircularId { get; set; }
    }
}
