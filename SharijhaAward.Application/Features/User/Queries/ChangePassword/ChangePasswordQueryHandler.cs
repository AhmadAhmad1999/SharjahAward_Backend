using AutoMapper;
using MediatR;
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
        :IRequestHandler<ChangePasswordQuery, BaseResponse<object>>
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public ChangePasswordQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<object>> Handle(ChangePasswordQuery request, CancellationToken cancellationToken)
        {


            var user = await _userRepository.GetByIdAsync(request.Id);
            string msg;
            if (user == null)
            {
                msg = request.lang == "en"
                    ? "user is not Found"
                    : "المستخدم غير موجود";

                return new BaseResponse<object>(msg,false,404);
            }
            if(user.Password != request.OldPassword)
            {
                msg = request.lang == "en"
                    ? "old password is not matching"
                    : "كلمة المرور غير متطابقة";
                return new BaseResponse<object>(msg, false, 400);
            }
            msg = request.lang == "en"
                   ? "The Password has been Changed"
                   : "تم تغيير كلمة المرور بنجاح";

            user.Password = request.OldPassword;
           
            await _userRepository.ChangePassword(user.Id,request.NewPassword);


            return new BaseResponse<object>(msg, true, 200);
        }
    }
}
