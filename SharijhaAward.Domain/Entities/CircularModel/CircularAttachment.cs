using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.CircularModel
{
    public class CircularAttachment : AuditableEntity
    {
        public int Id { get; set; }
        public string AttachementPath { get; set; } = string.Empty;
        public Circular Circular { get; set; } = null!;
        [ForeignKey(nameof(Circular))]
        public int CircularId { get; set; }
    }
}
