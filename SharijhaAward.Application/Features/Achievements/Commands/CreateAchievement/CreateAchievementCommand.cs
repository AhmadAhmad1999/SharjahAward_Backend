using MediatR;
using SharijhaAward.Application.Helpers.URLValidationAttributeHelper;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Achievements.Commands.CreateAchievement
{
    public class CreateAchievementCommand : IRequest<BaseResponse<object>>
    {
        public string? DistinctionField { get; set; } = string.Empty;
        public string? Projects { get; set; } = string.Empty;
        public string? SkillsAndExperiences { get; set; } = string.Empty;

        [URLValidation]
        public string? Facebook { get; set; } = string.Empty;

        [URLValidation]
        public string? Youtube { get; set; } = string.Empty;

        [URLValidation]
        public string? Instagram { get; set; } = string.Empty;

        [URLValidation]
        public string? Twitter { get; set; } = string.Empty;

        [URLValidation]
        public string? Linkedin { get; set; } = string.Empty;

        [URLValidation]
        public string? Snapchat { get; set; } = string.Empty;

        [URLValidation]
        public string? Tiktok { get; set; } = string.Empty;

        public string token { get; set;} = string.Empty;
    }
}
