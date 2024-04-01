using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.AgreeOnCycleCondition
{
    public class AgreeOnCycleConditionQuery : IRequest<BaseResponse<object>>
    {
        public Guid TermId { get; set; }
        public bool IsAgree { get; set; }
        public string token { get; set; } = string.Empty;
        public int formId { get; set; }
    }
}
