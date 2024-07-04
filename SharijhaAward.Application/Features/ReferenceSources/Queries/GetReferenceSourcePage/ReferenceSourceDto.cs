using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ReferenceSources.Queries.GetReferenceSourcePage
{
    public class ReferenceSourceDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Sources { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishSources { get; set; } = string.Empty;
        public string ArabicSources { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public string ExplanatoryGuideUrl { get; set; } = string.Empty;
    }
}
