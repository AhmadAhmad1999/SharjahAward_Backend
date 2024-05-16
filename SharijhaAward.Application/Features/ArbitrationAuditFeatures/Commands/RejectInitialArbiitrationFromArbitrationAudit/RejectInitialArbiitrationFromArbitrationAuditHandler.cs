using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.RejectInitialArbiitrationFromArbitrationAudit
{
    public class RejectInitialArbiitrationFromArbitrationAuditHandler
        : IRequestHandler<RejectInitialArbiitrationFromArbitrationAuditCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitration> _ArbitrationRepository;
        public RejectInitialArbiitrationFromArbitrationAuditHandler(IAsyncRepository<Arbitration> ArbitrationRepository)
        {
            _ArbitrationRepository = ArbitrationRepository;
        }

        public async Task<BaseResponse<object>> Handle(RejectInitialArbiitrationFromArbitrationAuditCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            await _ArbitrationRepository
                .Where(x => x.ProvidedFormId == Request.FormId)
                .ExecuteUpdateAsync(x => x.SetProperty(y => y.IsRejectedFromArbitrationAuditStep, true));

            ResponseMessage = Request.lang == "en"
                ? "Initial arbitration has been rejected successfully"
                : "تم رفض التحكيم على الاستمارة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
