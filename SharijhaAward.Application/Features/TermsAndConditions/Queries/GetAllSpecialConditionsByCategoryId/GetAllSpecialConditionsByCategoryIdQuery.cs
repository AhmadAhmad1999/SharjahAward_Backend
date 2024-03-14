using MediatR;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllSpecialConditionsByCategoryId
{
    public class GetAllSpecialConditionsByCategoryIdQuery 
        : IRequest<BaseResponse<List<PublicTremsAndConditionsListVm>>>
    {
        public Guid CategoryId { get; set; }
        public string lang { get; set; } = string.Empty;
        public string token { get; set; } = string.Empty;
        public int formId {  get; set; }
    }
}
