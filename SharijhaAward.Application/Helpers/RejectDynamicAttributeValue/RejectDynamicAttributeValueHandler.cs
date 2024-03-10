using MediatR;
using SharijhaAward.Application.Contract.Persistence;
using SharijhaAward.Application.Features.DynamicAttributeFeatures.Commands.DeleteDynamicAttribute;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.DynamicAttributeModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Helpers.RejectDynamicAttributeValue
{
    public class RejectDynamicAttributeValueHandler : IRequestHandler<RejectDynamicAttributeValueCommand, BaseResponse<object>>
    {
        private readonly IAsyncRepository<DynamicAttributeValue> _DynamicAttributeValueRepository;
        public RejectDynamicAttributeValueHandler(IAsyncRepository<DynamicAttributeValue> DynamicAttributeValueRepository)
        {
            _DynamicAttributeValueRepository = DynamicAttributeValueRepository;
        }
        public async Task<BaseResponse<object>> Handle(RejectDynamicAttributeValueCommand Request, CancellationToken cancellationToken)
        {
            string UpdateSql = $"UPDATE DynamicAttributeValue SET isAccepted = 0 WHERE DynamicAttributeId IN " +
                $"({string.Join(",", Request.DynamicAttributesIds)})";

            await _DynamicAttributeValueRepository.ExecuteUpdateAsync(UpdateSql);

            string ResponseMessage = Request.lang == "en"
                ? "Fields has been rejected successfully"
                : "تم رفض الحقول بنجاح";

            return new BaseResponse<object>();
        }
    }
}
