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

namespace SharijhaAward.Application.Features.SocialMediaPage.Commands.CreateSocialMediaItem
{
    public class CreateSocialMediaItemCommandHandler
        : IRequestHandler<CreateSocialMediaItemCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<SocialMedia> _socialMediaRepository;
        private readonly IFileService _fileService;
        private readonly IMapper _mapper;

        public CreateSocialMediaItemCommandHandler(IAsyncRepository<SocialMedia> socialMediaRepository, IFileService fileService, IMapper mapper)
        {
            _socialMediaRepository = socialMediaRepository;
            _fileService = fileService;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(CreateSocialMediaItemCommand request, CancellationToken cancellationToken)
        {
            string msg = request.lang == "en"
                ? "Social Media Item has been Added"
                : "تم إضافة عنصر التواصل الإجتماعي";

            var item = _mapper.Map<SocialMedia>(request);

            if(request.Logo != null)
            {
                item.LogoUrl = await _fileService.SaveFileAsync(request.Logo);
            }
            item.ThumbnailUrl = await _fileService.SaveFileAsync(request.Thumbnail);

            await _socialMediaRepository.AddAsync(item);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
