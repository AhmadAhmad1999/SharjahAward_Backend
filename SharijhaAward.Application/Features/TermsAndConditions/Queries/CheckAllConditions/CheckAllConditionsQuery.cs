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
        public Guid CategoryId { get; set; }
        public string lang { get; set; } = string.Empty;
        public bool IsSpecial {  get; set; }
    }
}
