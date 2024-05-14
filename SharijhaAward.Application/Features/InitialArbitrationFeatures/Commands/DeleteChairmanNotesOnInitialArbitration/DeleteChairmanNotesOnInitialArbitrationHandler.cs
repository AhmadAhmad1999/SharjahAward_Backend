using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationModel;

namespace SharijhaAward.Application.Features.InitialArbitrationFeatures.Commands.DeleteChairmanNotesOnInitialArbitration
{
    public class DeleteChairmanNotesOnInitialArbitrationHandler : IRequestHandler<DeleteChairmanNotesOnInitialArbitrationCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ChairmanNotesOnInitialArbitration> _ChairmanNotesOnInitialArbitrationRepository;

        public DeleteChairmanNotesOnInitialArbitrationHandler(IAsyncRepository<ChairmanNotesOnInitialArbitration> ChairmanNotesOnInitialArbitrationRepository)
        {
            _ChairmanNotesOnInitialArbitrationRepository = ChairmanNotesOnInitialArbitrationRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteChairmanNotesOnInitialArbitrationCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ChairmanNotesOnInitialArbitration? ChairmanNotesOnInitialArbitrationEntityToDelete = await _ChairmanNotesOnInitialArbitrationRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ChairmanNotesOnInitialArbitrationEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Chairman note on initial arbitration is not found"
                    : "ملاحظة رئيس اللجنة على التحكيم الأولي غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _ChairmanNotesOnInitialArbitrationRepository.DeleteAsync(ChairmanNotesOnInitialArbitrationEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Chairman notes on initial arbitration has been deleted successfully"
                : "تم حذف ملاحظة رئيس اللجنة على التحكيم الأولي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
