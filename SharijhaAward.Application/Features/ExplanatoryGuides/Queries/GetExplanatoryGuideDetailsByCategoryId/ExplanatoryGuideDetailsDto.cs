using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExplanatoryGuides.Queries.GetExplanatoryGuideDetailsByCategoryId
{
    public class ExplanatoryGuideDetailsDto
    {
        public Guid Id { get; set; }
        public string Title {  get; set; } =string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishFilePath { get; set; } = string.Empty;
        public string ArabicFilePath { get; set; } = string.Empty;
    }
}
