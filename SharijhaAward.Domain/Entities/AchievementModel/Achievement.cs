using SharijhaAward.Domain.Common;
using SharijhaAward.Domain.Constants.AchievementConstant;
using SharijhaAward.Domain.Entities.AchievementClassificationModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace SharijhaAward.Domain.Entities.AchievementModel
{
    public class Achievement : AuditableEntity
    {
        public Guid Id { get; set; }
        public string? DistinctionField { get; set; } =string.Empty;
        public string? Projects { get; set; } = string.Empty;
        public string? SkillsAndExperiences { get; set; } = string.Empty;
        public string? Facebook {  get; set; } = string.Empty;
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

        public User? User { get; set; } = null!;
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }


    }
}
