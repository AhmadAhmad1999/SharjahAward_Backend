using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.AsignFormToArbitrator
{
    public class AsignFormToArbitratorQuery : IRequest<BaseResponse<object>>
    {
        public int formId { get; set; }
        public int arbitratorId { get; set; }
        public string token { get; set; } = string.Empty;
        public string? lang { get; set; }
    }
}
