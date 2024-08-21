using MediatR;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms;
using SharijhaAward.Application.Responses;
using SharijhaAward.Domain.Common;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedFormsForAllSubscriber
{
    public class GetAllFormsForAllSubscriberQuery
        : IRequest<BaseResponse<List<FormListVm>>>
    {
        public int page { get; set; } = 1;
        public int perPage { get; set; } = 10;
        public List<Filter>? filters { get; set; }
        public string? SubscriberName { get; set; }
        public string? lang { get; set; }
        public string? Token { get; set; }
    }
}
