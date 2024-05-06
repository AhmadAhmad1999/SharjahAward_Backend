using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.RewardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Rewards.Queries.GetRewardById
{
    public class GetRewardByIdQueryHandler
        : IRequestHandler<GetRewardByIdQuery, BaseResponse<RewardDto>>
    {
        private readonly IAsyncRepository<Reward> _rewardRepository;
        private readonly IMapper _mapper;

        public GetRewardByIdQueryHandler(IAsyncRepository<Reward> rewardRepository, IMapper mapper)
        {
            _rewardRepository = rewardRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<RewardDto>> Handle(GetRewardByIdQuery request, CancellationToken cancellationToken)
        {
            var Reward = await _rewardRepository.GetByIdAsync(request.Id);

            if(Reward == null)
            {
                return new BaseResponse<RewardDto>("", false, 404);
            }

            var data = _mapper.Map<RewardDto>(Reward);

            data.Rank = request.lang == "en" ? data.EnglishRank : data.ArabicRank;

            return new BaseResponse<RewardDto>("", true, 200, data);
        }
    }
}
