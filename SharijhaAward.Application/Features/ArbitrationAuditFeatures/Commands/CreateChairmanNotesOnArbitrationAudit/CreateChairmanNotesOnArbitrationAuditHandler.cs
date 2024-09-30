using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.ArbitrationAuditFeatures.Commands.CreateChairmanNotesOnArbitrationAudit
{
    public class CreateChairmanNotesOnArbitrationAuditHandler : IRequestHandler<CreateChairmanNotesOnArbitrationAuditCommand, BaseResponse<object>>
    {
        private readonly IJwtProvider _JwtProvider;
        private readonly IAsyncRepository<ChairmanNotesOnArbitrationAudit> _ChairmanNotesOnArbitrationAuditRepository;
        public CreateChairmanNotesOnArbitrationAuditHandler(IJwtProvider JwtProvider,
            IAsyncRepository<ChairmanNotesOnArbitrationAudit> ChairmanNotesOnArbitrationAuditRepository)
        {
            _JwtProvider = JwtProvider;
            _ChairmanNotesOnArbitrationAuditRepository = ChairmanNotesOnArbitrationAuditRepository;
        }
        public async Task<BaseResponse<object>> Handle(CreateChairmanNotesOnArbitrationAuditCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int ChairmanId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            ChairmanNotesOnArbitrationAudit NewChairmanNotesOnArbitrationAuditEntity = new ChairmanNotesOnArbitrationAudit()
            {
                ArbitrationAuditId = Request.ArbitrationAuditId,
                Note = Request.Note,
                ChairmanId = ChairmanId
            };

            await _ChairmanNotesOnArbitrationAuditRepository.AddAsync(NewChairmanNotesOnArbitrationAuditEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء ملاحظة رئيس اللجنة على تدقيق التحكيم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
