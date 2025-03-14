﻿using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Entities.PageStructureModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.PageStructureModels
{
    public class PageCard : AuditableEntity
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public string? EnglishTitle { get; set; } = string.Empty;
        public string? ArabicTitle { get; set; } = string.Empty;
        public string? EnglishContent { get; set; } = string.Empty;
        public string? ArabicContent { get; set; } = string.Empty;
        public string? ImageUrl { get; set; } = string.Empty;
        public bool? ImageInStart { get; set; }
        public bool IsHide { get; set; }
        public CardType CardType { get; set; }
        public PageStructure PageStructure { get; set; } = null!;

        [ForeignKey(nameof(PageStructure))]
        public int PageId { get; set; }

        public int? ParentId { get; set; }
        public PageCard? Parent { get; set; }
    }
}
