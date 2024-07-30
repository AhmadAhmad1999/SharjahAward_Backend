using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.PageStructureModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.PageStructureModels
{
    public class DarkCard : AuditableEntity
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishContent { get; set; } = string.Empty;
        public string ArabicContent { get; set; } = string.Empty;
        public bool IsHide { get; set; }
        public PageStructure PageStructure { get; set; } = null!;

        [ForeignKey(nameof(PageStructure))]
        public int PageId { get; set; }
    }
}
