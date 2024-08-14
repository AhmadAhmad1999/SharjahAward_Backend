using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.UpdateChairmanNotesOnArbitrationAudit
{
    public class UpdateChairmanNotesOnArbitrationAuditHandler : IRequestHandler<UpdateChairmanNotesOnArbitrationAuditCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ChairmanNotesOnArbitrationAudit> _ChairmanNotesOnArbitrationAuditRepository;
        private readonly IMapper _Mapper;

        public UpdateChairmanNotesOnArbitrationAuditHandler(IMapper Mapper,
            IAsyncRepository<ChairmanNotesOnArbitrationAudit> ChairmanNotesOnArbitrationAuditRepository)
        {
            _ChairmanNotesOnArbitrationAuditRepository = ChairmanNotesOnArbitrationAuditRepository;
            _Mapper = Mapper;
        }

        public async Task<BaseResponse<object>> Handle(UpdateChairmanNotesOnArbitrationAuditCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ChairmanNotesOnArbitrationAudit? ChairmanNotesOnArbitrationAuditEntityToUpdate = await _ChairmanNotesOnArbitrationAuditRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ChairmanNotesOnArbitrationAuditEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Chairman note on arbitration audit is not found"
                    : "ملاحظة رئيس اللجنة على تدقيق التحكيم غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, ChairmanNotesOnArbitrationAuditEntityToUpdate, typeof(UpdateChairmanNotesOnArbitrationAuditCommand), typeof(ChairmanNotesOnArbitrationAudit));

            await _ChairmanNotesOnArbitrationAuditRepository.UpdateAsync(ChairmanNotesOnArbitrationAuditEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Chairman note on arbitration audit has been updated successfully"
                : "تم تعديل ملاحظة رئيس اللجنة على تدقيق التحكيم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
