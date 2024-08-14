using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.CreateChairmanNotesOnArbitrationAudit
{
    public class CreateChairmanNotesOnArbitrationAuditHandler : IRequestHandler<CreateChairmanNotesOnArbitrationAuditCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ChairmanNotesOnArbitrationAudit> _ChairmanNotesOnArbitrationAuditRepository;
        public CreateChairmanNotesOnArbitrationAuditHandler(IAsyncRepository<ChairmanNotesOnArbitrationAudit> ChairmanNotesOnArbitrationAuditRepository)
        {
            _ChairmanNotesOnArbitrationAuditRepository = ChairmanNotesOnArbitrationAuditRepository;
        }
        public async Task<BaseResponse<object>> Handle(CreateChairmanNotesOnArbitrationAuditCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ChairmanNotesOnArbitrationAudit NewChairmanNotesOnArbitrationAuditEntity = new ChairmanNotesOnArbitrationAudit()
            {
                ArbitrationAuditId = Request.ArbitrationAuditId,
                Note = Request.Note
            };

            await _ChairmanNotesOnArbitrationAuditRepository.AddAsync(NewChairmanNotesOnArbitrationAuditEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء ملاحظة رئيس اللجنة على تدقيق التحكيم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
