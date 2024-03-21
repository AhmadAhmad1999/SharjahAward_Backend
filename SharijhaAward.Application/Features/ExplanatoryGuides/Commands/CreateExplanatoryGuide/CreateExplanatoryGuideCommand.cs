using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ExplanatoryGuides.Commands.CreateExplanatoryGuide
{
    public class CreateExplanatoryGuideCommand : IRequest<BaseResponse<object>>
    {
        public Guid CategoryId { get; set; }
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public IFormFile EnglishFile { get; set; } = null!;
        public IFormFile ArabicFile { get; set; } = null!;
    }
}
