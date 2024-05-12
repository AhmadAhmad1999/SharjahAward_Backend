using AutoMapper;
using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.Authentication.Login;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.Authentication.CheckConfirmationCodeForSignUp
{
    internal class CheckConfirmationCodeForSignUpHandler : IRequestHandler<CheckConfirmationCodeForSignUpCommand, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JWTProvider;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Cycle> _CycleRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;

        public CheckConfirmationCodeForSignUpHandler(IUserRepository UserRepository,
            IJwtProvider JWTProvider,
            IMapper Mapper,
            IAsyncRepository<Cycle> CycleRepository,
            IAsyncRepository<UserToken> UserTokenRepository)
        {
            _UserRepository = UserRepository;
            _JWTProvider = JWTProvider;
            _Mapper = Mapper;
            _CycleRepository = CycleRepository;
            _UserTokenRepository = UserTokenRepository;
        }

        public async Task<BaseResponse<object>> Handle(CheckConfirmationCodeForSignUpCommand Request, CancellationToken cancellationToken)
        {
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
                    string ResponseMessage = string.Empty;

                    Cycle? ActiveCycleEntity = await _CycleRepository
                        .FirstOrDefaultAsync(x => x.Status == Domain.Constants.Common.Status.Active);

                    Domain.Entities.IdentityModels.User? UserEntity = await _UserRepository
                        .FirstOrDefaultAsync(x => x.Id == Request.Id);

                    if (UserEntity == null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "User is not found"
                            : "المستخدم غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    if (UserEntity.ConfirmationCodeForSignUp != Request.ConfirmationCode)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Invalid confirmation code"
                            : "رقم تحقق غير فعال";

                        return new BaseResponse<object>(ResponseMessage, false, 400);
                    }

                    Domain.Entities.IdentityModels.User? CheckIfEmailIsAlreadyUsed = await _UserRepository
                        .FirstOrDefaultAsync(x => x.isValidAccount && x.Email.ToLower() == UserEntity.Email.ToLower() &&
                            x.Id != UserEntity.Id);

                    if (CheckIfEmailIsAlreadyUsed != null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "This email is already used"
                            : "البريد الإلكتروني مستخدم مسبقاً";

                        return new BaseResponse<object>(ResponseMessage, false, 400);
                    }

                    UserEntity.ConfirmationCodeForSignUp = null;
                    UserEntity.isValidAccount = true;

                    await _UserRepository.UpdateAsync(UserEntity);

                    string Token = _JWTProvider.Generate(UserEntity);

                    if (!string.IsNullOrEmpty(Request.DeviceToken))
                    {
                        UserToken NewUserTokenEntity = new UserToken()
                        {
                            Token = Token,
                            DeviceToken = Request.DeviceToken!,
                            AppLanguage = Request.lang!,
                            UserId = Request.Id
                        };

                        await _UserTokenRepository.AddAsync(NewUserTokenEntity);
                    }

                    AuthenticationResponse Response = new AuthenticationResponse()
                    {
                        token = Token,
                        user = _Mapper.Map<UserDataResponse>(UserEntity),
                        message = "Account confirmed successfully",
                        isSucceed = true,
                        permissions = null,
                        ActiveCycleId = ActiveCycleEntity?.Id
                    };

                    Transaction.Complete();

                    return new BaseResponse<object>(ResponseMessage, true, 200, Response);
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
