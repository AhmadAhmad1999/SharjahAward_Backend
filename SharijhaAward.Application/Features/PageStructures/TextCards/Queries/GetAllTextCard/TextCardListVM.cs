using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.TextCards.Queries.GetAllTextCard
{
    public class TextCardListVM
    {
        public int Id { get; set; }
        public string? EnglishContent { get; set; } = string.Empty;
        public string? ArabicContent { get; set; } = string.Empty;
        public string? Content { get; set; } = string.Empty;
        public int orderId { get; set; }
        public bool IsHide { get; set; }
        public CardType CardType { get; set; }
        public int PageStructureId { get; set; }
    }
}
