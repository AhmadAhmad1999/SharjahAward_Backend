using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.PageStructureModels;

namespace SharijhaAward.Application.Features.PageStructures.GoalCards.Commands.UpdateGoalCard
{
    public class UpdateGoalCardCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public string? EnglishTitle { get; set; }
        public string? ArabicTitle { get; set; }
        public string? EnglishContent { get; set; }
        public string? ArabicContent { get; set; }
        public bool IsHide { get; set; }
        public int PageId { get; set; }
        public string? lang { get; set; }
        public CardType CardType { get; set; }
        public int? ParentId { get; set; }
        public List<UpdateGoalCardCommand> SubGoals { get; set; } = new List<UpdateGoalCardCommand>();
    }
}
