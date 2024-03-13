using MediatR;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetProvidedFormById
{
    public class GetProvidedFormByIdQuery : IRequest<BaseResponse<ProvidedFormDto>>
    {
        public int Id { get; set; }
    }
}
