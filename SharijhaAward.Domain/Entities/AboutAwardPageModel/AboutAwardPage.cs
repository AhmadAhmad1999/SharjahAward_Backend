using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Domain.Entities.AboutAwardPageModel
{
    public class AboutAwardPage : AuditableEntity 
    {
        public int Id { get; set; }
        public bool IsAboutHidden { get; set; }
        public string ArabicAboutTitle { get; set; } = string.Empty;
        public string EnglishAboutTitle { get; set; } = string.Empty;
        public string ArabicAboutDescription { get; set; } = string.Empty;
        public string EnglishAboutDescription { get; set; } = string.Empty;
        public string AboutImage { get; set; } = string.Empty;
        public bool IsOurVisionHidden { get; set; }
        public string ArabicOurVisionTitle { get; set; } = string.Empty;
        public string EnglishOurVisionTitle { get; set; } = string.Empty;
        public string ArabicOurVisionDescription { get; set; } = string.Empty;
        public string EnglishOurVisionDescription { get; set; } = string.Empty;
        public string OurVisionImage { get; set; } = string.Empty;
        public string ArabicOurGoalTitle { get; set; } = string.Empty;
        public string EnglishOurGoalTitle { get; set; } = string.Empty;
        public bool IsGoalsHidden { get; set; }
        public List<OurGoal> OurGoals { get; set; } = null!;
    }
}
