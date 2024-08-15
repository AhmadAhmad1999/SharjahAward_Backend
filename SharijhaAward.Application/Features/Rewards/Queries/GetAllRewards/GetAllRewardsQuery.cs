using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Rewards.Queries.GetAllRewards
{
    public class GetAllRewardsQuery : IRequest<BaseResponse<List<RewardListVm>>>
    {
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public int CategoryId { get; set; }
        public List<Filter>? filters { get; set; }
        public string? lang { get; set; }

    }
}
