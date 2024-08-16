using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.AddFinalScoreToArbitratoinForFormId
{
    public class AddFinalScoreToArbitratoinForFormIdHandler
        : IRequestHandler<AddFinalScoreToArbitratoinForFormIdCommand, BaseResponse<object>>
    {

        public async Task<BaseResponse<object>> Handle(AddFinalScoreToArbitratoinForFormIdCommand Request, CancellationToken cancellationToken)
        {
            return new BaseResponse<object>();
        }
    }
}
