using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.AlbumModel
{
    public class Gallery : AuditableEntity
    {
        public int Id { get; set; }
        public string FileUrl { get; set; } = string.Empty;
        public Album Album { get; set; } = null!;
        [ForeignKey(nameof(Album))]
        public int AlbumId { get; set; }
    }
}
