using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.SocialMediaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.SocialMediaPage.Commands.UpdateSocialMediaItem
{
    public class UpdateSocialMediaItemCommandHandler
        : IRequestHandler<UpdateSocialMediaItemCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<SocialMedia> _socialMediaRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public UpdateSocialMediaItemCommandHandler(IAsyncRepository<SocialMedia> socialMediaRepository, IFileService fileService, IMapper mapper)
        {
            _socialMediaRepository = socialMediaRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateSocialMediaItemCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Social Media Item has been Updated"
                : "تم تعديل عنصر التواصل الإجتماعي";

            var item = await _socialMediaRepository.GetByIdAsync(request.Id);

            if (item == null)
            {
                msg = request.lang == "en"
                    ? "Social Media Item Not Found"
                    : "عنصرالتواصل الإجتماعي غير موجود";

                return new BaseResponse<object>(msg, false, 404);
            }
            var logo = item.LogoUrl;
            var thumbnail = item.ThumbnailUrl;

            _mapper.Map(request, item, typeof(UpdateSocialMediaItemCommand), typeof(SocialMedia));

            if (request.UpdateOnThumbnail)
                item.ThumbnailUrl = await _fileService.SaveFileAsync(request.Thumbnail!);
            else
                item.ThumbnailUrl = thumbnail;


            if (request.UpdateOnLogo)
                item.LogoUrl = await _fileService.SaveFileAsync(request.Logo!);
            else
                item.LogoUrl = logo;

            await _socialMediaRepository.UpdateAsync(item);

            return new BaseResponse<object>(msg, true, 200);


        }
    }
}
