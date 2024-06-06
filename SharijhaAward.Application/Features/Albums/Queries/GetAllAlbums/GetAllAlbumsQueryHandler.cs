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
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IMapper _mapper;

        public GetAllAlbumsQueryHandler(IAsyncRepository<Album> albumRepository, IAsyncRepository<Cycle> cycleRepository, IMapper mapper)
        {
            _albumRepository = albumRepository;
            _cycleRepository = cycleRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<AlbumListVm>>> Handle(GetAllAlbumsQuery request, CancellationToken cancellationToken)
        {

            var Cycle = request.CycleId == null
                ? await _cycleRepository.FirstOrDefaultAsync(c => c.Status == Domain.Constants.Common.Status.Active)
                : await _cycleRepository.GetByIdAsync(request.CycleId);
          
            if(Cycle == null)
            {
                string msg = request.lang == "en"
                            ? "Cycle Not Found"
                            : "الدورة غير موجودة";

                return new BaseResponse<List<AlbumListVm>>(msg, false, 404);
            }

            var AllAlbums = await _albumRepository.GetWhereThenPagedReponseAsync(a => a.CycleId == Cycle.Id, request.page, request.perPage);
            
            var data = _mapper.Map<List<AlbumListVm>>(AllAlbums);

            int Count = _albumRepository.GetCount(a => a.CycleId == Cycle.Id && !a.isDeleted);
           
            Pagination pagination = new Pagination(request.page, request.perPage, Count);
          
            return new BaseResponse<List<AlbumListVm>>("", true, 200, data, pagination);
        }
    }
}
