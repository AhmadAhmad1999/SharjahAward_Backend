using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ArbitratorModel;

namespace SharijhaAward.Application.Features.Arbitrators.Commands.DeleteArbitrator
{
    public class DeleteArbitratorHandler : IRequestHandler<DeleteArbitratorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Arbitrator> _ArbitratorRepository;

        public DeleteArbitratorHandler(IAsyncRepository<Arbitrator> ArbitratorRepository)
        {
            _ArbitratorRepository = ArbitratorRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteArbitratorCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Arbitrator? ArbitratorEntityToDelete = await _ArbitratorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (ArbitratorEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Arbitrator is not found"
                    : "المحكم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _ArbitratorRepository.DeleteAsync(ArbitratorEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Arbitrator has been deleted successfully"
                : "تم حذف المحكم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
