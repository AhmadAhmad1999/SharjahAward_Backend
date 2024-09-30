using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.CreateChairmanNotesOnFinalArbitrationScore
{
    public class CreateChairmanNotesOnFinalArbitrationScoreHandler
        : IRequestHandler<CreateChairmanNotesOnFinalArbitrationScoreCommand, BaseResponse<object>>
    {
        private readonly IJwtProvider _JwtProvider;
        private readonly IAsyncRepository<ChairmanNotesOnFinalArbitrationScore> _ChairmanNotesOnFinalArbitrationScoreRepository;
        public CreateChairmanNotesOnFinalArbitrationScoreHandler(IJwtProvider JwtProvider,
            IAsyncRepository<ChairmanNotesOnFinalArbitrationScore> ChairmanNotesOnFinalArbitrationScoreRepository)
        {
            _JwtProvider = JwtProvider;
            _ChairmanNotesOnFinalArbitrationScoreRepository = ChairmanNotesOnFinalArbitrationScoreRepository;
        }

        public async Task<BaseResponse<object>> Handle(CreateChairmanNotesOnFinalArbitrationScoreCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int ChairmanId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            ChairmanNotesOnFinalArbitrationScore NewChairmanNotesOnFinalArbitrationScoreEntity = new ChairmanNotesOnFinalArbitrationScore()
            {
                FinalArbitrationScoreId = Request.FinalArbitrationScoreId,
                Note = Request.Note,
                ChairmanId = ChairmanId
            };

            await _ChairmanNotesOnFinalArbitrationScoreRepository.AddAsync(NewChairmanNotesOnFinalArbitrationScoreEntity);

            ResponseMessage = Request.lang == "en"
                ? "Created successfully"
                : "تم إنشاء ملاحظة رئيس اللجنة على التحكيم النهائي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
