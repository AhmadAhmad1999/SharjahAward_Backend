using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.RelatedAccountModel;

namespace SharijhaAward.Application.Features.RelatedAccountFeatures.Commands.RejectRelatingRequest
{
    public class RejectRelatingRequestHandler : IRequestHandler<RejectRelatingRequestCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<RelatedAccountRequest> _RelatedAccountRequestRepository;
        public RejectRelatingRequestHandler(IAsyncRepository<RelatedAccountRequest> RelatedAccountRequestRepository)
        {
            _RelatedAccountRequestRepository = RelatedAccountRequestRepository;
        }
        public async Task<BaseResponse<object>> Handle(RejectRelatingRequestCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            RelatedAccountRequest? RelatedAccountRequestEntity = await _RelatedAccountRequestRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (RelatedAccountRequestEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Request is not found"
                    : "الطلب غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }
            RelatedAccountRequestEntity.Status = Domain.Constants.RelatedAccountRequestStatus.Rejected;
            await _RelatedAccountRequestRepository.DeleteAsync(RelatedAccountRequestEntity);

            ResponseMessage = Request.lang == "en"
                ? "Request rejected successfuly"
                : "تم رفض الطلب بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
