using MediatR;
using SharijhaAward.Application.Features.Achievements.Queries.GetAchievementsPage;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Achievements.Queries.GetAchievementsById
{
    public class GetAchievementsByIdQuery : IRequest<BaseResponse<AchievementsDto>>
    {
        public int UserId { get; set; }
        public string token { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
