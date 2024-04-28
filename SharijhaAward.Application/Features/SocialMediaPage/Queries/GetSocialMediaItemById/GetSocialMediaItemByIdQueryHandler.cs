using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.SocialMediaModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.SocialMediaPage.Queries.GetSocialMediaItemById
{
    public class GetSocialMediaItemByIdQueryHandler
        : IRequestHandler<GetSocialMediaItemByIdQuery, BaseResponse<SocialMediaItemDto>>
    {
        private readonly IAsyncRepository<SocialMedia> _socialMediaRepository;
        private readonly IMapper _mapper;

        public GetSocialMediaItemByIdQueryHandler(IAsyncRepository<SocialMedia> socialMediaRepository, IMapper mapper)
        {
            _socialMediaRepository = socialMediaRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<SocialMediaItemDto>> Handle(GetSocialMediaItemByIdQuery request, CancellationToken cancellationToken)
        {
            var item = await _socialMediaRepository.GetByIdAsync(request.Id);

            if(item == null)
            {
                string msg = request.lang == "en"
                    ? "Social Media Item Not Found"
                    : "عنصرالتواصل الإجتماعي غير موجود";

                return new BaseResponse<SocialMediaItemDto>(msg, false, 404);
            }

            var data = _mapper.Map<SocialMediaItemDto>(item);

            return new BaseResponse<SocialMediaItemDto>("", true, 200, data);
        }
    }
}
