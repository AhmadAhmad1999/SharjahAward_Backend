using SharijhaAward.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace SharijhaAward.Domain.Entities.InstructionModel
{
    public class Instruction : AuditableEntity
    {
        public int Id { get; set; }
        public string Slug { get; set; } = null!;
        public string Title { get; set; } = null!;
        [MaxLength]
        public string? Content { get; set; }
    }
}
