using MediatR;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetAllGoalCardsByPageId;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetAllGoalCardsDashboard
{
    public class GetAllGoalCardsDashboardQuery : IRequest<BaseResponse<List<GoalCardListVM>>>
    {
        public int PageId { get; set; }
        public string? lang { get; set; }
    }
}
