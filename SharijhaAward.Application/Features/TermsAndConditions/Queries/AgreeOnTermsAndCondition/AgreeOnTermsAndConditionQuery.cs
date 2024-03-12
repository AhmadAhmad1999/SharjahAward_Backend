using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.AgreeOnTermsAndCondition
{
    public class AgreeOnTermsAndConditionQuery : IRequest<BaseResponse<object>>
    {
        public Guid TermId { get; set; }
        public bool IsAgree {  get; set; }
        public string token { get; set; } = string.Empty;
    }
}
