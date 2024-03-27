using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CoordinatorModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.Coordinators.Commands.DeleteCoordinator
{
    public class DeleteCoordinatorHandler : IRequestHandler<DeleteCoordinatorCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Coordinator> _CoordinatorRepository;
        private readonly IUserRepository _UserRepository;
        public DeleteCoordinatorHandler(IAsyncRepository<Coordinator> CoordinatorRepository,
            IUserRepository UserRepository)
        {
            _CoordinatorRepository = CoordinatorRepository;
            _UserRepository = UserRepository;
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

            Domain.Entities.IdentityModels.User? UserEntityToDelete = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (UserEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            using(TransactionScope Transaction = new TransactionScope())
            {
                try
                {
                    await _CoordinatorRepository.DeleteAsync(CoordinatorEntityToDelete);
                    await _UserRepository.DeleteAsync(UserEntityToDelete);

                    ResponseMessage = Request.lang == "en"
                        ? "Coordinator has been deleted successfully"
                        : "تم حذف المنسق بنجاح";

                    Transaction.Complete();

                    return new BaseResponse<object>(ResponseMessage, true, 200);
                }
                catch (Exception)
                {
                    Transaction.Dispose();
                    throw;
                }
            }
        }
    }
}
