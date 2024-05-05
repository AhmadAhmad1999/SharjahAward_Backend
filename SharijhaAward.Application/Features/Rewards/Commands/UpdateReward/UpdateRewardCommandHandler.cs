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

namespace SharijhaAward.Application.Features.Rewards.Commands.UpdateReward
{
    public class UpdateRewardCommandHandler
        : IRequestHandler<UpdateRewardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Reward> _rewardRepository;
        private readonly IMapper _mapper;

        public UpdateRewardCommandHandler(IAsyncRepository<Reward> rewardRepository, IMapper mapper)
        {
            _rewardRepository = rewardRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateRewardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Reward has been Updated"
                : "تم تعديل المكافئة ";

            var Reward = await _rewardRepository.GetByIdAsync(request.Id);
            if(Reward == null)
            {
                msg = request.lang == "en"
                    ? "Reward not found"
                    : "المكافئة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            _mapper.Map(request, Reward, typeof(UpdateRewardCommand), typeof(Reward));

            await _rewardRepository.UpdateAsync(Reward);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
