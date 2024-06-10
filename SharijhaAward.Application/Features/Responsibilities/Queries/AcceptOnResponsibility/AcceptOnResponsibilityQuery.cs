using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.Responsibilities.Queries.AcceptOnResponsibility
{
    public class AcceptOnResponsibilityQuery : IRequest<BaseResponse<object>>
    {
        public string token { get; set; } = string.Empty;
        public bool Accept { get; set; }
        public int ResponsibilityId { get; set; }
    }
}
