using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AlbumModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Albums.Queries.GetAlbumById
{
    public class GetAlbumByIdQueryHandler
        : IRequestHandler<GetAlbumByIdQuery, BaseResponse<AlbumDto>>
    {
        private readonly IAsyncRepository<Album> _albumRepository;
        private readonly IMapper _mapper;

        public GetAlbumByIdQueryHandler(IAsyncRepository<Album> albumRepository, IMapper mapper)
        {
            _albumRepository = albumRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<AlbumDto>> Handle(GetAlbumByIdQuery request, CancellationToken cancellationToken)
        {
            var album = await _albumRepository.GetByIdAsync(request.Id);
            if (album == null)
            {
                string msg = request.lang == "en"
                    ? "Album Not Found"
                    : "الألبوم غير موجود";

                return new BaseResponse<AlbumDto>(msg, false, 404);
            }

            var data = _mapper.Map<AlbumDto>(album);

            return new BaseResponse<AlbumDto>("", true, 200);
        }
    }
}
