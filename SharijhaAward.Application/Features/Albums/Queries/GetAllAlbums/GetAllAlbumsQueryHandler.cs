using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AlbumModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Albums.Queries.GetAllAlbums
{
    public class GetAllAlbumsQueryHandler
        : IRequestHandler<GetAllAlbumsQuery, BaseResponse<List<AlbumListVm>>>
    {
        private readonly IAsyncRepository<Album> _albumRepository;
        private readonly IMapper _mapper;

        public GetAllAlbumsQueryHandler(IAsyncRepository<Album> albumRepository, IMapper mapper)
        {
            _albumRepository = albumRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<AlbumListVm>>> Handle(GetAllAlbumsQuery request, CancellationToken cancellationToken)
        {
            var AllAlbums = await _albumRepository.GetPagedReponseAsync(request.page, request.perPage);
            
            var data = _mapper.Map<List<AlbumListVm>>(AllAlbums);

            foreach(var item in data)
            {
                item.Title = request.lang == "en"
                    ? item.EnglishTitle
                    : item.ArabicTitle;
            }

            int Count = _albumRepository.GetCount(a => !a.isDeleted);
           
            Pagination pagination = new Pagination(request.page, request.perPage, Count);
          
            return new BaseResponse<List<AlbumListVm>>("", true, 200, data, pagination);
        }
    }
}
