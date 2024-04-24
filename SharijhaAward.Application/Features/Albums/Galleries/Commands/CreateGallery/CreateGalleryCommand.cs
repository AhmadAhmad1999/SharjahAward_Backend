using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Albums.Galleries.Commands.CreateGallery
{
    public class CreateGalleryCommand : IRequest<BaseResponse<object>>
    {
        public IFormFile FileUrl { get; set; } = null!;
        public int AlbumId { get; set; }
        public string? lang { get; set; }
    }
}
