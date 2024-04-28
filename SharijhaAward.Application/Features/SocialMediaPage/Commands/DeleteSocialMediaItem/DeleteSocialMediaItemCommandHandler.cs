using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.SocialMediaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.SocialMediaPage.Commands.DeleteSocialMediaItem
{
    public class DeleteSocialMediaItemCommandHandler
        : IRequestHandler<DeleteSocialMediaItemCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<SocialMedia> _socialMediaRepository;

        public DeleteSocialMediaItemCommandHandler(IAsyncRepository<SocialMedia> socialMediaRepository)
        {
            _socialMediaRepository = socialMediaRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteSocialMediaItemCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Social Media Item has been Deleted"
                : "تم حذف عنصر التواصل الإجتماعي";

            var ItemToDelete = await _socialMediaRepository.GetByIdAsync(request.Id);
            if (ItemToDelete == null)
            {
                msg = request.lang == "en"
                    ? "Social Media Item Not Found"
                    : "عنصرالتواصل الإجتماعي غير موجود";

                return new BaseResponse<object>(msg, false, 404);

            }

            await _socialMediaRepository.DeleteAsync(ItemToDelete);

            return new BaseResponse<object>("", true, 200);
        }
    }
}
