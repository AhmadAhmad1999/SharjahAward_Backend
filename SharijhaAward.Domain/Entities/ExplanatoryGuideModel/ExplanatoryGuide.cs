using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.ExplanatoryGuideModel
{
    public class ExplanatoryGuide : AuditableEntity
    {
        public Guid Id { get; set; }
        public string EnglishFile { get; set; } = string.Empty;
        public string ArabicFile { get; set; } = string.Empty;
        public Category Category { get; set; }
        [ForeignKey(nameof(Category))]
        public Guid CategoryId { get; set; }
    }
}
