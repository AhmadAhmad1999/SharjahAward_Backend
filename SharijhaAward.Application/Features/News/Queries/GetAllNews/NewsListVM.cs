using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.News.Queries.GetAllNews
{
    public class NewsListVM
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string? Image { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string? ArabicDescription { get; set; }
        public string? EnglishDescription { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CycleId { get; set; }
    }
}
