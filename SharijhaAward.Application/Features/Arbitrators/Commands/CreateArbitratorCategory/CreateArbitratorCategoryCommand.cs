using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitratorCategory
{
    public class CreateArbitratorCategoryCommand : IRequest<BaseResponse<object>>
    {
        public int CategoryId { get; set; }
        public int ArbitratorId { get; set; }
        public string? lang { get; set; }
    }
}
