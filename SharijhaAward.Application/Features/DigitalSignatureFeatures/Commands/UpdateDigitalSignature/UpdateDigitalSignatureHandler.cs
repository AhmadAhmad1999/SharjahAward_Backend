using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DigitalSignatureModel;
using System.Net.Http;

namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Commands.UpdateDigitalSignature
{
    public class UpdateDigitalSignatureHandler : IRequestHandler<UpdateDigitalSignatureCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper; 
        private readonly IAsyncRepository<DigitalSignature> _DigitalSignatureRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public UpdateDigitalSignatureHandler(IMapper _Mapper,
            IAsyncRepository<DigitalSignature> _DigitalSignatureRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._Mapper = _Mapper;
            this._DigitalSignatureRepository = _DigitalSignatureRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<object>> Handle(UpdateDigitalSignatureCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            byte[] salt = new byte[16] { 52, 123, 55, 148, 64, 30, 175, 37, 25, 240, 115, 57, 13, 255, 41, 74 };

            DigitalSignature? DigitalSignatureEntityToUpdate = await _DigitalSignatureRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (DigitalSignatureEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Digital signature is not found"
                    : "التوقيع الرقمي غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            Request.OldPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: Request.OldPassword,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            if (Request.OldPassword != DigitalSignatureEntityToUpdate.Password ||
                Request.OldUserName != DigitalSignatureEntityToUpdate.UserName)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Invalid user name or password"
                    : "خطأ في اسم المستخدم أو كلمة المرور";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, DigitalSignatureEntityToUpdate, typeof(UpdateDigitalSignatureCommand), typeof(DigitalSignature));

            if (Request.UpdateOnImage &&
                Request.Image is not null)
            {
                if (File.Exists(DigitalSignatureEntityToUpdate.ImageUrl))
                    File.Delete(DigitalSignatureEntityToUpdate.ImageUrl);

                string? FileName = $"{Request.Id}-{Request.UserName}";

                string? FilePathToSaveIntoDataBase = Request.WWWRootFilePath + $"/DigitalSignatures/{FileName}";

                string? FolderPathToCreate = Request.WWWRootFilePath!;
                string? FilePathToSaveToCreate = FolderPathToCreate + $"/{FileName}";

                while (File.Exists(FilePathToSaveIntoDataBase))
                {
                    FilePathToSaveIntoDataBase = FilePathToSaveIntoDataBase + "x";
                    FilePathToSaveToCreate = FilePathToSaveToCreate + "x";
                }

                using (FileStream FileStream = new FileStream(FilePathToSaveToCreate, FileMode.Create))
                {
                    Request.Image.CopyTo(FileStream);
                }

                DigitalSignatureEntityToUpdate.ImageUrl = FilePathToSaveIntoDataBase;
            }

            DigitalSignatureEntityToUpdate.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: DigitalSignatureEntityToUpdate.Password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            await _DigitalSignatureRepository.UpdateAsync(DigitalSignatureEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Digital signature has been updated successfully"
                : "تم تعديل التوقيع الرقمي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}