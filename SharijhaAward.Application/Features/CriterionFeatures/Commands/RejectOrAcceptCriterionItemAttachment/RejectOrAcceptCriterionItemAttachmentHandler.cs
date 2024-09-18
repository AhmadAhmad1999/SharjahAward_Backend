using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionItemModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.RejectOrAcceptCriterionItemAttachment
{
    public class RejectOrAcceptCriterionItemAttachmentHandler : IRequestHandler<RejectOrAcceptCriterionItemAttachmentCommand,
        BaseResponse<object>>
    {
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        public RejectOrAcceptCriterionItemAttachmentHandler(IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository)
        {
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
        }

        public async Task<BaseResponse<object>> Handle(RejectOrAcceptCriterionItemAttachmentCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            CriterionItemAttachment? CriterionItemAttachmentEntity = await _CriterionItemAttachmentRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CriterionItemAttachmentEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Criterion item attachment is not found"
                    : "مرفق عنصر المعيار غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            CriterionItemAttachmentEntity.IsAccepted = Request.Status;

            if (!string.IsNullOrEmpty(Request.ReasonForRejecting) && !Request.Status)
                CriterionItemAttachmentEntity.ReasonForRejecting = Request.ReasonForRejecting;

            await _CriterionItemAttachmentRepository.UpdateAsync(CriterionItemAttachmentEntity);

            ResponseMessage = Request.Status
                ? (Request.lang == "en"
                    ? "Criterion item attachment is accepted successfully"
                    : "تم قبول مرفق عنصر المعيار بنجاح")
                : (Request.lang == "en"
                    ? "Criterion item attachment is rejected successfully"
                    : "تم رفض مرفق عنصر المعيار بنجاح");

            return new BaseResponse<object>(ResponseMessage, false, 200);
        }
    }
}
