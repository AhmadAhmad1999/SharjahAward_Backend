using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DigitalSignatureModel;
using SharijhaAward.Domain.Entities.TemplateModel;

namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Queries.SelectDigitalSignature
{
    public class SelectDigitalSignatureHandler
        : IRequestHandler<SelectDigitalSignatureQuery, BaseResponse<object>>
    {
        private readonly IUserRepository _UserRepository;
        private readonly IJwtProvider _JWTProvider;
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<DigitalSignature> _DigitalSignatureRepository;
        private readonly IAsyncRepository<Template> _TemplateRepository;

        public SelectDigitalSignatureHandler(IUserRepository _UserRepository,
            IJwtProvider _JWTProvider,
            IMapper _Mapper,
            IAsyncRepository<DigitalSignature> _DigitalSignatureRepository,
            IAsyncRepository<Template> _TemplateRepository)
        {
            this._UserRepository = _UserRepository;
            this._JWTProvider = _JWTProvider;
            this._Mapper = _Mapper;
            this._DigitalSignatureRepository = _DigitalSignatureRepository;
            this._TemplateRepository = _TemplateRepository;
        }

        public async Task<BaseResponse<object>> Handle(SelectDigitalSignatureQuery Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Template? TemplateEntity;

            if (Request.TemplateId is null)
                TemplateEntity = await _TemplateRepository
                    .FirstOrDefaultAsync(x => x.isActive &&
                        x.TemplateType == Request.TemplateType);
            else
                TemplateEntity = await _TemplateRepository
                    .FirstOrDefaultAsync(x => x.Id == Request.TemplateId &&
                        x.TemplateType == Request.TemplateType);

            if (TemplateEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Template is not found"
                    : "النموذج غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            int UserId = int.Parse(_JWTProvider.GetUserIdFromToken(Request.Token!));

            byte[] salt = new byte[16] { 52, 123, 55, 148, 64, 30, 175, 37, 25, 240, 115, 57, 13, 255, 41, 74 };

            Request.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: Request.Password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            DigitalSignature? DigitalSignatureEntity = await _DigitalSignatureRepository
                .FirstOrDefaultAsync(x => x.UserId == UserId &&
                    x.UserName.ToLower() == Request.UserName.ToLower() &&
                    x.Password == Request.Password &&
                    x.Id == Request.Id);  
            
            if (DigitalSignatureEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Wrong username or password"
                    : "خطأ في اسم المستخدم او كلمة السر الخاصة بالتوقيع الرقمي";

                return new BaseResponse<object>(ResponseMessage, false, 400);
            }

            List<Domain.Entities.IdentityModels.User> SubscribersEntities = await _UserRepository
                .Where(x => Request.SubscribersIds.Contains(x.Id) &&
                    x.SubscriberId != null)
                .ToListAsync();



            throw new NotImplementedException();
        }
    }
}
