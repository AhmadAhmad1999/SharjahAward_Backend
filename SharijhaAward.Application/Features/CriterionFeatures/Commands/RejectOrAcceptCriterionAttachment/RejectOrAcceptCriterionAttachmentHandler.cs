using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.RejectOrAcceptCriterionAttachment
{
    public class RejectOrAcceptCriterionAttachmentHandler : IRequestHandler<RejectOrAcceptCriterionAttachmentCommand,
        BaseResponse<object>>
    {
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        public RejectOrAcceptCriterionAttachmentHandler(IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository)
        {
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
        }
        public async Task<BaseResponse<object>> Handle(RejectOrAcceptCriterionAttachmentCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            CriterionAttachment? CriterionAttachmentEntity = await _CriterionAttachmentRepository
                .FirstOrDefaultAsync(x => x.Id == Request.Id);

            if (CriterionAttachmentEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Criterion attachment is not found"
                    : "مرفق المعيار غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            CriterionAttachmentEntity.IsAccepted = Request.Status;

            if (!string.IsNullOrEmpty(Request.ReasonForRejecting) && !Request.Status)
                CriterionAttachmentEntity.ReasonForRejecting = Request.ReasonForRejecting;

            await _CriterionAttachmentRepository.UpdateAsync(CriterionAttachmentEntity);

            ResponseMessage = Request.Status
                ? (Request.lang == "en"
                    ? "Criterion attachment is accepted successfully"
                    : "تم قبول مرفق المعيار بنجاح")
                : (Request.lang == "en"
                    ? "Criterion attachment is rejected successfully"
                    : "تم رفض مرفق المعيار بنجاح");

            return new BaseResponse<object>(ResponseMessage, false, 200);
        }
    }
}
