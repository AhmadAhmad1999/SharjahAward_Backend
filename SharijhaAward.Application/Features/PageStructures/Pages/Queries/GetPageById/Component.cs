using SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetAllGoalCardsByPageId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageById
{
    public class Component
    {
        public object? Card { get; set; } = null!;
        public bool IsHide { get; set; }
        public List<GoalCardListVM>? Goals { get; set; } = new List<GoalCardListVM>();
        public string CardType { get; set; } = string.Empty;
        public int orderId { get; set; }
    }
}
