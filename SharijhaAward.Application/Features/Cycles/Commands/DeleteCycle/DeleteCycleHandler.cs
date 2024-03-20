using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;

namespace SharijhaAward.Application.Features.Cycles.Commands.DeleteCycle
{
    public class DeleteCycleHandler : IRequestHandler<DeleteCycleCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        public DeleteCycleHandler(IAsyncRepository<Cycle> CycleRepository)
        {
            _CycleRepository = CycleRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteCycleCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Cycle? CycleEntityToDelete = await _CycleRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CycleEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Cycle is not found"
                    : "الدورة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _CycleRepository.DeleteAsync(CycleEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Cycle has been Deleted successfully"
                : "تم حذف الدورة بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
