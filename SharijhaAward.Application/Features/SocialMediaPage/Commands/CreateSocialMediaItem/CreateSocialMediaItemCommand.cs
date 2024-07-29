using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.SocialMediaPage.Commands.CreateSocialMediaItem
{
    public class CreateSocialMediaItemCommand : IRequest<BaseResponse<object>>
    {
        public IFormFile? Logo { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
