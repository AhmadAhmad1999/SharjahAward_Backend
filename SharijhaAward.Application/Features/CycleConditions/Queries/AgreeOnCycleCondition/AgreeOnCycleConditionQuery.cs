using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.AgreeOnCycleCondition
{
    public class AgreeOnCycleConditionQuery : IRequest<BaseResponse<object>>
    {
        public int TermId { get; set; }
        public bool IsAgree { get; set; }
        public string token { get; set; } = string.Empty;
        public int formId { get; set; }
    }
}
