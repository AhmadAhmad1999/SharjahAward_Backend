using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.ImplementInterview
{
    public class ImplementInterviewHandler : IRequestHandler<ImplementInterviewCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public ImplementInterviewHandler(IAsyncRepository<Interview> InterviewRepository,
            IHttpContextAccessor HttpContextAccessor)
        {
            _InterviewRepository = InterviewRepository;
            _HttpContextAccessor = HttpContextAccessor;
        }

        public async Task<BaseResponse<object>> Handle(ImplementInterviewCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Interview? InterviewEntity = await _InterviewRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (InterviewEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Interview is not Found"
                    : "المقابلة غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            bool isHttps = _HttpContextAccessor.HttpContext!.Request.IsHttps;

            string FolderPath = isHttps
                ? $"https://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/InterviewAttachments"
                : $"http://{_HttpContextAccessor.HttpContext?.Request.Host.Value}/InterviewAttachments";

            string? FileName = $"{Request.Id}-{Request.AttachmentFile!.FileName}";

            string? FilePathToSaveIntoDataBase = Path.Combine(FolderPath, FileName);

            string? FolderPathToCreate = Request.WWWRootFilePath!;
            string? FilePathToSaveToCreate = Path.Combine(FolderPathToCreate, FileName);

            while (File.Exists(FilePathToSaveIntoDataBase))
            {
                FilePathToSaveIntoDataBase = FilePathToSaveIntoDataBase + "x";
                FilePathToSaveToCreate = FilePathToSaveToCreate + "x";
            }

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
                    InterviewEntity.AttachmentPath = FilePathToSaveIntoDataBase;
                    InterviewEntity.isImplemented = true;

                    await _InterviewRepository.UpdateAsync(InterviewEntity);

                    using (FileStream FileStream = new FileStream(FilePathToSaveToCreate, FileMode.Create))
                    {
                        Request.AttachmentFile.CopyTo(FileStream);
                    }

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Interview is implemented successfully"
                        : "تم إدخال المعلومات بنجاح";

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
