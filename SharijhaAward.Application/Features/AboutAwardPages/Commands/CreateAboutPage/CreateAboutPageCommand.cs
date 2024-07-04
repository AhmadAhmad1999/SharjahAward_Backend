using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.AboutAwardPages.Commands.CreateAboutPage
{
    public class CreateAboutPageCommand : IRequest<BaseResponse<object>>
    {
        public bool IsAboutHidden { get; set; }
        public string ArabicAboutTitle { get; set; } = string.Empty;
        public string EnglishAboutTitle { get; set; } = string.Empty;
        public string ArabicAboutDescription { get; set; } = string.Empty;
        public string EnglishAboutDescription { get; set; } = string.Empty;
        public IFormFile AboutImage { get; set; }= null!;
        public bool IsOurVisionHidden { get; set; }
        public string ArabicOurVisionTitle { get; set; } = string.Empty;
        public string EnglishOurVisionTitle { get; set; } = string.Empty;
        public string ArabicOurVisionDescription { get; set; } = string.Empty;
        public string EnglishOurVisionDescription { get; set; } = string.Empty;
        public IFormFile OurVisionImage { get; set; } = null!;
        public bool IsGoalsHidden { get; set; }
        public string ArabicOurGoalTitle { get; set; } = string.Empty;
        public string EnglishOurGoalTitle { get; set; } = string.Empty;
        public string lang {  get; set; } = string.Empty;
    }
}
