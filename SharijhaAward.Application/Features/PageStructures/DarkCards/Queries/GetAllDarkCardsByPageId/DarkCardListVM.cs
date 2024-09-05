using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.DarkCards.Queries.GetAllDarkCardsByPageId
{
    public class DarkCardListVM
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishContent { get; set; } = string.Empty;
        public string ArabicContent { get; set; } = string.Empty;
        public bool IsHide { get; set; }
        public int orderId { get; set; }
    }
}
