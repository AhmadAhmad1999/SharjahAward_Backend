using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Albums.Queries.GetAllAlbums
{
    public class GetAllAlbumsQuery : IRequest<BaseResponse<List<AlbumListVm>>>
    {
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public string? lang { get; set; }
        public List<Filter>? filters { get; set; }

    }
}
