using MediatR;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedFormsForAllSubscriber
{
    public class GetAllFormsForAllSubscriberQuery
        : IRequest<BaseResponse<List<FormListVm>>>
    {
        public int page { get; set; }
        public int perPage { get; set; }
        public string? lang { get; set; }
    }
}
