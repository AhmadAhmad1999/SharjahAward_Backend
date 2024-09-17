using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;

namespace SharijhaAward.Application.Features.Coordinators.Commands.DeleteCoordinator
{
    public class DeleteCoordinatorHandler : IRequestHandler<DeleteCoordinatorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;

        public DeleteCoordinatorHandler(IAsyncRepository<Coordinator> CoordinatorRepository)
        {
            _CoordinatorRepository = CoordinatorRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteCoordinatorCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Coordinator? CoordinatorEntityToDelete = await _CoordinatorRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CoordinatorEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Coordinator is not found"
                    : "المنسق غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _CoordinatorRepository.DeleteAsync(CoordinatorEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Coordinator has been deleted successfully"
                : "تم حذف المنسق بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
