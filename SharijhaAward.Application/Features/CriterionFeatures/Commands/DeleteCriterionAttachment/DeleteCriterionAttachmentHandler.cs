using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.DeleteCriterionAttachment
{
    public class DeleteCriterionAttachmentHandler : IRequestHandler<DeleteCriterionAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CriterionAttachment> _CriterionAttachmentRepository;
        public DeleteCriterionAttachmentHandler(IAsyncRepository<CriterionAttachment> CriterionAttachmentRepository)
        {
            _CriterionAttachmentRepository = CriterionAttachmentRepository;
        }

        public async Task<BaseResponse<object>> Handle(DeleteCriterionAttachmentCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            CriterionAttachment? CriterionAttachmentEntity = await _CriterionAttachmentRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CriterionAttachmentId);

            if (CriterionAttachmentEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "File is Not Found"
                    : "الملف الملحق غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _CriterionAttachmentRepository.DeleteAsync(CriterionAttachmentEntity);

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
