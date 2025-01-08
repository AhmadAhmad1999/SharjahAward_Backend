using SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetAllDarkCardsByPageId;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Queries.GetAllParagraphCardsByPageId;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageById
{
    public class PageDto 
    {
        public int Id { get; set; }
        public bool hasHelography { get; set; }
        public string? IconUrl { get; set; }
        public string Title { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string? SubTitle { get; set; } = string.Empty;
        public string? EnglishSubTitle { get; set; }
        public string? ArabicSubTitle { get; set; }
        public string? Content { get; set; } = string.Empty;
        public string? EnglishContent { get; set; }
        public string? ArabicContent { get; set; }
        public int ParentId { get; set; }
        public string Slug { get; set; } = string.Empty;
        public string? RefUrl { get; set; }
        public PageType PageType { get; set; }
        public int numberOfSubPages { get; set; }
        public List<Component>? Components { get; set; } = null!;
        public bool IsHide { get; set; }
    }
}
