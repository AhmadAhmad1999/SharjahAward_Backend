using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Commands.DeleteTermAndCondition
{
    public class DeleteTermAndConditionCommand : IRequest<BaseResponse<object>>
    {
        public Guid Id { get; set; }
        public string lang { get; set; } = string.Empty;
    }
}
