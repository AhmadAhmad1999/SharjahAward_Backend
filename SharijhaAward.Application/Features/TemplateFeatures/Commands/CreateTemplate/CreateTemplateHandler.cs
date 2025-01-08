using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TemplateModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.TemplateFeatures.Commands.CreateTemplate
{
    public class CreateTemplateHandler : IRequestHandler<CreateTemplateCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Template> _TemplateRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public CreateTemplateHandler(IMapper _Mapper,
            IAsyncRepository<Template> _TemplateRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._Mapper = _Mapper;
            this._TemplateRepository = _TemplateRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<object>> Handle(CreateTemplateCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

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
                    if (Request.isActive)
                    {
                        Template? ActiveTemplateEntity = await _TemplateRepository
                            .FirstOrDefaultAsync(x => x.isActive &&
                                x.TemplateType == Request.TemplateType);

                        if (ActiveTemplateEntity is not null)
                        {
                            ActiveTemplateEntity.isActive = false;
                            await _TemplateRepository.UpdateAsync(ActiveTemplateEntity);
                        }
                    }

                    Template NewTemplateEntity = _Mapper.Map<Template>(Request);

                    if (Request.BackgroundImageFile is not null)
                    {
                        string? FileName = $"{NewTemplateEntity.TemplateType}-{NewTemplateEntity.TemplateVersion}";

                        string? FilePathToSaveIntoDataBase = Request.WWWRootFilePath + $"/CertificateTemplates/{FileName}";

                        string? FolderPathToCreate = Request.WWWRootFilePath!;
                        string? FilePathToSaveToCreate = FolderPathToCreate + $"{FileName}";

                        while (File.Exists(FilePathToSaveIntoDataBase))
                        {
                            FilePathToSaveIntoDataBase = FilePathToSaveIntoDataBase + "x";
                            FilePathToSaveToCreate = FilePathToSaveToCreate + "x";
                        }

                        using (FileStream FileStream = new FileStream(FilePathToSaveToCreate, FileMode.Create))
                        {
                            Request.BackgroundImageFile.CopyTo(FileStream);
                        }

                        NewTemplateEntity.BackgroundImageUrl = FilePathToSaveIntoDataBase;
                    }

                    await _TemplateRepository.AddAsync(NewTemplateEntity);

                    ResponseMessage = Request.lang == "en"
                        ? "Created successfully"
                        : "تم إنشاء النموذج بنجاح";

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
