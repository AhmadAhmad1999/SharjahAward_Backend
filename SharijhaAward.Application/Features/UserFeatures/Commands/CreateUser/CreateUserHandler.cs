using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System.Transactions;

namespace SharijhaAward.Application.Features.UserFeatures.Commands.CreateUser
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IUserRepository _UserRepository;
        private readonly IAsyncRepository<UserRole> _UserRoleRepository;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;
        private readonly IJwtProvider _JWTProvider;
        public CreateUserHandler(IMapper Mapper,
            IUserRepository UserRepository,
            IAsyncRepository<UserRole> UserRoleRepository,
            IAsyncRepository<UserToken> UserTokenRepository,
            IJwtProvider JWTProvider)
        {
            _Mapper = Mapper;
            _UserRepository = UserRepository;
            _UserRoleRepository = UserRoleRepository;
            _UserTokenRepository = UserTokenRepository;
            _JWTProvider = JWTProvider;
        }

        public async Task<BaseResponse<object>> Handle(CreateUserCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.IdentityModels.User? CheckEmail = await _UserRepository
                .FirstOrDefaultAsync(x => x.Email.ToLower() == Request.Email.ToLower());

            if (CheckEmail is not null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This email is already used"
                    : "البريد الإلكتروني مستخدم بالفعل";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Domain.Entities.IdentityModels.User NewUserEntity = _Mapper.Map<Domain.Entities.IdentityModels.User>(Request);
            NewUserEntity.ArabicName = "Default Name";
            NewUserEntity.EnglishName = "Default Name";

            byte[] salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

            NewUserEntity.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: NewUserEntity.Password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            NewUserEntity.isValidAccount = true;

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
                    await _UserRepository.AddAsync(NewUserEntity);

                    List<UserRole> NewUserRolesEntities = Request.RolesIds
                        .Select(x => new UserRole()
                        {
                            RoleId = x,
                            UserId = NewUserEntity.Id
                        }).ToList();

                    await _UserRoleRepository.AddRangeAsync(NewUserRolesEntities);

                    string Token = _JWTProvider.Generate(NewUserEntity);

                    UserToken NewUserTokenEntity = new UserToken()
                    {
                        UserId = NewUserEntity.Id,
                        Token = Token,
                        AppLanguage = Request.AppLanguage == null ? Request.lang! : Request.AppLanguage!
                    };

                    await _UserTokenRepository.AddAsync(NewUserTokenEntity);

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء المستخدم بنجاح";

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
