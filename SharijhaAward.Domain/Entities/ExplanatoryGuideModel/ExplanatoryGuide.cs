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
        public int Id { get; set; }
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishFilePath { get; set; } = string.Empty;
        public string ArabicFilePath { get; set; } = string.Empty;
        public Category Category { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
    }
}
