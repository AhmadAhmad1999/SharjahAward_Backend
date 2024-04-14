using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitratorClass
{
    public class CreateArbitratorClassCommand : IRequest<BaseResponse<object>>
    {
        public int EducationalClassId { get; set; }
        public int ArbitratorId { get; set; }
        public string? lang { get; set; }
    }
}
