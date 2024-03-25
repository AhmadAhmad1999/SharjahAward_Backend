using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.SigningTheForm
{
    public class SigningTheFormQueryHandler 
        : IRequestHandler<SigningTheFormQuery, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _formRepository;
        private readonly IAsyncRepository<Domain.Entities.IdentityModels.User> _userRepository;
        private readonly IJwtProvider _jwtProvider;

        public SigningTheFormQueryHandler(IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> formRepository, IAsyncRepository<Domain.Entities.IdentityModels.User> userRepository, IJwtProvider jwtProvider)
        {
            _formRepository = formRepository;
            _userRepository = userRepository;
            _jwtProvider = jwtProvider;
        }

        public async Task<BaseResponse<object>> Handle(SigningTheFormQuery request, CancellationToken cancellationToken)
        {
            string msg;
            var UserId = _jwtProvider.GetUserIdFromToken(request.token);
            var User = await _userRepository.GetByIdAsync(new Guid(UserId));
            if (User == null)
            {
                msg = request.lang == "en"
                    ? "You dont have permition"
                    : "لا تمتلك الصلاحية";

                return new BaseResponse<object>("", false, 401);
            }
            var form =  _formRepository.Where(f => f.userId == User.Id && f.Id == request.providedFormId).FirstOrDefault();
            
            if(form == null)
            {
                return new BaseResponse<object>("", false, 404);
            }

            byte[] salt = new byte[16] { 41, 214, 78, 222, 28, 87, 170, 211, 217, 125, 200, 214, 185, 144, 44, 34 };
            string CheckPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: request.password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            if (User.Password == CheckPassword)
            {
                
                form.PercentCompletion = 100;
                form.CurrentStep = 7;

                await _formRepository.UpdateAsync(form);
                msg = request.lang == "en"
                    ? "You Passed all Steps Succssfully"
                    : "تم التسجيل بنجاح";

                return new BaseResponse<object>("", true, 200);
            }
            
            return new BaseResponse<object>("Password Is Not Correct", false, 400);
        }
    }
}
