using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.CreateChairmanNotesOnInitialArbitration
{
    public class CreateChairmanNotesOnInitialArbitrationHandler : IRequestHandler<CreateChairmanNotesOnInitialArbitrationCommand, BaseResponse<object>>
    {
        private readonly IJwtProvider _JwtProvider;
        private readonly IAsyncRepository<ChairmanNotesOnInitialArbitration> _ChairmanNotesOnInitialArbitrationRepository;
        public CreateChairmanNotesOnInitialArbitrationHandler(IJwtProvider JwtProvider,
            IAsyncRepository<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationRepository)
        {
            _JwtProvider = JwtProvider;
            _ChairmanNotesOnInitialArbitrationRepository = ChairmanNotesOnInitialArbitrationRepository;
        }
        public async Task<BaseResponse<object>> Handle(CreateChairmanNotesOnInitialArbitrationCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int ChairmanId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            ChairmanNotesOnInitialArbitration NewChairmanNotesOnInitialArbitrationEntity = new ChairmanNotesOnInitialArbitration()
            {
                InitialArbitrationId = Request.InitialArbitrationId,
                Note = Request.Note,
                ChairmanId = ChairmanId
            };

            await _ChairmanNotesOnInitialArbitrationRepository.AddAsync(NewChairmanNotesOnInitialArbitrationEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء ملاحظة رئيس اللجنة على التحكيم الأولي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
