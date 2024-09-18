using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AlbumModel;

namespace SharijhaAward.Application.Features.Albums.Galleries.Commands.DeleteGallery
{
    public class DeleteGalleryCommandHandler
        : IRequestHandler<DeleteGalleryCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Gallery> _galleryRepository;

        public DeleteGalleryCommandHandler(IAsyncRepository<Gallery> galleryRepository)
        {
            _galleryRepository = galleryRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteGalleryCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Gallery has been Deleted"
                : "تم حذف الملف";

            var gallery = await _galleryRepository.GetByIdAsync(request.Id);
            if(gallery == null)
            {
                msg = request.lang == "en"
                ? "Gallery Not Found"
                : "الملف غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }

            await _galleryRepository.DeleteAsync(gallery);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
