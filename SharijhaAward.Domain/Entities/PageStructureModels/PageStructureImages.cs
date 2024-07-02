using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.PageStructureModels
{
    public class PageStructureImages : AuditableEntity
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        public ImageCard ImageCard { get; set; } = null!;
        [ForeignKey(nameof(ImageCard))]
        public int ImageId { get; set; }
    }
}
