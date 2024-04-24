using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.UserFeatures.Commands.DeleteUser
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;

        public DeleteUserHandler(IUserRepository UserRepository,
            IAsyncRepository<UserRole> UserRoleRepository)
        {
            _UserRepository = UserRepository;
            _UserRoleRepository = UserRoleRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteUserCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.IdentityModels.User? UserEntityToDelete = await _UserRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (UserEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            List<UserRole> UserRoleEntityToDelete = await _UserRoleRepository
                .Where(x => x.UserId == Request.Id)
                .ToListAsync();

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    await _UserRepository.DeleteAsync(UserEntityToDelete);
                    await _UserRoleRepository.DeleteListAsync(UserRoleEntityToDelete);

                    ResponseMessage = Request.lang == "en"
                        ? "User has been deleted successfully"
                        : "تم حذف المستخدم بنجاح";

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
