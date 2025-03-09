using MediatR;
using Microsoft.AspNetCore.Http;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.ImplementInterviewInvitee
{
    public class ImplementInterviewInviteeHandler : IRequestHandler<ImplementInterviewInviteeMainCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository;
        private readonly IAsyncRepository<InterviewInviteeAttachment> _InterviewInviteeAttachmentRepository;
        private readonly IHttpContextAccessor _HttpContextAccessor;

        public ImplementInterviewInviteeHandler(IAsyncRepository<InterviewInvitee> InterviewInviteeRepository,
            IAsyncRepository<InterviewInviteeAttachment> InterviewInviteeAttachmentRepository,
            IHttpContextAccessor HttpContextAccessor)
        {
            _InterviewInviteeRepository = InterviewInviteeRepository;
            _InterviewInviteeAttachmentRepository = InterviewInviteeAttachmentRepository;
            _HttpContextAccessor = HttpContextAccessor;
        }

        public async Task<BaseResponse<object>> Handle(ImplementInterviewInviteeMainCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            InterviewInvitee? InterviewInviteeEntity = await _InterviewInviteeRepository
                .FirstOrDefaultAsync(x => x.Id == Request.InterviewInviteeId);

            if (InterviewInviteeEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Interview invitee is not Found"
                    : "الدعوة للمقابلة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            TransactionOptions TransactionOptions = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadCommitted,
                Timeout = TimeSpan.FromMinutes(5)
            };

            List<InterviewInviteeAttachment> InterviewInviteeAttachmentListEntity = new List<InterviewInviteeAttachment>();

            using (TransactionScope Transaction = new TransactionScope(TransactionScopeOption.Required,
                TransactionOptions, TransactionScopeAsyncFlowOption.Enabled))
            {
                try
                {
                    foreach (ImplementInterviewInviteeCommand ImplementInterviewInviteeCommandDto in Request.ImplementInterviewInviteeCommand)
                    {
                        InterviewInviteeEntity.isImplemented = true;

                        await _InterviewInviteeRepository.UpdateAsync(InterviewInviteeEntity);

                        string? FileName = $"{Request.InterviewInviteeId}-{ImplementInterviewInviteeCommandDto.AttachmentFile!.FileName}";

                        string? FilePathToSaveIntoDataBase = Request.WWWRootFilePath + $"{FileName}";

                        string? FolderPathToCreate = Request.WWWRootFilePath!;
                        string? FilePathToSaveToCreate = FolderPathToCreate + $"{FileName}";

                        InterviewInviteeAttachment NewInterviewInviteeAttachmentEntity = new InterviewInviteeAttachment()
                        {
                            AttachementPath = FilePathToSaveIntoDataBase,
                            InterviewInviteeId = Request.InterviewInviteeId,
                            Description = ImplementInterviewInviteeCommandDto.Description,
                            Name = FileName,
                        };

                        InterviewInviteeAttachmentListEntity.Add(NewInterviewInviteeAttachmentEntity);

                        using (FileStream FileStream = new FileStream(FilePathToSaveToCreate, FileMode.Create))
                        {
                            ImplementInterviewInviteeCommandDto.AttachmentFile.CopyTo(FileStream);
                        }
                    }

                    await _InterviewInviteeAttachmentRepository.AddRangeAsync(InterviewInviteeAttachmentListEntity);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Interview invitee is implemented successfully"
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
