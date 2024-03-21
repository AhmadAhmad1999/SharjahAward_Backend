using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExplanatoryGuides.Commands.UpdateExplanatoryGuide
{
    public class UpdateExplanatoryGuideCommand : IRequest<BaseResponse<object>>
    {
        public Guid GuideId { get; set; }
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public bool UpdateOnEnglishFile {  get; set; }
        public IFormFile? EnglishFile { get; set; } = null!;
        public bool UpdateOnArabicFile { get; set; }
        public IFormFile? ArabicFile { get; set; } = null!;
        public string? lang {  get; set; } = string.Empty;
    }
}
