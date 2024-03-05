using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.ChangeStep
{
    public class ChangeStepQuery : IRequest<BaseResponse<object>>
    {
        public int FormId { get; set; }
    }
}
