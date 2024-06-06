using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using SharijhaAward.Domain.Entities.RewardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Rewards.Queries.GetAllRewards
{
    public class GetAllRewardsQueryHandler
        : IRequestHandler<GetAllRewardsQuery, BaseResponse<List<RewardListVm>>>
    {
        private readonly IAsyncRepository<Reward> _rewardRepository;
        private readonly IMapper _mapper;

        public GetAllRewardsQueryHandler(IAsyncRepository<Reward> rewardRepository, IMapper mapper)
        {
            _rewardRepository = rewardRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<RewardListVm>>> Handle(GetAllRewardsQuery request, CancellationToken cancellationToken)
        {
            var Rewards = await _rewardRepository.GetWhereThenPagedReponseAsync(r => r.CategoryId == request.CategoryId, request.page, request.perPage);
            
            var data = _mapper.Map<List<RewardListVm>>(Rewards);

            foreach (var item in data)
            {
                item.Rank = request.lang == "en" ? item.EnglishRank : item.ArabicRank;
            }
            int count = _rewardRepository.GetCount(r => r.CategoryId == request.CategoryId);
           
            Pagination pagination = new Pagination(request.page, request.perPage, count);
           
            return new BaseResponse<List<RewardListVm>>("", true, 200, data, pagination);
        }
    }
}
