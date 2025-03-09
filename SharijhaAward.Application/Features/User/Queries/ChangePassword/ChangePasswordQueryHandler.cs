using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.IdentityModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SharijhaAward.Application.Features.User.Queries.ChangePassword
{
    public class ChangePasswordQueryHandler
        : IRequestHandler<ChangePasswordQuery, BaseResponse<object>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<UserToken> _UserTokenRepository;

        public ChangePasswordQueryHandler(
            IUserRepository userRepository, IMapper mapper, IJwtProvider jwtProvider,
            IAsyncRepository<UserToken> UserTokenRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _jwtProvider = jwtProvider;
            _UserTokenRepository = UserTokenRepository;
        }

        public async Task<BaseResponse<object>> Handle(ChangePasswordQuery request, CancellationToken cancellationToken)
        {
            var UserID = request.Id == null
                ? _jwtProvider.GetUserIdFromToken(request.Token)
                : request.Id.ToString();
          
            var user = await _userRepository.GetByIdAsync(int.Parse(UserID));
            string msg;
            if (user == null)
            {
                msg = request.lang == "en"
                    ? "user is not Found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(msg,false,404);
            }

            byte[] salt = new byte[16] { 52, 123, 55, 148, 64, 30, 175, 37, 25, 240, 115, 57, 13, 255, 41, 74 };

            string CheckPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: request.OldPassword!,
            salt: salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));

            if (CheckPassword != user.Password)
            {
                msg = request.lang == "en"
                    ? "Old password is not correct"
                    : "كلمة المرور القديمة غير صحيحة";

                return new BaseResponse<object>(msg, false, 400);
            }

            msg = request.lang == "en"
                ? "Password has been Changed"
                : "تم تعديل كلمة المرور";

            request.NewPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: request.NewPassword,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            List<UserToken> UserTokenEntitiesToDelete = await _UserTokenRepository
                .Where(x => x.UserId == user.Id)
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
                    await _UserTokenRepository.DeleteListAsync(UserTokenEntitiesToDelete);

                    await _userRepository.ChangePassword(user.Id, request.NewPassword);

                    string Token = _jwtProvider.Generate(user);

                    Transaction.Complete();

                    return new BaseResponse<object>(msg, true, 200, Token);
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
