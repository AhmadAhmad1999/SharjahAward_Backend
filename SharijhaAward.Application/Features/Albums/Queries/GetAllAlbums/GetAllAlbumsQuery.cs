using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Albums.Queries.GetAllAlbums
{
    public class GetAllAlbumsQuery : IRequest<BaseResponse<List<AlbumListVm>>>
    {
        public int page { get; set; }
        public int perPage { get; set; }
        public string? lang { get; set; }

    }
}
