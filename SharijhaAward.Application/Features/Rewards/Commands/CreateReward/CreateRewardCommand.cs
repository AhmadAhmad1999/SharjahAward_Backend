using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CategoryModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Rewards.Commands.CreateReward
{
    public class CreateRewardCommand : IRequest<BaseResponse<object>>
    {
        public int RewardValue { get; set; }
        public string ArabicRank { get; set; } = string.Empty;
        public string EnglishRank { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public string? lang { get; set; }
    }
}
