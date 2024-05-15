using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.CreateChairmanNotesOnInitialArbitration
{
    public class CreateChairmanNotesOnInitialArbitrationHandler : IRequestHandler<CreateChairmanNotesOnInitialArbitrationCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ChairmanNotesOnInitialArbitration> _ChairmanNotesOnInitialArbitrationRepository;
        public CreateChairmanNotesOnInitialArbitrationHandler(IAsyncRepository<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationRepository)
        {
            _ChairmanNotesOnInitialArbitrationRepository = ChairmanNotesOnInitialArbitrationRepository;
        }
        public async Task<BaseResponse<object>> Handle(CreateChairmanNotesOnInitialArbitrationCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ChairmanNotesOnInitialArbitration NewChairmanNotesOnInitialArbitrationEntity = new ChairmanNotesOnInitialArbitration()
            {
                InitialArbitrationId = Request.InitialArbitrationId,
                Note = Request.Note
            };

            await _ChairmanNotesOnInitialArbitrationRepository.AddAsync(NewChairmanNotesOnInitialArbitrationEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء ملاحظة رئيس اللجنة على التحكيم الأولي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
