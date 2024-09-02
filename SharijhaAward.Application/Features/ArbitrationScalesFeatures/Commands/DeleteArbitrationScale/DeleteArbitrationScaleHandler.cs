using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitrationScaleModel;

namespace SharijhaAward.Application.Features.ArbitrationScalesFeatures.Commands.DeleteArbitrationScale
{
    public class DeleteArbitrationScaleHandler : IRequestHandler<DeleteArbitrationScaleCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<ArbitrationScale> _ArbitrationScaleRepository;
        public DeleteArbitrationScaleHandler(IAsyncRepository<ArbitrationScale> ArbitrationScaleRepository)
        {
            _ArbitrationScaleRepository = ArbitrationScaleRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteArbitrationScaleCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            ArbitrationScale? ArbitrationScaleEntityToDelete = await _ArbitrationScaleRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ArbitrationScaleEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitration scale is not found"
                    : "المقياس غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _ArbitrationScaleRepository.DeleteAsync(ArbitrationScaleEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Arbitration scale has been deleted successfully"
                : "تم حذف المقياس بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
