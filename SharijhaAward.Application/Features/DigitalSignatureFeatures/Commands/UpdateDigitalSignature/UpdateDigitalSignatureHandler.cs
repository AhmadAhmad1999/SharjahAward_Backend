using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DigitalSignatureModel;

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

            DigitalSignature? DigitalSignatureEntityToUpdate = await _DigitalSignatureRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (DigitalSignatureEntityToUpdate == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Digital signature is not found"
                    : "التوقيع الرقمي غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            _Mapper.Map(Request, DigitalSignatureEntityToUpdate, typeof(UpdateDigitalSignatureCommand), typeof(DigitalSignature));

            if (Request.UpdateOnImage &&
                Request.Image is not null)
            {
                if (File.Exists(DigitalSignatureEntityToUpdate.ImageUrl))
                    File.Delete(DigitalSignatureEntityToUpdate.ImageUrl);

                bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                string FolderPath = isHttps
                    ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/DigitalSignatures"
                    : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/DigitalSignatures";

                string? FileName = $"{Request.Id}-{Request.UserName}";

                string? FilePathToSaveIntoDataBase = Path.Combine(FolderPath, FileName);

                string? FolderPathToCreate = Request.WWWRootFilePath!;
                string? FilePathToSaveToCreate = Path.Combine(FolderPathToCreate, FileName);

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

            await _DigitalSignatureRepository.UpdateAsync(DigitalSignatureEntityToUpdate);

            ResponseMessage = Request.lang == "en"
                ? "Digital signature has been updated successfully"
                : "تم تعديل التوقيع الرقمي بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}