using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Constants.DynamicAttribute;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.ChangeDynamicAttributeStatus
{
    public class ChangeDynamicAttributeStatusHandler : IRequestHandler<ChangeDynamicAttributeStatusCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        public ChangeDynamicAttributeStatusHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
        }
        public async Task<BaseResponse<object>> Handle(ChangeDynamicAttributeStatusCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            DynamicAttribute? DynamicAttributeEntity = await _DynamicAttributeRepository.GetByIdAsync(Request.Id);

            if (DynamicAttributeEntity == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Field not found"
                    : "هذا الحقل غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            DynamicAttributeEntity.Status = DynamicAttributeEntity.Status == DynamicAttributeStatus.Active
                ? DynamicAttributeStatus.Inactive
                : DynamicAttributeStatus.Active;

            await _DynamicAttributeRepository.SaveChangesAsync();

            ResponseMessage = Request.lang == "en"
                ? "Field's status has been updated successfully"
                : "تم تعديل حالة الحقل بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
