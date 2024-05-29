using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.DynamicAttribute;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderFeatures.Commands.ChangeAdvancedFormBuilderStatus
{
    public class ChangeAdvancedFormBuilderStatusHandler : IRequestHandler<ChangeAdvancedFormBuilderStatusCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilder> _AdvancedFormBuilderRepository;
        public ChangeAdvancedFormBuilderStatusHandler(IAsyncRepository<AdvancedFormBuilder> AdvancedFormBuilderRepository)
        {
            _AdvancedFormBuilderRepository = AdvancedFormBuilderRepository;
        }

        public async Task<BaseResponse<object>> Handle(ChangeAdvancedFormBuilderStatusCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AdvancedFormBuilder? AdvancedFormBuilderEntity = await _AdvancedFormBuilderRepository.GetByIdAsync(Request.Id);

            if (AdvancedFormBuilderEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Field not found"
                    : "هذا الحقل غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            AdvancedFormBuilderEntity.Status = AdvancedFormBuilderEntity.Status == DynamicAttributeStatus.Active
                ? DynamicAttributeStatus.Inactive
                : DynamicAttributeStatus.Active;

            await _AdvancedFormBuilderRepository.SaveChangesAsync();

            ResponseMessage = Request.lang == "en"
                ? "Field's status has been updated successfully"
                : "تم تعديل حالة الحقل بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
