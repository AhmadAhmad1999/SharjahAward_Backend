using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.NewsModel
{
    public class NewsImage : AuditableEntity
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = string.Empty;

        public News News { get; set; } = null!;
        [ForeignKey(nameof(News))]
        public int NewsId { get; set; }
    }
}
