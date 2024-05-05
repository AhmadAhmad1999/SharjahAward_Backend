using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Rewards.Queries.GetAllRewards
{
    public class GetAllRewardsQuery : IRequest<BaseResponse<List<RewardListVm>>>
    {
        public int CategoryId { get; set; } 
        public string? lang { get; set; }

    }
}
