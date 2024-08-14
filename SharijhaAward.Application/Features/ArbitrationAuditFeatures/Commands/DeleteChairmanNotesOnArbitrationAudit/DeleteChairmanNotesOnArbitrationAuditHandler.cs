using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.DeleteChairmanNotesOnArbitrationAudit;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.DeleteChairmanNotesOnArbitrationAudit
{
    public class DeleteChairmanNotesOnArbitrationAuditHandler : IRequestHandler<DeleteChairmanNotesOnArbitrationAuditCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ChairmanNotesOnArbitrationAudit> _ChairmanNotesOnArbitrationAuditRepository;

        public DeleteChairmanNotesOnArbitrationAuditHandler(IAsyncRepository<ChairmanNotesOnArbitrationAudit> ChairmanNotesOnArbitrationAuditRepository)
        {
            _ChairmanNotesOnArbitrationAuditRepository = ChairmanNotesOnArbitrationAuditRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteChairmanNotesOnArbitrationAuditCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ChairmanNotesOnArbitrationAudit? ChairmanNotesOnArbitrationAuditEntityToDelete = await _ChairmanNotesOnArbitrationAuditRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ChairmanNotesOnArbitrationAuditEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Chairman note on arbitration audit is not found"
                    : "ملاحظة رئيس اللجنة على تدقيق التحكيم غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _ChairmanNotesOnArbitrationAuditRepository.DeleteAsync(ChairmanNotesOnArbitrationAuditEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Chairman notes on arbitration audit has been deleted successfully"
                : "تم حذف ملاحظة رئيس اللجنة على تدقيق التحكيم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
