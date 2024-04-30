using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Achievements.Queries.GetAchievementsPage
{
    public class AchievementsDto
    {
        public string? DistinctionField { get; set; } = string.Empty;
        public string? Projects { get; set; } = string.Empty;
        public string? SkillsAndExperiences { get; set; } = string.Empty;
        public string? Facebook { get; set; } = string.Empty;
        public string? Youtube { get; set; } = string.Empty;
        public string? Instagram { get; set; } = string.Empty;
        public string? Twitter { get; set; } = string.Empty;
        public string? Linkedin { get; set; } = string.Empty;
        public string? Snapchat { get; set; } = string.Empty;
        public string? Tiktok { get; set; } = string.Empty;
        public DateTime? UpdateDistinctionField { get; set; }
        public DateTime? UpdateProjects { get; set; }
        public DateTime? UpdateSkillsAndExperiences { get; set; }
        public DateTime? UpdateSocialMedia { get; set; }
        public DateTime CreatedAt {  get; set; } 
        public DateTime UpdatedAt { get; set; }
        public bool? AcceptedOnDistinctionField { get; set; }
        public bool? AcceptedOnProjects { get; set; }
        public bool? AcceptedOnSkillsAndExperiences { get; set; }
    }
}
