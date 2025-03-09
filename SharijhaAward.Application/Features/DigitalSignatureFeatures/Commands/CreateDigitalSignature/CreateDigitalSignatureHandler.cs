using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DigitalSignatureModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.DigitalSignatureFeatures.Commands.CreateDigitalSignature
{
    public class CreateDigitalSignatureHandler : IRequestHandler<CreateDigitalSignatureCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IJwtProvider _JwtProvider;
        private readonly IAsyncRepository<DigitalSignature> _DigitalSignatureRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public CreateDigitalSignatureHandler(IMapper _Mapper,
            IJwtProvider _JwtProvider,
            IAsyncRepository<DigitalSignature> _DigitalSignatureRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._Mapper = _Mapper;
            this._JwtProvider = _JwtProvider;
            this._DigitalSignatureRepository = _DigitalSignatureRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
        }
        public async Task<BaseResponse<object>> Handle(CreateDigitalSignatureCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            int UserId = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!));

            DigitalSignature NewDigitalSignatureEntity = _Mapper.Map<DigitalSignature>(Request);

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
                    NewDigitalSignatureEntity.UserId = UserId;

                    string? FileName = $"{NewDigitalSignatureEntity.Id}-{Request.Image.FileName}";

                    string? FilePathToSaveIntoDataBase = Request.WWWRootFilePath + $"{FileName}";

                    string? FolderPathToCreate = Request.WWWRootFilePath!;
                    string? FilePathToSaveToCreate = FolderPathToCreate + $"{FileName}";

                    using (FileStream FileStream = new FileStream(FilePathToSaveToCreate, FileMode.Create))
                    {
                        Request.Image.CopyTo(FileStream);
                    }

                    //if (FilePathToSaveIntoDataBase.Contains("wwwroot"))
                    //{
                    //    FilePathToSaveIntoDataBase = FilePathToSaveIntoDataBase
                    //        .Split("wwwroot")[1];

                    //    bool isHttps = _HttpContextAccessor.HttpContext.Request.IsHttps;

                    //    string DownloadBarCodeImageAPI = isHttps
                    //        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}{FilePathToSaveIntoDataBase}"
                    //        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}{FilePathToSaveIntoDataBase}";

                    //    NewDigitalSignatureEntity.ImageUrl = DownloadBarCodeImageAPI;
                    //}
                    //else 
                    NewDigitalSignatureEntity.ImageUrl = FilePathToSaveIntoDataBase;

                    byte[] salt = new byte[16] { 52, 123, 55, 148, 64, 30, 175, 37, 25, 240, 115, 57, 13, 255, 41, 74 };

                    NewDigitalSignatureEntity.Password = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                        password: NewDigitalSignatureEntity.Password,
                        salt: salt,
                        prf: KeyDerivationPrf.HMACSHA256,
                        iterationCount: 100000,
                        numBytesRequested: 256 / 8));

                    await _DigitalSignatureRepository.AddAsync(NewDigitalSignatureEntity);

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء التوقيع الرقمي بنجاح";

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
