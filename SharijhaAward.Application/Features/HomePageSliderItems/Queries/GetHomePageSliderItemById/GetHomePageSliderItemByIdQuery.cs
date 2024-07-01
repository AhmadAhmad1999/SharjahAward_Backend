using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.HomePageSliderItems.Queries.GetHomePageSliderItemById
{
    public class GetHomePageSliderItemByIdQuery : IRequest<BaseResponse<GetHomePageSliderItemByIdDto>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
