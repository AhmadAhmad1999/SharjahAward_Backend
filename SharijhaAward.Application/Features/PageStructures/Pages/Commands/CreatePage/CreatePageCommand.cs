using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public PageType PageType { get; set; }
        public bool IsHide { get; set; }
        public int? ParentId { get; set; }
        public string? lang { get; set; }
    }
}
