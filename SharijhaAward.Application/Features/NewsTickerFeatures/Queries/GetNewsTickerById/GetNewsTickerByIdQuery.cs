using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.NewsTickerFeatures.Queries.GetNewsTickerById
{
    public class GetNewsTickerByIdQuery : IRequest<BaseResponse<GetNewsTickerByIdDto>>
    {
        public int Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
