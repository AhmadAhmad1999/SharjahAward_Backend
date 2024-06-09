using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.AlbumModel
{
    public class Album : AuditableEntity
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;
        public Cycle Cycle { get; set; } = null!;
        [ForeignKey(nameof(Cycle))]
        public int CycleId { get; set; }

        public virtual List<Gallery> Galleries { get; set; } = null!;

    }
}
