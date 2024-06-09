using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Albums.Commands.UpdateAlbum
{
    public class UpdateAlbumCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public bool UpdateOnThumbnail {  get; set; }
        public IFormFile? Thumbnail { get; set; } = null!;
        public int CycleId { get; set; }
        public string? lang { get; set; }
    }
}
