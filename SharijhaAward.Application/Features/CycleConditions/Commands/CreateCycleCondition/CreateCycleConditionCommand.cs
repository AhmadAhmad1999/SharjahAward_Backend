using MediatR;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Entities.CycleModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.CycleConditions.Commands.CreateCycleCondition
{
    public class CreateCycleConditionCommand : IRequest<BaseResponse<object>>
    {
        public string ArabicTitle { get; set; } = string.Empty;
        public string EnglishTitle { get; set; } = string.Empty;
        public Guid CycleId { get; set; }
        public string lang { get; set;} = string.Empty;
    }
}
