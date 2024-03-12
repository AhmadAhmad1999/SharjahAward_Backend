using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CriterionItemModel;

namespace SharijhaAward.Application.Features.CriterionFeatures.Commands.DeleteCriterionItemAttachment
{
    public class DeleteCriterionItemAttachmentHandler : IRequestHandler<DeleteCriterionItemAttachmentCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<CriterionItemAttachment> _CriterionItemAttachmentRepository;
        public DeleteCriterionItemAttachmentHandler(IAsyncRepository<CriterionItemAttachment> CriterionItemAttachmentRepository)
        {
            _CriterionItemAttachmentRepository = CriterionItemAttachmentRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteCriterionItemAttachmentCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            CriterionItemAttachment? CriterionAttachmentEntity = await _CriterionItemAttachmentRepository
                .FirstOrDefaultAsync(x => x.Id == Request.CriterionItemAttachmentId);

            if (CriterionAttachmentEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "File is Not Found"
                    : "الملف الملحق غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _CriterionItemAttachmentRepository.DeleteAsync(CriterionAttachmentEntity);

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
