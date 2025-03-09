using MediatR;
using Microsoft.EntityFrameworkCore;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.InterviewModel;
using SharijhaAward.Domain.Entities.ProvidedFormModel;
using System.Transactions;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.ChangeEligibilityForInterviewForForm
{
    public class ChangeEligibilityForInterviewForFormHandler 
        : IRequestHandler<ChangeEligibilityForInterviewForFormCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository;
        private readonly IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository;
        private readonly IAsyncRepository<RequestForChangeInterviewEligibilityStatus> _RequestForChangeInterviewEligibilityStatusRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;

        public ChangeEligibilityForInterviewForFormHandler(IAsyncRepository<InterviewInvitee> _InterviewInviteeRepository,
            IAsyncRepository<InterviewInviteeParticipant> _InterviewInviteeParticipantRepository,
            IAsyncRepository<RequestForChangeInterviewEligibilityStatus> _RequestForChangeInterviewEligibilityStatusRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository)
        {
            this._InterviewInviteeRepository = _InterviewInviteeRepository;
            this._InterviewInviteeParticipantRepository = _InterviewInviteeParticipantRepository;
            this._RequestForChangeInterviewEligibilityStatusRepository = _RequestForChangeInterviewEligibilityStatusRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
        }

        public async Task<BaseResponse<object>> Handle(ChangeEligibilityForInterviewForFormCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            List<RequestForChangeInterviewEligibilityStatus> RequestForChangeInterviewEligibilityStatusEntities = await _RequestForChangeInterviewEligibilityStatusRepository
                .Where(x => x.ProvidedFormId == Request.ProvidedFormId)
                .ToListAsync();

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ProvidedFormId);

            if (ProvidedFormEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Provided form is not found"
                    : "استمارة المشترك غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            if (ProvidedFormEntity.EligibileForInterview)
            {
                ResponseMessage = Request.lang == "en"
                    ? "This form is already eligibile for interview"
                    : "هذه الاستمارة مؤهلة للمقابلة أساساً";

                return new BaseResponse<object>(ResponseMessage, false, 400);
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
                    if (RequestForChangeInterviewEligibilityStatusEntities.Any())
                        await _RequestForChangeInterviewEligibilityStatusRepository.DeleteListAsync(RequestForChangeInterviewEligibilityStatusEntities);

                    ProvidedFormEntity.EligibileForInterview = true;
                    await _ProvidedFormRepository.UpdateAsync(ProvidedFormEntity);

                    Transaction.Complete();

                    ResponseMessage = Request.lang == "en"
                        ? "Provided form status has been updated successfully"
                        : "تم تعديل حالة التأهل للمقابلة بنجاح";

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
