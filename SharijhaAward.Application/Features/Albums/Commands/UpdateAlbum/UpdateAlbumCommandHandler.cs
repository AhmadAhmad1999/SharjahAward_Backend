using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AlbumModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Albums.Commands.UpdateAlbum
{
    public class UpdateAlbumCommandHandler
        : IRequestHandler<UpdateAlbumCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Album> _albumRepository;
        private readonly IAsyncRepository<Cycle> _cycleRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateAlbumCommandHandler(IAsyncRepository<Album> albumRepository, IAsyncRepository<Cycle> cycleRepository, IFileService fileService, IMapper mapper)
        {
            _albumRepository = albumRepository;
            _cycleRepository = cycleRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateAlbumCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Album has been Created"
                : "تم تعديل الألبوم";

            var album = await _albumRepository.GetByIdAsync(request.Id);
            
            if (album == null)
            {
                msg = request.lang == "en"
                ? "Album Not Found"
                : "الألبوم غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            var cycle = await _cycleRepository.GetByIdAsync(request.CycleId);

            if (cycle == null)
            {
                msg = request.lang == "en"
                     ? "Cycle Not Found"
                     : "الدورة غير موجودة";

                return new BaseResponse<object>(msg, false, 404);
            }

            var thumbnail = album.ThumbnailUrl;
          
            _mapper.Map(request, album, typeof(UpdateAlbumCommand), typeof(Album));
          
            if (request.UpdateOnThumbnail)
                album.ThumbnailUrl = await _fileService.SaveFileAsync(request.Thumbnail);
            else
                album.ThumbnailUrl = thumbnail;

            await _albumRepository.UpdateAsync(album);

            return new BaseResponse<object>(msg, true, 200);

        }
    }
}
