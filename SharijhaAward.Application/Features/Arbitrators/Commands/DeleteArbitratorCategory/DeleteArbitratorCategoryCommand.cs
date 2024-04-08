using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.DeleteArbitratorCategory
{
    public class DeleteArbitratorCategoryCommand : IRequest<BaseResponse<object>>
    {
        public int Id { get; set; }
        public string? lang { get; set; }
    }
}
