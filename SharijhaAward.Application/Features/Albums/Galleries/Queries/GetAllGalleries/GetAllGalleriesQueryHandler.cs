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

namespace SharijhaAward.Application.Features.Albums.Galleries.Queries.GetAllGalleries
{
    public class GetAllGalleriesQueryHandler
        : IRequestHandler<GetAllGalleriesQuery, BaseResponse<List<GalleryListVm>>>
    {
        private readonly IAsyncRepository<Album> _albumRepository;
        private readonly IAsyncRepository<Gallery> _galleryRepository;
        private readonly IMapper _mapper;

        public GetAllGalleriesQueryHandler(IAsyncRepository<Album> albumRepository, IAsyncRepository<Gallery> galleryRepository, IMapper mapper)
        {
            _albumRepository = albumRepository;
            _galleryRepository = galleryRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<GalleryListVm>>> Handle(GetAllGalleriesQuery request, CancellationToken cancellationToken)
        {
            var album = await _albumRepository.GetByIdAsync(request.AlbumId);
          
            if(album == null)
            {
                return new BaseResponse<List<GalleryListVm>>("", false, 404);
            }
         
            var AllGalleries = await _galleryRepository.GetWhereThenPagedReponseAsync(g => g.AlbumId == album.Id, request.page, request.perPage);
          
            var data = _mapper.Map<List<GalleryListVm>>(AllGalleries);

            int Count = _galleryRepository.GetCount(g => g.AlbumId == album.Id && !g.isDeleted);
           
            Pagination pagination = new Pagination(request.page, request.perPage, Count);
          
            return new BaseResponse<List<GalleryListVm>>("", true, 200, data, pagination);
        }
    }
}
