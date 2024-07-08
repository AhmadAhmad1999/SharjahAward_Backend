using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.AttachmentConstant;
using SharijhaAward.Domain.Entities.AlbumModel;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Albums.Commands.CreateAlbum
{
    public class CreateAlbumCommandHandler
        : IRequestHandler<CreateAlbumCommand, BaseResponse<int>>
    {
        private readonly IAsyncRepository<Album> _albumRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateAlbumCommandHandler(IAsyncRepository<Album> albumRepository, IFileService fileService, IMapper mapper)
        {
            _albumRepository = albumRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<int>> Handle(CreateAlbumCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Album has been Created"
                : "تمت إضافة الألبوم";

            var album = _mapper.Map<Album>(request);

            album.ThumbnailUrl = await _fileService.SaveFileAsync(request.Thumbnail, SystemFileType.Images);
           
            var data = await _albumRepository.AddAsync(album);

            return new BaseResponse<int>(msg, true, 200, data.Id);
            
        }
    }
}
