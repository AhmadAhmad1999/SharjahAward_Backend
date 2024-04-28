using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.SocialMediaPage.Commands.UpdateSocialMediaItem
{
    public class UpdateSocialMediaItemCommand : IRequest<BaseResponse<object>>
    {
        public int Id {  get; set; }
        public bool UpdateOnLogo {  get; set; }
        public IFormFile? Logo { get; set; }
        public bool UpdateOnThumbnail {  get; set; }
        public IFormFile? Thumbnail { get; set; }
        public string Url { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
