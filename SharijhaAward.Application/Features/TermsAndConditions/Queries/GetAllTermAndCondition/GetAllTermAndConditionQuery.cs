using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.GetAllTermAndCondition
{
    public class GetAllTermAndConditionQuery :IRequest<BaseResponse<List<TermAndConditionListVM>>>
    {
        public string lang { get; set; } = string.Empty;
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
        public int? CategoryId {  get; set; }
    }
}
