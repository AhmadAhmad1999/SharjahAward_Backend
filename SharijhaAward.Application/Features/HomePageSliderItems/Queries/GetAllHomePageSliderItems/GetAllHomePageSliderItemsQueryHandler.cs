﻿using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
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
            FilterObject filterObject = new FilterObject() { Filters = request.filters };
            var AllSliderItem = await _homePageSliderRepository
                .GetFilterThenPagedReponseAsync(filterObject, request.page, request.perPage);

            var data  = _mapper.Map<List<SliderItemsListVM>>(AllSliderItem);

            foreach(var sliderItem in data)
            {
                sliderItem.Title = request.lang == "en"
                    ? sliderItem.EnglishTitle
                    : sliderItem.ArabicTitle;

                sliderItem.Description = request.lang == "en"
                    ? sliderItem.EnglishDescription
                    : sliderItem.ArabicDescription;
            }

            int count = _homePageSliderRepository.GetCount(h => !h.isDeleted);
            Pagination pagination = new Pagination(request.page, request.perPage, count);
            
            return new BaseResponse<List<SliderItemsListVM>>("", true, 200, data, pagination);
        }
    }
}
