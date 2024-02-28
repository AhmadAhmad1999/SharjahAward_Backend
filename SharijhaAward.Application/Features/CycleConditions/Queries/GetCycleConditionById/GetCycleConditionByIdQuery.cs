using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Queries.GetCycleConditionById
{
    public class GetCycleConditionByIdQuery : IRequest<BaseResponse<CycleConditionDto>>
    {
        public Guid Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
