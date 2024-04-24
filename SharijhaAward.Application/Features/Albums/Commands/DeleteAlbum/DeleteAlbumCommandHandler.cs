using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AlbumModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Albums.Commands.DeleteAlbum
{
    public class DeleteAlbumCommandHandler
        : IRequestHandler<DeleteAlbumCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Album> _albumRepository;

        public DeleteAlbumCommandHandler(IAsyncRepository<Album> albumRepository)
        {
            _albumRepository = albumRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteAlbumCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Album has been Deleted"
                : "تم حذف الألبوم"; 

            var album = await _albumRepository.GetByIdAsync(request.Id);
            if (album == null)
            {
                msg = request.lang == "en"
                ? "Album Not found"
                : "الألبوم غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _albumRepository.DeleteAsync(album);

            return new BaseResponse<object>(msg, true, 200);

        }
    }
}
