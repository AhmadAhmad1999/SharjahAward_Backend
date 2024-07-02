using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.PageStructureModels
{
    public class ImageCard : AuditableEntity
    {
        public int Id { get; set; }

        public List<PageStructureImages> Images { get; set; } = null!;
    }
}
