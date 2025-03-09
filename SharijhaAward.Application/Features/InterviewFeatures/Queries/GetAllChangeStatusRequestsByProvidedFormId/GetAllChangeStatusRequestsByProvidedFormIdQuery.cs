using MediatR;
using SharijhaAward.Application.Responses;

namespace SharijhaAward.Application.Features.InterviewFeatures.Queries.GetAllChangeStatusRequestsByProvidedFormId
{
    public class GetAllChangeStatusRequestsByProvidedFormIdQuery : IRequest<BaseResponse<List<GetAllChangeStatusRequestsByProvidedFormIdListVM>>>
    {
        public int ProvidedFormId { get; set; }
        public string? lang { get; set; }
    }
}
