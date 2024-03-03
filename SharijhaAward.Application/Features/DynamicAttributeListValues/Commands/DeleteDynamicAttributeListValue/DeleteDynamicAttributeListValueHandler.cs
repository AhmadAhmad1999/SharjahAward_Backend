using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
namespace SharijhaAward.Application.Features.DynamicAttributeListValues.Commands.DeleteDynamicAttributeListValue
{
    public class DeleteDynamicAttributeListValueHandler : IRequestHandler<DeleteDynamicAttributeListValueCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttributeListValue> _DynamicAttributeListValueRepository;
        public DeleteDynamicAttributeListValueHandler(IAsyncRepository<DynamicAttributeListValue> DynamicAttributeListValueRepository)
        {
            _DynamicAttributeListValueRepository = DynamicAttributeListValueRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteDynamicAttributeListValueCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            DynamicAttributeListValue? DynamicAttributeListValueToDelete = await _DynamicAttributeListValueRepository
                .GetByIdAsync(Request.Id);

            if (DynamicAttributeListValueToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Value Not Found"
                    : "هذه القيمة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _DynamicAttributeListValueRepository.DeleteAsync(DynamicAttributeListValueToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Section has been Deleted successfully"
                : "تم حذف القسم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
