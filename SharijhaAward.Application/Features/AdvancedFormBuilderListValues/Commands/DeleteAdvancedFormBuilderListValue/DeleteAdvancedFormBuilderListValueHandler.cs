using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.AdvancedFormBuilderModel;

namespace SharijhaAward.Application.Features.AdvancedFormBuilderListValues.Commands.DeleteAdvancedFormBuilderListValue
{
    public class DeleteAdvancedFormBuilderListValueHandler : IRequestHandler<DeleteAdvancedFormBuilderListValueCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<AdvancedFormBuilderListValue> _AdvancedFormBuilderListValueRepository;
        public DeleteAdvancedFormBuilderListValueHandler(IAsyncRepository<AdvancedFormBuilderListValue> AdvancedFormBuilderListValueRepository)
        {
            _AdvancedFormBuilderListValueRepository = AdvancedFormBuilderListValueRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteAdvancedFormBuilderListValueCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            AdvancedFormBuilderListValue? AdvancedFormBuilderListValueToDelete = await _AdvancedFormBuilderListValueRepository
                .GetByIdAsync(Request.Id);

            if (AdvancedFormBuilderListValueToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Value Not Found"
                    : "هذه القيمة غير موجودة";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _AdvancedFormBuilderListValueRepository.DeleteAsync(AdvancedFormBuilderListValueToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Section has been Deleted successfully"
                : "تم حذف القسم بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
