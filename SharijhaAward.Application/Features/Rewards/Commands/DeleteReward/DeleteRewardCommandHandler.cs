using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.RewardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Rewards.Commands.DeleteReward
{
    public class DeleteRewardCommandHandler
        : IRequestHandler<DeleteRewardCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Reward> _rewardRepository;

        public DeleteRewardCommandHandler(IAsyncRepository<Reward> rewardRepository)
        {
            _rewardRepository = rewardRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteRewardCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Reward has been Deleted"
                : "تم حذف المكافئة ";

            var Reward = await _rewardRepository.GetByIdAsync(request.Id);

            if(Reward == null)
            {
                msg = request.lang == "en"
                ? "Reward not found"
                : "المكافئة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _rewardRepository.DeleteAsync(Reward);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
