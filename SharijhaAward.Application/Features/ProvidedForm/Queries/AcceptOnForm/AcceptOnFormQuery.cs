using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.AcceptOnForm
{
    public class AcceptOnFormQuery : IRequest<BaseResponse<object>>
    {
        public int formId { get; set; }
        public bool IsAccepted { get; set; }
        public string? ReasonOfRejection { get; set; }
        public string? token { get; set; }
        public string? lang { get; set; }

    }
}
