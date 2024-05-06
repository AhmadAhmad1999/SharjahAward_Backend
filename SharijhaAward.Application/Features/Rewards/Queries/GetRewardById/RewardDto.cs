using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Rewards.Queries.GetRewardById
{
    public class RewardDto
    {
        public int Id { get; set; }
        public int RewardValue { get; set; }
        public string Rank { get; set; } = string.Empty;
        public string ArabicRank { get; set; } = string.Empty;
        public string EnglishRank { get; set; } = string.Empty;
        public int CategoryId { get; set; }
    }
}
