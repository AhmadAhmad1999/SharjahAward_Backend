using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeSectionsFeatures.Commands.DeleteDynamicAttributeSection;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.DeleteDynamicAttribute
{
    public class DeleteDynamicAttributeHandler : IRequestHandler<DeleteDynamicAttributeCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttribute> _DynamicAttributeRepository;
        public DeleteDynamicAttributeHandler(IAsyncRepository<DynamicAttribute> DynamicAttributeRepository)
        {
            _DynamicAttributeRepository = DynamicAttributeRepository;
        }
        public async Task<BaseResponse<object>> Handle(DeleteDynamicAttributeCommand Request, CancellationToken cancellationToken)
        {
            string ResponseMessage = string.Empty;

            DynamicAttribute? DynamicAttributeToDelete = await _DynamicAttributeRepository.GetByIdAsync(Request.Id);

            if (DynamicAttributeToDelete == null)
            {
                ResponseMessage = Request.lang == "en"
                    ? "Field not found"
                    : "هذا الحقل غير موجود";

                return new BaseResponse<object>(ResponseMessage, false, 404);
            }

            await _DynamicAttributeRepository.DeleteAsync(DynamicAttributeToDelete);

            ResponseMessage = Request.lang == "en"
                ? "Field has been deleted successfully"
                : "تم حذف الحقل بنجاح";

            return new BaseResponse<object>(ResponseMessage, true, 200);
        }
    }
}
