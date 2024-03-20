using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Achievements.Queries.GetAchievementsPage
{
    public class GetAchievementsPageQuery : IRequest<BaseResponse<AchievementsDto>>
    {
        public string token { get; set; } = string.Empty;
    }
}
