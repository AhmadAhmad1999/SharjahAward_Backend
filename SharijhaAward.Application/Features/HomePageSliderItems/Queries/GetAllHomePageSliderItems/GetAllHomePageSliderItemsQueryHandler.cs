using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.HomePageSliderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.HomePageSliderItems.Queries.GetAllHomePageSliderItems
{
    public class GetAllHomePageSliderItemsQueryHandler
        : IRequestHandler<GetAllHomePageSliderItemsQuery, BaseResponse<List<SliderItemsListVM>>>
    {
        private readonly IAsyncRepository<HomePageSlider> _homePageSliderRepository;
        private readonly IMapper _mapper;
        
        public GetAllHomePageSliderItemsQueryHandler(IAsyncRepository<HomePageSlider> homePageSliderRepository, IMapper mapper)
        {
            _homePageSliderRepository = homePageSliderRepository;
            _mapper = mapper;
        }
        public async Task<BaseResponse<List<SliderItemsListVM>>> Handle(GetAllHomePageSliderItemsQuery request, CancellationToken cancellationToken)
        {
            var AllSliderItem = await _homePageSliderRepository.ListAllAsync();

            var data  = _mapper.Map<List<SliderItemsListVM>>(AllSliderItem);

            return new BaseResponse<List<SliderItemsListVM>>("", true, 200, data);
        }
    }
}
