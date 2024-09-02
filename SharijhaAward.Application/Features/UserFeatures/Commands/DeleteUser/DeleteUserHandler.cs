using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.UserFeatures.Commands.DeleteUser
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;

        public DeleteUserHandler(IUserRepository UserRepository)
        {
            _UserRepository = UserRepository;
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

            await _UserRepository.DeleteAsync(UserEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "User has been deleted successfully"
                : "تم حذف المستخدم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
