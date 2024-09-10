using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetGoalCardById
{
    public class GoalCardDto
    {
        public int orderId { get; set; }
        public string Content { get; set; } = string.Empty;
        public string EnglishContent { get; set; } = string.Empty;
        public string ArabicContent { get; set; } = string.Empty;
        public bool IsHide { get; set; }
        public CardType CardType { get; set; }
        public int PageId { get; set; }
    }
}
