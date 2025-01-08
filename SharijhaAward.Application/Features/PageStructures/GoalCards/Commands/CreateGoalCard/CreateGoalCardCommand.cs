using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.GoalCards.Commands.CreateGoalCard
{
    public class CreateGoalCardCommand : IRequest<BaseResponse<object>>
    {
        public string? EnglishTitle { get; set; } = string.Empty;
        public string? ArabicTitle { get; set; } = string.Empty;
        public List<Card> SubGoals { get; set; } = new List<Card>();
        public string? lang { get; set; }
        public int PageId { get; set; }
        public bool IsHide { get; set; }
        public int orderId { get; set; }
    }
    public class Card
    {
        public int orderId { get; set; }
        public string EnglishContent { get; set; } = string.Empty;
        public string ArabicContent { get; set; } = string.Empty;
        public bool IsHide { get; set; }
        public CardType CardType = CardType.GoalCard;
    }
}
