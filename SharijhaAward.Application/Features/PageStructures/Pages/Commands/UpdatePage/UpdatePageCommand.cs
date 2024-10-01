using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;
using SharijhaAward.Domain.Constants.CustomPageConstants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public PagePostion PagePostion { get; set; }
        public PageType PageType { get; set; }
        public string? RefUrl { get; set; }
        public int orderId { get; set; }
        public bool IsHide { get; set; }
        public string? lang { get; set; }
    }
}
