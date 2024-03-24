using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.Settings.Commands.DeleteProfile
{
    public class DeleteProfileHandler : IRequestHandler<DeleteProfileCommand, BaseResponse<object>>
    {
        private IAsyncRepository<Domain.Entities.IdentityModels.User> _UserRepository;
        private readonly IJwtProvider _JWTProvider;

        public DeleteProfileHandler(IAsyncRepository<Domain.Entities.IdentityModels.User> UserRepository,
            IJwtProvider JWTProvider)
        {
            _UserRepository = UserRepository;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<object>> Handle(DeleteProfileCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository.FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower());

            if (UserEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "User is not found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _UserRepository.DeleteAsync(UserEntity);

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
