using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetAllGoalCardsByPageId
{
    public class GoalCardListVM
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public string? Content { get; set; }
        public string? EnglishContent { get; set; }
        public string? ArabicContent { get; set; }
        public bool IsHide { get; set; }
        public CardType CardType { get; set; }
        public int PageId { get; set; }
    }
}
