using SharijhaAward.Application.Features.PageStructures.GoalCards.Queries.GetAllGoalCardsByPageId;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Queries.GetPageById
{
    public class Component
    {
        public object? Card { get; set; } = null!;
        public bool IsHide { get; set; }
        public MainGoalCardData? Goals { get; set; }
        public string CardType { get; set; } = string.Empty;
        public int orderId { get; set; }
    }
    public class MainGoalCardData
    {
        public int Id { get; set; }
        public string? EnglishTitle { get; set; } = string.Empty;
        public string? ArabicTitle { get; set; } = string.Empty;
        public string? Title { get; set; } = string.Empty;
        public int PageId { get; set; }
        public bool IsHide { get; set; }
        public int orderId { get; set; }
        public List<GoalCardListVM> SubGoals { get; set; } = new List<GoalCardListVM>();
    }
}
