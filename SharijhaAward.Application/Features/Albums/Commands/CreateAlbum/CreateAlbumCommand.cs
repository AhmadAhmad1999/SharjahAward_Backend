using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Albums.Commands.CreateAlbum
{
    public class CreateAlbumCommand : IRequest<BaseResponse<int>>
    {
        public string Title { get; set; } = string.Empty;
        public IFormFile Thumbnail { get; set; } = null!;
        public int CycleId { get; set; }
        public string? lang { get; set; }
    }
}
