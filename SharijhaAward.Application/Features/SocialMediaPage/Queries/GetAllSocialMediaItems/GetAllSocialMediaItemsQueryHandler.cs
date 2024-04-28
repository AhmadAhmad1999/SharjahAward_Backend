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

namespace SharijhaAward.Application.Features.SocialMediaPage.Queries.GetAllSocialMediaItems
{
    public class GetAllSocialMediaItemsQueryHandler
        : IRequestHandler<GetAllSocialMediaItemsQuery, BaseResponse<List<SocialMediaItemListVM>>>
    {
        private readonly IAsyncRepository<SocialMedia> _socialMediaRepository;
        private readonly IMapper _mapper;

        public GetAllSocialMediaItemsQueryHandler(IAsyncRepository<SocialMedia> socialMediaRepository, IMapper mapper)
        {
            _socialMediaRepository = socialMediaRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<List<SocialMediaItemListVM>>> Handle(GetAllSocialMediaItemsQuery request, CancellationToken cancellationToken)
        {
            var AllItems = await _socialMediaRepository.GetPagedReponseAsync(request.page, request.pageSize);
            
            var data = _mapper.Map<List<SocialMediaItemListVM>>(AllItems);

            int Count = _socialMediaRepository.GetCount(s => !s.isDeleted);

            Pagination pagination = new Pagination(request.page, request.pageSize, Count);

            return new BaseResponse<List<SocialMediaItemListVM>>("", true, 200, data, pagination);
        }
    }
}
