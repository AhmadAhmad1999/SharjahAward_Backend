using MediatR;
using SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedForms;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.ProvidedForm.Queries.GetAllProvidedFormsForAllSubscriber
{
    public class GetAllFormsForAllSubscriberQuery
        : IRequest<BaseResponse<List<FormListVm>>>
    {
        public int page { get; set; }
        public int perPage { get; set; }
        public string? lang { get; set; }
        public string? Token { get; set; }
    }
}
