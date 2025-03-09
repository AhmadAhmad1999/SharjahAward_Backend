using MediatR;
using SharijhaAward.Application.Contract.Infrastructure;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.ProvidedFormModel;

namespace SharijhaAward.Application.Features.InterviewFeatures.Commands.CreateRequestForChangingEligibilityStatus
{
    public class CreateRequestForChangingEligibilityStatusHandler 
        : IRequestHandler<CreateRequestForChangingEligibilityStatusCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<RequestForChangeInterviewEligibilityStatus> _RequestForChangeInterviewEligibilityStatusRepository;
        private readonly IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository;
        private readonly IJwtProvider _JwtProvider;

        public CreateRequestForChangingEligibilityStatusHandler(IAsyncRepository<RequestForChangeInterviewEligibilityStatus> _RequestForChangeInterviewEligibilityStatusRepository,
            IAsyncRepository<Domain.Entities.ProvidedFormModel.ProvidedForm> _ProvidedFormRepository,
            IJwtProvider _JwtProvider)
        {
            this._RequestForChangeInterviewEligibilityStatusRepository = _RequestForChangeInterviewEligibilityStatusRepository;
            this._ProvidedFormRepository = _ProvidedFormRepository;
            this._JwtProvider = _JwtProvider;
        }

        public async Task<BaseResponse<object>> Handle(CreateRequestForChangingEligibilityStatusCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            Domain.Entities.ProvidedFormModel.ProvidedForm? ProvidedFormEntity = await _ProvidedFormRepository
                .FirstOrDefaultAsync(x => x.Id == Request.ProvidedFormId);

            if (ProvidedFormEntity is null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Provided form is not found"
                    : "استمارة المشترك غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            RequestForChangeInterviewEligibilityStatus NewRequestForChangeInterviewEligibilityStatusEntity = new RequestForChangeInterviewEligibilityStatus()
            {
                Note = Request.Note,
                ProvidedFormId = Request.ProvidedFormId,
                RequestedById = int.Parse(_JwtProvider.GetUserIdFromToken(Request.Token!))
            };

            await _RequestForChangeInterviewEligibilityStatusRepository.AddAsync(NewRequestForChangeInterviewEligibilityStatusEntity);

            ResponseMessage = Request.lang == "en"
                ? "Request has been sent successfully"
                : "تم إرسال الطلب بنجاح";

            return new BaseResponse<object>(ResponseMessage, false, 200);
        }
    }
}
