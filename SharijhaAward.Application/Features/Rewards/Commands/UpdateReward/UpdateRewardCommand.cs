using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Rewards.Commands.UpdateReward
{
    public class UpdateRewardCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public int RewardValue { get; set; }
        public string ArabicRank { get; set; } = string.Empty;
        public string EnglishRank { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
