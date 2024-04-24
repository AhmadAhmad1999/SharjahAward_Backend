using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AlbumModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Albums.Galleries.Commands.CreateGallery
{
    public class CreateGalleryCommandHandler
        : IRequestHandler<CreateGalleryCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Album> _albumRepository;
        private readonly IAsyncRepository<Gallery> _galleryRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateGalleryCommandHandler(IAsyncRepository<Album> albumRepository, IAsyncRepository<Gallery> galleryRepository, IFileService fileService, IMapper mapper)
        {
            _albumRepository = albumRepository;
            _galleryRepository = galleryRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateGalleryCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Gallery has been Created"
                : "تم اضافة الملف";

            var album = await _albumRepository.GetByIdAsync(request.AlbumId);
           
            if(album == null)
            {
                msg = request.lang == "en"
                ? "Album Not Found"
                : "الألبوم غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            var Gallery = _mapper.Map<Gallery>(request);

            Gallery.FileUrl = await _fileService.SaveFileAsync(request.FileUrl);

            await _galleryRepository.AddAsync(Gallery);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
