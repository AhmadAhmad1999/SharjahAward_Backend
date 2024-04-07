﻿using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Newtonsoft.Json.Linq;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.User.Queries.ChangePassword
{
    public class ChangePasswordQueryHandler
        : IRequestHandler<ChangePasswordQuery, BaseResponse<object>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtProvider _jwtProvider;
        private readonly IMapper _mapper;

        public ChangePasswordQueryHandler(
            IUserRepository userRepository, IMapper mapper, IJwtProvider jwtProvider)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _jwtProvider = jwtProvider;
        }

        public async Task<BaseResponse<object>> Handle(ChangePasswordQuery request, CancellationToken cancellationToken)
        {

            var UserID = request.Id == null
                ? _jwtProvider.GetUserIdFromToken(request.Token)
                : request.Id.ToString();
          
            var user = await _userRepository.GetByIdAsync(new Guid(UserID!));
            string msg;
            if (user == null)
            {
                msg = request.lang == "en"
                    ? "user is not Found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(msg,false,404);
            }

            byte[] salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };

            if (request.Id == null)
            {
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
           
            await _userRepository.ChangePassword(user.Id,request.NewPassword);

            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
