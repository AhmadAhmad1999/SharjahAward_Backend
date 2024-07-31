using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.PageStructureModel
{
    public class PageStructure : AuditableEntity
    {
        public int Id { get; set; }
        public bool hasHelography { get; set; }
        public string? IconUrl { get; set; }
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string? EnglishSubTitle { get; set; }
        public string? ArabicSubTitle { get; set; }
        public string? EnglishContent { get; set; }
        public string? ArabicContent { get; set; }
        public bool IsHide { get; set; }
        public string Slug { get; set; } = string.Empty;
        public bool Deletable { get; set; }

        public PageStructure pageStructure { get; set; } = null!;
        [ForeignKey(nameof(pageStructure))]
        public int? ParentId { get; set; }

        public List<PageCard>? PageCard { get; set; }
        public List<ImageCard>? ImageCards { get; set; }
    }
}
