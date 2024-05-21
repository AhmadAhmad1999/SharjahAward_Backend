using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.FinalArbitrationModel;

namespace SharijhaAward.Application.Features.FinalArbitrationFeatures.Commands.DeleteChairmanNotesOnFinalArbitrationScore
{
    public class DeleteChairmanNotesOnFinalArbitrationScoreHandler 
        : IRequestHandler<DeleteChairmanNotesOnFinalArbitrationScoreCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ChairmanNotesOnFinalArbitrationScore> _ChairmanNotesOnFinalArbitrationScoreRepository;

        public DeleteChairmanNotesOnFinalArbitrationScoreHandler(IAsyncRepository<ChairmanNotesOnFinalArbitrationScore> ChairmanNotesOnFinalArbitrationScoreRepository)
        {
            _ChairmanNotesOnFinalArbitrationScoreRepository = ChairmanNotesOnFinalArbitrationScoreRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteChairmanNotesOnFinalArbitrationScoreCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ChairmanNotesOnFinalArbitrationScore? ChairmanNotesOnFinalArbitrationScoreEntityToDelete = await _ChairmanNotesOnFinalArbitrationScoreRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ChairmanNotesOnFinalArbitrationScoreEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Chairman note on final arbitration score is not found"
                    : "ملاحظة رئيس اللجنة على نتيجة التحكيم النهائي غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _ChairmanNotesOnFinalArbitrationScoreRepository.DeleteAsync(ChairmanNotesOnFinalArbitrationScoreEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Chairman notes on final arbitration score has been deleted successfully"
                : "تم حذف ملاحظة رئيس اللجنة على نتيجة التحكيم النهائي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
