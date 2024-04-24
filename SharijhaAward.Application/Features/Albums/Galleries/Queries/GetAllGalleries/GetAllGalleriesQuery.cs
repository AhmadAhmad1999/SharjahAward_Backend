using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Albums.Galleries.Queries.GetAllGalleries
{
    public class GetAllGalleriesQuery : IRequest<BaseResponse<List<GalleryListVm>>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public int AlbumId { get; set; }
        public string? lang { get; set; }
    }
}
