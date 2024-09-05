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
    public class ImageCard : AuditableEntity
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public bool IsHide { get; set; }
        public List<PageStructureImages> Images { get; set; } = null!;
        public PageStructure PageStructure { get; set; } = null!;

        [ForeignKey(nameof(PageStructure))]
        public int PageId { get; set; }

        //public List<PageStructureImages> Images { get; set; } = null!;
    }
}
