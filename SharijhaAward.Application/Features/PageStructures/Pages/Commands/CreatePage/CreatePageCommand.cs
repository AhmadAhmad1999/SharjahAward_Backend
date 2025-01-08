using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Commands.CreateDarkCard;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Commands.CreateGoalCard;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Commands.CreateImageCard;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Commands.CreateParagraphCard;
using SharijhaAward.Application.Features.PageStructures.TextCards.Commands.CreateTextCard;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Constants.CustomPageConstants;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Commands.CreatePage
{
    public class CreatePageCommand : IRequest<BaseResponse<int>>
    {
        public bool hasHelography { get; set; }
        public IFormFile? Icon { get; set; }
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string? EnglishSubTitle { get; set; }
        public string? ArabicSubTitle { get; set; }
        public string? EnglishContent { get; set; }
        public string? ArabicContent { get; set; }
        public string? Slug { get; set; }
        public string? RefUrl { get; set; }
        public PagePostion PagePostion { get; set; }
        public PageType PageType { get; set; }
        public int orderId { get; set; }
        public bool IsHide { get; set; }
        public int? ParentId { get; set; }
        public string? lang { get; set; }
        public List<CreateDarkCardCommand> DarkCardRequest { get; set; } = new List<CreateDarkCardCommand>();
        public List<CreateParagraphCardCommand> ParagraphCardRequest { get; set; } = new List<CreateParagraphCardCommand>();
        public List<CreateGoalCardCommand> GoalCardRequest { get; set; } = new List<CreateGoalCardCommand>();
        public List<CreateImageCardCommand> ImageCardRequest { get; set; } = new List<CreateImageCardCommand>();
        public List<CreateTextCardCommand> TextCardRequest { get; set; } = new List<CreateTextCardCommand>();
    }
}
