using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.CreateArbitratorClass
{
    public class CreateArbitratorClassCommand : IRequest<BaseResponse<object>>
    {
        public Guid EducationalClassId { get; set; }
        public Guid ArbitratorId { get; set; }
        public string? lang { get; set; }
    }
}
