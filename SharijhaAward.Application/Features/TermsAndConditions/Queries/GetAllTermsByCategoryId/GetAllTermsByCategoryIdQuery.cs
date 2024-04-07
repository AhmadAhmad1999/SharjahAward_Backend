using MediatR;
using SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermsByCategoryId
{
    public class GetAllTermsByCategoryIdQuery : IRequest<BaseResponse<List<TermAndConditionListVM>>>
    {
        public Guid CategoryId { get; set; }
        public string token { get; set; } = string.Empty;
        public string lang { get; set; } = string.Empty;
        public int formId {  get; set; }
    }
}
