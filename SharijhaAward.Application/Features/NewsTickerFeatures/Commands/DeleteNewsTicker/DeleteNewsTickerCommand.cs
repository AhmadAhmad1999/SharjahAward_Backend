using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.NewsTickerFeatures.Commands.DeleteNewsTicker
{
    public class DeleteNewsTickerCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
