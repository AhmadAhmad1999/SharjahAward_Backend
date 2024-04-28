using MediatR;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms;
using SharijhaAward.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetFormsBySubscriberId
{
    public class GetFormsBySubscriberIdQuery : IRequest<BaseResponse<List<FormsBySubscriberIdListVM>>>
    {
        public int Id { get; set; }
        public int page {  get; set; }
        public int pageSize { get; set; }
        public string? lang { get; set; }
    }
}
