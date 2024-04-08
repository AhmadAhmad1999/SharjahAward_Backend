using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitratorCategory
{
    public class CreateArbitratorCategoryCommand : IRequest<BaseResponse<object>>
    {
        public Guid CategoryId { get; set; }
        public Guid ArbitratorId { get; set; }
        public string? lang { get; set; }
    }
}
