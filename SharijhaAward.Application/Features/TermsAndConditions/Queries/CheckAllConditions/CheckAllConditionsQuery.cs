using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.TermsAndConditions.Queries.CheckAllConditions
{
    public class CheckAllConditionsQuery : IRequest<BaseResponse<object>>
    {
        public int CategoryId { get; set; }
        public string lang { get; set; } = string.Empty;
        public string token { get; set; } = string.Empty;
        public int formId {  get; set; }
    }
}
