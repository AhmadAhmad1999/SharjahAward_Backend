using SharijhaAward.Domain.Entities.PageStructureModels;

namespace SharijhaAward.Application.Features.PageStructures.ParagraphCards.Queries.GetAllParagraphCardsByPageId
{
    public class ParagraphCardListVM
    {
        public int Id { get; set; }
        public string? Title { get; set; } = string.Empty;
        public string? Content { get; set; } = string.Empty;
        public string? EnglishTitle { get; set; } = string.Empty;
        public string? ArabicTitle { get; set; } = string.Empty;
        public string? EnglishContent { get; set; } = string.Empty;
        public string? ArabicContent { get; set; } = string.Empty;
        public string? ImageUrl { get; set; } = string.Empty;
        public bool? ImageInStart { get; set; }
        public CardType CardType { get; set; }
        public bool IsHide { get; set; }
        public int orderId { get; set; }
        public int PageId { get; set; }
    }
}
