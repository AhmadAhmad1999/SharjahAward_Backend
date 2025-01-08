using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.PageStructures.DarkCards.Commands.CreateDarkCard
{
    public class CreateDarkCardCommand : IRequest<BaseResponse<object>>
    {
        public int orderId { get; set; }
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishContent { get; set; } = string.Empty;
        public string ArabicContent { get; set; } = string.Empty;
        public bool IsHide { get; set; }
        public int PageId { get; set; }
        public string? lang {  get; set; }
    }
}
