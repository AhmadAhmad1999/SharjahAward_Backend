using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Commands.UpdateCycleCondition
{
    public class UpdateCycleConditionCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string lang { get; set; } = string.Empty;
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
    }
}
