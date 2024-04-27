using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.HomePageSliderItems.Queries.GetAllHomePageSliderItems
{
    public class GetAllHomePageSliderItemsQuery 
        : IRequest<BaseResponse<List<SliderItemsListVM>>>
    {
    }
}
