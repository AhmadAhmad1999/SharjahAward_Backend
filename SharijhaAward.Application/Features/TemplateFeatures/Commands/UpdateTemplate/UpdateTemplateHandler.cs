using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.TemplateModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.TemplateFeatures.Commands.UpdateTemplate
{
    public class UpdateTemplateHandler : IRequestHandler<UpdateTemplateCommand, BaseResponse<object>>
    {
        private readonly IMapper _Mapper;
        private readonly IAsyncRepository<Template> _TemplateRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public UpdateTemplateHandler(IMapper _Mapper,
            IAsyncRepository<Template> _TemplateRepository,
            IHttpContextAccessor _HttpContextAccessor)
        {
            this._Mapper = _Mapper;
            this._TemplateRepository = _TemplateRepository;
            this._HttpContextAccessor = _HttpContextAccessor;
        }

        public async Task<BaseResponse<object>> Handle(UpdateTemplateCommand Request, CancellationToken cancellationToken)
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
                    Template? TemplateEntityToUpdate = await _TemplateRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

                    if (TemplateEntityToUpdate == null)
                    {
                        ResponseMessage = Request.lang == "en"
                            ? "Template is not found"
                            : "النموذج غير موجود";

                        return new BaseResponse<object>(ResponseMessage, false, 404);
                    }

                    if (!TemplateEntityToUpdate.isActive &&
                        Request.isActive)
                    {
                        Template? ActiveTemplate = await _TemplateRepository
                            .FirstOrDefaultAsync(x => x.TemplateType == Request.TemplateType &&
                                x.isActive);

                        if (ActiveTemplate is not null)
                        {
                            ActiveTemplate.isActive = false;

                            await _TemplateRepository.UpdateAsync(ActiveTemplate);
                        }
                    }

                    string? FilePathToSaveIntoDataBase = null;

                    if (Request.BackgroundImageFile is not null)
                    {
                        string? FileName = $"{Request.Id}-{Request.TemplateType}-{Request.TemplateVersion}";

                        FilePathToSaveIntoDataBase = Request.WWWRootFilePath + $"/CertificateTemplates/{FileName}";

                        string? FolderPathToCreate = Request.WWWRootFilePath!;
                        string? FilePathToSaveToCreate = FolderPathToCreate + $"/{FileName}";

                        while (File.Exists(FilePathToSaveIntoDataBase))
                        {
                            FilePathToSaveIntoDataBase = FilePathToSaveIntoDataBase + "x";
                            FilePathToSaveToCreate = FilePathToSaveToCreate + "x";
                        }

                        using (FileStream FileStream = new FileStream(FilePathToSaveToCreate, FileMode.Create))
                        {
                            Request.BackgroundImageFile.CopyTo(FileStream);
                        }

                        TemplateEntityToUpdate.BackgroundImageUrl = FilePathToSaveIntoDataBase;
                    }

                    _Mapper.Map(Request, TemplateEntityToUpdate, typeof(UpdateTemplateCommand), typeof(Template));

                    TemplateEntityToUpdate.BackgroundImageUrl = FilePathToSaveIntoDataBase;

                    await _TemplateRepository.UpdateAsync(TemplateEntityToUpdate);

                    ResponseMessage = Request.lang == "en"
                        ? "Template has been updated successfully"
                        : "تم تعديل النموذج بنجاح";

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