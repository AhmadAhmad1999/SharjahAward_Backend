using AutoMapper;
using MediatR;
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

                    bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

                    string FolderPath = isHttps
                        ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/DigitalSignatures"
                        : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/DigitalSignatures";

                    string? FileName = $"{NewDigitalSignatureEntity.Id}-{NewDigitalSignatureEntity.UserName}";

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

                    NewDigitalSignatureEntity.ImageUrl = FilePathToSaveIntoDataBase;

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
