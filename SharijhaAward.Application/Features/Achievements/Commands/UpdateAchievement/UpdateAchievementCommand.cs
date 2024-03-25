using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Achievements.Commands.UpdateDistinctionField
{
    public class UpdateAchievementCommand : IRequest<BaseResponse<object>>
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
        public string token { get; set; } = string.Empty;
    }
}
