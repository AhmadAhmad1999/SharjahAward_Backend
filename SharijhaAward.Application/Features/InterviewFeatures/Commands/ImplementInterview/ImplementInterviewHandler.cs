using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.ImplementInterview
{
    public class ImplementInterviewHandler : IRequestHandler<ImplementInterviewMainCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<Interview> _InterviewRepository;
        private readonly IAsyncRepository<InterviewAttachment> _InterviewAttachmentRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public ImplementInterviewHandler(IAsyncRepository<Interview> InterviewRepository,
            IAsyncRepository<InterviewAttachment> InterviewAttachmentRepository,
            IHttpContextAccessor HttpContextAccessor)
        {
            _InterviewRepository = InterviewRepository;
            _InterviewAttachmentRepository = InterviewAttachmentRepository;
            _HttpContextAccessor = HttpContextAccessor;
        }

        public async Task<BaseResponse<object>> Handle(ImplementInterviewMainCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Interview? InterviewEntity = await _InterviewRepository
                .FirstOrDefaultAsync(x => x.Id == Request.InterviewId);

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

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            List<InterviewAttachment> InterviewAttachmentListEntity = new List<InterviewAttachment>();

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    foreach (ImplementInterviewCommand ImplementInterviewCommandDto in Request.ImplementInterviewCommand)
                    {
                        InterviewEntity.isImplemented = true;

                        await _InterviewRepository.UpdateAsync(InterviewEntity);

                        string? FileName = $"{Request.InterviewId}-{ImplementInterviewCommandDto.AttachmentFile!.FileName}";

                        string? FilePathToSaveIntoDataBase = Path.Combine(FolderPath, FileName);

                        string? FolderPathToCreate = Request.WWWRootFilePath!;
                        string? FilePathToSaveToCreate = Path.Combine(FolderPathToCreate, FileName);

                        while (File.Exists(FilePathToSaveIntoDataBase))
                        {
                            FilePathToSaveIntoDataBase = FilePathToSaveIntoDataBase + "x";
                            FilePathToSaveToCreate = FilePathToSaveToCreate + "x";
                        }

                        InterviewAttachment NewInterviewAttachmentEntity = new InterviewAttachment()
                        {
                            AttachementPath = FilePathToSaveIntoDataBase,
                            InterviewId = Request.InterviewId,
                            Description = ImplementInterviewCommandDto.Description,
                            Name = FileName,
                        };

                        InterviewAttachmentListEntity.Add(NewInterviewAttachmentEntity);

                        using (FileStream FileStream = new FileStream(FilePathToSaveToCreate, FileMode.Create))
                        {
                            ImplementInterviewCommandDto.AttachmentFile.CopyTo(FileStream);
                        }
                    }

                    await _InterviewAttachmentRepository.AddRangeAsync(InterviewAttachmentListEntity);

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
