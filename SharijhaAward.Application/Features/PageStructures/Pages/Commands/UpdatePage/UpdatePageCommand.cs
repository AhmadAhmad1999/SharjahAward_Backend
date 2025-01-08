using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Features.PageStructures.DarkCards.Commands.UpdateDarkCard;
using SharijhaAward.Application.Features.PageStructures.GoalCards.Commands.UpdateGoalCard;
using SharijhaAward.Application.Features.PageStructures.ImageCards.Commands.UpdateImageCard;
using SharijhaAward.Application.Features.PageStructures.ParagraphCards.Commands.UpdateParagraphCard;
using SharijhaAward.Application.Features.PageStructures.TextCards.Commands.UpdateTextCard;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Constants.CustomPageConstants;

namespace SharijhaAward.Application.Features.PageStructures.Pages.Commands.UpdatePage
{
    public class UpdatePageCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public bool hasHelography { get; set; }
        public bool? UpdateOnIcon {  get; set; }
        public IFormFile? Icon { get; set; }
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string? EnglishSubTitle { get; set; }
        public string? ArabicSubTitle { get; set; }
        public string? EnglishContent { get; set; }
        public string? ArabicContent { get; set; }
        public string? RefUrl { get; set; }
        public bool IsHide { get; set; }
        public string? lang { get; set; }
        public List<UpdateDarkCardCommand> DarkCardRequest { get; set; } = new List<UpdateDarkCardCommand>();
        public List<UpdateParagraphCardCommand> ParagraphCardRequest { get; set; } = new List<UpdateParagraphCardCommand>();
        public List<UpdateGoalCardCommand> GoalCardRequest { get; set; } = new List<UpdateGoalCardCommand>();
        public List<UpdateImageCardCommand> ImageCardRequest { get; set; } = new List<UpdateImageCardCommand>();
        public List<UpdateTextCardCommand> TextCardRequest { get; set; } = new List<UpdateTextCardCommand>();
    }
}
