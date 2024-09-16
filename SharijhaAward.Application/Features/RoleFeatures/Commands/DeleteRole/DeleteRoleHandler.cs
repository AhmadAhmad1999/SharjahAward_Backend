using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;

namespace SharijhaAward.Application.Features.RoleFeatures.Commands.DeleteRole
{
    public class DeleteRoleHandler : IRequestHandler<DeleteRoleCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Role> _RoleRepository;

        public DeleteRoleHandler(IAsyncRepository<Role> RoleRepository)
        {
            _RoleRepository = RoleRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteRoleCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Role? RoleEntityToDelete = await _RoleRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (RoleEntityToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Role is not found"
                    : "الدور غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _RoleRepository.DeleteAsync(RoleEntityToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Role has been deleted successfully"
                : "تم حذف الدور بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}