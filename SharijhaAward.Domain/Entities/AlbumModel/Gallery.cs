using SharijhaAward.Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

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
