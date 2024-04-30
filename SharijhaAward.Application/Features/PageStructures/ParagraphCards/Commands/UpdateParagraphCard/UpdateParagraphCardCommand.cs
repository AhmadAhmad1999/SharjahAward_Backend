using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.PageStructures.ParagraphCards.Commands.UpdateParagraphCard
{
    public class UpdateParagraphCardCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string EnglishTitle { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string? EnglishContent { get; set; } = string.Empty;
        public string? ArabicContent { get; set; } = string.Empty;
        public bool? UpdateonImage { get; set; }
        public IFormFile? Image { get; set; } = null!;
        public bool? ImageInStart { get; set; }
        public int PageId { get; set; }
        public string? lang { get; set; }
    }
}
